// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: service_friendslist.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.WebUI.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CFriendsList_FavoritesChanged_Notification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<CFriendsListFavoriteEntry> favorites { get; } = new global::System.Collections.Generic.List<CFriendsListFavoriteEntry>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CFriendsList_GetCategories_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CFriendsList_GetCategories_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<CFriendsListCategory> categories { get; } = new global::System.Collections.Generic.List<CFriendsListCategory>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CFriendsList_GetFavorites_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CFriendsList_GetFavorites_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<CFriendsListFavoriteEntry> favorites { get; } = new global::System.Collections.Generic.List<CFriendsListFavoriteEntry>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CFriendsList_GetFriendsList_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CFriendsList_GetFriendsList_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public CMsgClientFriendsList friendslist { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CFriendsList_SetFavorites_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<CFriendsListFavoriteEntry> favorites { get; } = new global::System.Collections.Generic.List<CFriendsListFavoriteEntry>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CFriendsList_SetFavorites_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CFriendsListCategory : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint groupid
        {
            get => __pbn__groupid.GetValueOrDefault();
            set => __pbn__groupid = value;
        }
        public bool ShouldSerializegroupid() => __pbn__groupid != null;
        public void Resetgroupid() => __pbn__groupid = null;
        private uint? __pbn__groupid;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get => __pbn__name ?? "";
            set => __pbn__name = value;
        }
        public bool ShouldSerializename() => __pbn__name != null;
        public void Resetname() => __pbn__name = null;
        private string __pbn__name;

        [global::ProtoBuf.ProtoMember(3)]
        public global::System.Collections.Generic.List<uint> accountid_members { get; } = new global::System.Collections.Generic.List<uint>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CFriendsListFavoriteEntry : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint accountid
        {
            get => __pbn__accountid.GetValueOrDefault();
            set => __pbn__accountid = value;
        }
        public bool ShouldSerializeaccountid() => __pbn__accountid != null;
        public void Resetaccountid() => __pbn__accountid = null;
        private uint? __pbn__accountid;

        [global::ProtoBuf.ProtoMember(2)]
        public uint clanid
        {
            get => __pbn__clanid.GetValueOrDefault();
            set => __pbn__clanid = value;
        }
        public bool ShouldSerializeclanid() => __pbn__clanid != null;
        public void Resetclanid() => __pbn__clanid = null;
        private uint? __pbn__clanid;

        [global::ProtoBuf.ProtoMember(3)]
        public ulong chat_group_id
        {
            get => __pbn__chat_group_id.GetValueOrDefault();
            set => __pbn__chat_group_id = value;
        }
        public bool ShouldSerializechat_group_id() => __pbn__chat_group_id != null;
        public void Resetchat_group_id() => __pbn__chat_group_id = null;
        private ulong? __pbn__chat_group_id;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgClientFriendsList : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public bool bincremental
        {
            get => __pbn__bincremental.GetValueOrDefault();
            set => __pbn__bincremental = value;
        }
        public bool ShouldSerializebincremental() => __pbn__bincremental != null;
        public void Resetbincremental() => __pbn__bincremental = null;
        private bool? __pbn__bincremental;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<CMsgClientFriendsList_Friend> friends { get; } = new global::System.Collections.Generic.List<CMsgClientFriendsList_Friend>();

        [global::ProtoBuf.ProtoMember(3)]
        public uint max_friend_count
        {
            get => __pbn__max_friend_count.GetValueOrDefault();
            set => __pbn__max_friend_count = value;
        }
        public bool ShouldSerializemax_friend_count() => __pbn__max_friend_count != null;
        public void Resetmax_friend_count() => __pbn__max_friend_count = null;
        private uint? __pbn__max_friend_count;

        [global::ProtoBuf.ProtoMember(4)]
        public uint active_friend_count
        {
            get => __pbn__active_friend_count.GetValueOrDefault();
            set => __pbn__active_friend_count = value;
        }
        public bool ShouldSerializeactive_friend_count() => __pbn__active_friend_count != null;
        public void Resetactive_friend_count() => __pbn__active_friend_count = null;
        private uint? __pbn__active_friend_count;

        [global::ProtoBuf.ProtoMember(5)]
        public bool friends_limit_hit
        {
            get => __pbn__friends_limit_hit.GetValueOrDefault();
            set => __pbn__friends_limit_hit = value;
        }
        public bool ShouldSerializefriends_limit_hit() => __pbn__friends_limit_hit != null;
        public void Resetfriends_limit_hit() => __pbn__friends_limit_hit = null;
        private bool? __pbn__friends_limit_hit;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgClientFriendsList_Friend : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong ulfriendid
        {
            get => __pbn__ulfriendid.GetValueOrDefault();
            set => __pbn__ulfriendid = value;
        }
        public bool ShouldSerializeulfriendid() => __pbn__ulfriendid != null;
        public void Resetulfriendid() => __pbn__ulfriendid = null;
        private ulong? __pbn__ulfriendid;

        [global::ProtoBuf.ProtoMember(2)]
        public uint efriendrelationship
        {
            get => __pbn__efriendrelationship.GetValueOrDefault();
            set => __pbn__efriendrelationship = value;
        }
        public bool ShouldSerializeefriendrelationship() => __pbn__efriendrelationship != null;
        public void Resetefriendrelationship() => __pbn__efriendrelationship = null;
        private uint? __pbn__efriendrelationship;

    }

    public class FriendsList : SteamUnifiedMessages.UnifiedService
    {
        public override string ServiceName { get; } = "FriendsList";

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CFriendsList_GetCategories_Response>> GetCategories(CFriendsList_GetCategories_Request request)
        {
            return UnifiedMessages.SendMessage<CFriendsList_GetCategories_Request, CFriendsList_GetCategories_Response>( "FriendsList.GetCategories#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CFriendsList_GetFavorites_Response>> GetFavorites(CFriendsList_GetFavorites_Request request)
        {
            return UnifiedMessages.SendMessage<CFriendsList_GetFavorites_Request, CFriendsList_GetFavorites_Response>( "FriendsList.GetFavorites#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CFriendsList_GetFriendsList_Response>> GetFriendsList(CFriendsList_GetFriendsList_Request request)
        {
            return UnifiedMessages.SendMessage<CFriendsList_GetFriendsList_Request, CFriendsList_GetFriendsList_Response>( "FriendsList.GetFriendsList#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CFriendsList_SetFavorites_Response>> SetFavorites(CFriendsList_SetFavorites_Request request)
        {
            return UnifiedMessages.SendMessage<CFriendsList_SetFavorites_Request, CFriendsList_SetFavorites_Response>( "FriendsList.SetFavorites#1", request );
        }

        public override void HandleResponseMsg( string methodName, PacketClientMsgProtobuf packetMsg )
        {
            switch ( methodName )
            {
                case "GetCategories":
                    UnifiedMessages.HandleResponseMsg<CFriendsList_GetCategories_Response>( packetMsg );
                    break;
                case "GetFavorites":
                    UnifiedMessages.HandleResponseMsg<CFriendsList_GetFavorites_Response>( packetMsg );
                    break;
                case "GetFriendsList":
                    UnifiedMessages.HandleResponseMsg<CFriendsList_GetFriendsList_Response>( packetMsg );
                    break;
                case "SetFavorites":
                    UnifiedMessages.HandleResponseMsg<CFriendsList_SetFavorites_Response>( packetMsg );
                    break;
            }
        }

        public override void HandleNotificationMsg( string methodName, PacketClientMsgProtobuf packetMsg )
        {
        }
    }

    public class FriendsListClient : SteamUnifiedMessages.UnifiedService
    {
        public override string ServiceName { get; } = "FriendsListClient";

        public void FavoritesChanged(CFriendsList_FavoritesChanged_Notification request)
        {
            UnifiedMessages.SendNotification<CFriendsList_FavoritesChanged_Notification>( "FriendsListClient.FavoritesChanged#1", request );
        }

        public override void HandleResponseMsg( string methodName, PacketClientMsgProtobuf packetMsg )
        {
        }

        public override void HandleNotificationMsg( string methodName, PacketClientMsgProtobuf packetMsg )
        {
            switch ( methodName )
            {
                case "FavoritesChanged":
                    UnifiedMessages.HandleNotificationMsg<CFriendsList_FavoritesChanged_Notification>( packetMsg );
                    break;
            }
        }
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
