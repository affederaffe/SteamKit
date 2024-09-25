// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: steammessages_linkfilter.steamclient.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CCommunity_GetLinkFilterHashPrefixes_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint hit_type
        {
            get => __pbn__hit_type.GetValueOrDefault();
            set => __pbn__hit_type = value;
        }
        public bool ShouldSerializehit_type() => __pbn__hit_type != null;
        public void Resethit_type() => __pbn__hit_type = null;
        private uint? __pbn__hit_type;

        [global::ProtoBuf.ProtoMember(2)]
        public uint count
        {
            get => __pbn__count.GetValueOrDefault();
            set => __pbn__count = value;
        }
        public bool ShouldSerializecount() => __pbn__count != null;
        public void Resetcount() => __pbn__count = null;
        private uint? __pbn__count;

        [global::ProtoBuf.ProtoMember(3)]
        public ulong start
        {
            get => __pbn__start.GetValueOrDefault();
            set => __pbn__start = value;
        }
        public bool ShouldSerializestart() => __pbn__start != null;
        public void Resetstart() => __pbn__start = null;
        private ulong? __pbn__start;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCommunity_GetLinkFilterHashPrefixes_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<uint> hash_prefixes { get; } = new global::System.Collections.Generic.List<uint>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCommunity_GetLinkFilterHashes_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint hit_type
        {
            get => __pbn__hit_type.GetValueOrDefault();
            set => __pbn__hit_type = value;
        }
        public bool ShouldSerializehit_type() => __pbn__hit_type != null;
        public void Resethit_type() => __pbn__hit_type = null;
        private uint? __pbn__hit_type;

        [global::ProtoBuf.ProtoMember(2)]
        public uint count
        {
            get => __pbn__count.GetValueOrDefault();
            set => __pbn__count = value;
        }
        public bool ShouldSerializecount() => __pbn__count != null;
        public void Resetcount() => __pbn__count = null;
        private uint? __pbn__count;

        [global::ProtoBuf.ProtoMember(3)]
        public ulong start
        {
            get => __pbn__start.GetValueOrDefault();
            set => __pbn__start = value;
        }
        public bool ShouldSerializestart() => __pbn__start != null;
        public void Resetstart() => __pbn__start = null;
        private ulong? __pbn__start;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCommunity_GetLinkFilterHashes_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<byte[]> hashes { get; } = new global::System.Collections.Generic.List<byte[]>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCommunity_GetLinkFilterListVersion_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint hit_type
        {
            get => __pbn__hit_type.GetValueOrDefault();
            set => __pbn__hit_type = value;
        }
        public bool ShouldSerializehit_type() => __pbn__hit_type != null;
        public void Resethit_type() => __pbn__hit_type = null;
        private uint? __pbn__hit_type;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCommunity_GetLinkFilterListVersion_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string version
        {
            get => __pbn__version ?? "";
            set => __pbn__version = value;
        }
        public bool ShouldSerializeversion() => __pbn__version != null;
        public void Resetversion() => __pbn__version = null;
        private string __pbn__version;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong count
        {
            get => __pbn__count.GetValueOrDefault();
            set => __pbn__count = value;
        }
        public bool ShouldSerializecount() => __pbn__count != null;
        public void Resetcount() => __pbn__count = null;
        private ulong? __pbn__count;

    }

    public class CommunityLinkFilter : SteamUnifiedMessages.UnifiedService
    {
        internal override string ServiceName { get; } = "CommunityLinkFilter";

        public AsyncJob<SteamUnifiedMessages.ServiceMsg<CCommunity_GetLinkFilterHashPrefixes_Response>> GetLinkFilterHashPrefixes(CCommunity_GetLinkFilterHashPrefixes_Request request)
        {
            return UnifiedMessages.SendMessage<CCommunity_GetLinkFilterHashPrefixes_Request, CCommunity_GetLinkFilterHashPrefixes_Response>( $"CommunityLinkFilter.GetLinkFilterHashPrefixes#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMsg<CCommunity_GetLinkFilterHashes_Response>> GetLinkFilterHashes(CCommunity_GetLinkFilterHashes_Request request)
        {
            return UnifiedMessages.SendMessage<CCommunity_GetLinkFilterHashes_Request, CCommunity_GetLinkFilterHashes_Response>( $"CommunityLinkFilter.GetLinkFilterHashes#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMsg<CCommunity_GetLinkFilterListVersion_Response>> GetLinkFilterListVersion(CCommunity_GetLinkFilterListVersion_Request request)
        {
            return UnifiedMessages.SendMessage<CCommunity_GetLinkFilterListVersion_Request, CCommunity_GetLinkFilterListVersion_Response>( $"CommunityLinkFilter.GetLinkFilterListVersion#1", request );
        }

        internal override void HandleMsg( string methodName, IPacketMsg packetMsg )
        {
            switch ( methodName )
            {
                case "GetLinkFilterHashPrefixes":
                    UnifiedMessages.HandleServiceMsg<CCommunity_GetLinkFilterHashPrefixes_Response>( packetMsg );
                    break;
                case "GetLinkFilterHashes":
                    UnifiedMessages.HandleServiceMsg<CCommunity_GetLinkFilterHashes_Response>( packetMsg );
                    break;
                case "GetLinkFilterListVersion":
                    UnifiedMessages.HandleServiceMsg<CCommunity_GetLinkFilterListVersion_Response>( packetMsg );
                    break;
            }
        }
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
