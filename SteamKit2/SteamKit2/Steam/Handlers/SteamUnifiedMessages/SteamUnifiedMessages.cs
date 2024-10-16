﻿/*
 * This file is subject to the terms and conditions defined in
 * file 'license.txt', which is part of this source code package.
 */

using System;
using System.Collections.Concurrent;
using ProtoBuf;

namespace SteamKit2
{
    /// <summary>
    /// This handler is used for interacting with Steamworks unified messaging.
    /// </summary>
    public partial class SteamUnifiedMessages : ClientMsgHandler
    {
        private readonly ConcurrentDictionary<string, object> _handlers = [ ];

        /// <summary>
        /// Creates a service that can be used to send messages and receive notifications via Steamworks unified messaging.
        /// </summary>
        /// <typeparam name="TService">The type of the service to create.</typeparam>
        /// <returns>The instance to create requests from.</returns>
        public TService CreateService<TService>() where TService : class, IUnifiedService, new()
        {
            return ( _handlers.GetOrAdd( TService.ServiceName, static ( _, unifiedMessages ) =>
                new TService { UnifiedMessages = unifiedMessages }, this ) as TService )!;
        }

        /// <summary>
        /// Removes a service so it no longer can be used to send messages or receive notifications.
        /// </summary>
        /// <typeparam name="TService">The type of the service to remove.</typeparam>
        public void RemoveService<TService>() where TService : IUnifiedService, new()
        {
            _handlers.TryRemove( TService.ServiceName, out _ );
        }

        /// <summary>
        /// Sends a message.
        /// Results are returned in a <see cref="ServiceMethodResponse{TResult}"/>.
        /// The returned <see cref="AsyncJob{T}"/> can also be awaited to retrieve the callback result.
        /// </summary>
        /// <typeparam name="TRequest">The type of a protobuf object.</typeparam>
        /// <typeparam name="TResult">The type of the result of the request.</typeparam>
        /// <param name="name">Name of the RPC endpoint. Takes the format ServiceName.RpcName</param>
        /// <param name="message">The message to send.</param>
        /// <returns>The JobID of the request. This can be used to find the appropriate <see cref="ServiceMethodResponse{TResult}"/>.</returns>
        public AsyncJob<ServiceMethodResponse<TResult>> SendMessage<TRequest, TResult>( string name, TRequest message )
            where TRequest : IExtensible, new() where TResult : IExtensible, new()
        {
            if ( message is null )
            {
                throw new ArgumentNullException( nameof( message ) );
            }

            var eMsg = Client.SteamID is null ? EMsg.ServiceMethodCallFromClientNonAuthed : EMsg.ServiceMethodCallFromClient;
            var msg = new ClientMsgProtobuf<TRequest>( eMsg )
            {
                SourceJobID = Client.GetNextJobID()
            };

            msg.Header.Proto.target_job_name = name;
            msg.Body = message;
            Client.Send( msg );

            return new AsyncJob<ServiceMethodResponse<TResult>>( Client, msg.SourceJobID );
        }

        /// <summary>
        /// Sends a notification.
        /// </summary>
        /// <typeparam name="TRequest">The type of a protobuf object.</typeparam>
        /// <param name="name">Name of the RPC endpoint. Takes the format ServiceName.RpcName</param>
        /// <param name="message">The message to send.</param>
        public void SendNotification<TRequest>( string name, TRequest message )
            where TRequest : IExtensible, new()
        {
            if ( message is null )
            {
                throw new ArgumentNullException( nameof( message ) );
            }

            // Notifications do not set source jobid, otherwise Steam server will actively reject this message
            // if the method being used is a "Notification"
            var eMsg = Client.SteamID is null ? EMsg.ServiceMethodCallFromClientNonAuthed : EMsg.ServiceMethodCallFromClient;
            var msg = new ClientMsgProtobuf<TRequest>( eMsg );
            msg.Header.Proto.target_job_name = name;
            msg.Body = message;
            Client.Send( msg );
        }

        /// <inheritdoc />
        public override void HandleMsg( IPacketMsg packetMsg )
        {
            if (packetMsg is not PacketClientMsgProtobuf { MsgType: EMsg.ServiceMethod or EMsg.ServiceMethodResponse } packetMsgProto)
                return;

            var jobName = packetMsgProto.Header.Proto.target_job_name.AsSpan();
            if (jobName.IsEmpty)
                return;

            // format: Service.Method#Version
            var dot = jobName.IndexOf( '.' );
            var hash = jobName.LastIndexOf( '#' );
            if ( dot < 0 || hash < 0 )
                return;

            var serviceName = jobName[ ..dot ].ToString();

            if (!_handlers.TryGetValue( serviceName, out var handlerObj ) )
                return;

            var handler = (handlerObj as IUnifiedService)!;
            var methodName = jobName[ ( dot + 1 )..hash ].ToString();

            switch ( packetMsgProto.MsgType )
            {
                case EMsg.ServiceMethodResponse:
                    handler.HandleResponseMsg( methodName, packetMsgProto );
                    break;
                case EMsg.ServiceMethod:
                    handler.HandleNotificationMsg( methodName, packetMsgProto );
                    break;
            }
        }

        internal void HandleResponseMsg<TService>( PacketClientMsgProtobuf packetMsg) where TService : IExtensible, new()
        {
            var callback = new ServiceMethodResponse<TService>( packetMsg );
            Client.PostCallback( callback );
        }

        internal void HandleNotificationMsg<TService>( PacketClientMsgProtobuf packetMsg) where TService : IExtensible, new()
        {
            var callback = new ServiceMethodNotification<TService>( packetMsg );
            Client.PostCallback( callback );
        }

        /// <summary>
        /// Abstract definition of a steam unified messages service.
        /// </summary>
        public interface IUnifiedService
        {
            /// <summary>
            /// The name of the steam unified messages service.
            /// </summary>
            public static abstract string ServiceName { get; }

            /// <summary>
            /// Handles a response message for this service. This should not be called directly.
            /// </summary>
            /// <param name="methodName">The name of the method the service should handle</param>
            /// <param name="packetMsg">The packet message that contains the data</param>
            public void HandleResponseMsg( string methodName, PacketClientMsgProtobuf packetMsg );

            /// <summary>
            /// Handles a notification message for this service. This should not be called directly.
            /// </summary>
            /// <param name="methodName">The name of the method the service should handle</param>
            /// <param name="packetMsg">The packet message that contains the data</param>
            public void HandleNotificationMsg( string methodName, PacketClientMsgProtobuf packetMsg );

            /// <summary>
            /// A reference to the <see cref="SteamUnifiedMessages"/> instance this service was created from.
            /// </summary>
            public SteamUnifiedMessages? UnifiedMessages { get; init; }
        }
    }
}
