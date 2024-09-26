// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: steammessages_contentsystem.steamclient.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CContentServerDirectory_ConnectedSteamPipeServerInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string type
        {
            get => __pbn__type ?? "";
            set => __pbn__type = value;
        }
        public bool ShouldSerializetype() => __pbn__type != null;
        public void Resettype() => __pbn__type = null;
        private string __pbn__type;

        [global::ProtoBuf.ProtoMember(2)]
        public int source_id
        {
            get => __pbn__source_id.GetValueOrDefault();
            set => __pbn__source_id = value;
        }
        public bool ShouldSerializesource_id() => __pbn__source_id != null;
        public void Resetsource_id() => __pbn__source_id = null;
        private int? __pbn__source_id;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string hostname
        {
            get => __pbn__hostname ?? "";
            set => __pbn__hostname = value;
        }
        public bool ShouldSerializehostname() => __pbn__hostname != null;
        public void Resethostname() => __pbn__hostname = null;
        private string __pbn__hostname;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CContentServerDirectory_GetServersForSteamPipe_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint cell_id
        {
            get => __pbn__cell_id.GetValueOrDefault();
            set => __pbn__cell_id = value;
        }
        public bool ShouldSerializecell_id() => __pbn__cell_id != null;
        public void Resetcell_id() => __pbn__cell_id = null;
        private uint? __pbn__cell_id;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(20u)]
        public uint max_servers
        {
            get => __pbn__max_servers ?? 20u;
            set => __pbn__max_servers = value;
        }
        public bool ShouldSerializemax_servers() => __pbn__max_servers != null;
        public void Resetmax_servers() => __pbn__max_servers = null;
        private uint? __pbn__max_servers;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string ip_override
        {
            get => __pbn__ip_override ?? "";
            set => __pbn__ip_override = value;
        }
        public bool ShouldSerializeip_override() => __pbn__ip_override != null;
        public void Resetip_override() => __pbn__ip_override = null;
        private string __pbn__ip_override;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(0)]
        public int launcher_type
        {
            get => __pbn__launcher_type ?? 0;
            set => __pbn__launcher_type = value;
        }
        public bool ShouldSerializelauncher_type() => __pbn__launcher_type != null;
        public void Resetlauncher_type() => __pbn__launcher_type = null;
        private int? __pbn__launcher_type;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string ipv6_public
        {
            get => __pbn__ipv6_public ?? "";
            set => __pbn__ipv6_public = value;
        }
        public bool ShouldSerializeipv6_public() => __pbn__ipv6_public != null;
        public void Resetipv6_public() => __pbn__ipv6_public = null;
        private string __pbn__ipv6_public;

        [global::ProtoBuf.ProtoMember(6)]
        public global::System.Collections.Generic.List<CContentServerDirectory_ConnectedSteamPipeServerInfo> current_connections { get; } = new global::System.Collections.Generic.List<CContentServerDirectory_ConnectedSteamPipeServerInfo>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CContentServerDirectory_ServerInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string type
        {
            get => __pbn__type ?? "";
            set => __pbn__type = value;
        }
        public bool ShouldSerializetype() => __pbn__type != null;
        public void Resettype() => __pbn__type = null;
        private string __pbn__type;

        [global::ProtoBuf.ProtoMember(2)]
        public int source_id
        {
            get => __pbn__source_id.GetValueOrDefault();
            set => __pbn__source_id = value;
        }
        public bool ShouldSerializesource_id() => __pbn__source_id != null;
        public void Resetsource_id() => __pbn__source_id = null;
        private int? __pbn__source_id;

        [global::ProtoBuf.ProtoMember(3)]
        public int cell_id
        {
            get => __pbn__cell_id.GetValueOrDefault();
            set => __pbn__cell_id = value;
        }
        public bool ShouldSerializecell_id() => __pbn__cell_id != null;
        public void Resetcell_id() => __pbn__cell_id = null;
        private int? __pbn__cell_id;

        [global::ProtoBuf.ProtoMember(4)]
        public int load
        {
            get => __pbn__load.GetValueOrDefault();
            set => __pbn__load = value;
        }
        public bool ShouldSerializeload() => __pbn__load != null;
        public void Resetload() => __pbn__load = null;
        private int? __pbn__load;

        [global::ProtoBuf.ProtoMember(5)]
        public float weighted_load
        {
            get => __pbn__weighted_load.GetValueOrDefault();
            set => __pbn__weighted_load = value;
        }
        public bool ShouldSerializeweighted_load() => __pbn__weighted_load != null;
        public void Resetweighted_load() => __pbn__weighted_load = null;
        private float? __pbn__weighted_load;

        [global::ProtoBuf.ProtoMember(6)]
        public int num_entries_in_client_list
        {
            get => __pbn__num_entries_in_client_list.GetValueOrDefault();
            set => __pbn__num_entries_in_client_list = value;
        }
        public bool ShouldSerializenum_entries_in_client_list() => __pbn__num_entries_in_client_list != null;
        public void Resetnum_entries_in_client_list() => __pbn__num_entries_in_client_list = null;
        private int? __pbn__num_entries_in_client_list;

        [global::ProtoBuf.ProtoMember(7)]
        public bool steam_china_only
        {
            get => __pbn__steam_china_only.GetValueOrDefault();
            set => __pbn__steam_china_only = value;
        }
        public bool ShouldSerializesteam_china_only() => __pbn__steam_china_only != null;
        public void Resetsteam_china_only() => __pbn__steam_china_only = null;
        private bool? __pbn__steam_china_only;

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue("")]
        public string host
        {
            get => __pbn__host ?? "";
            set => __pbn__host = value;
        }
        public bool ShouldSerializehost() => __pbn__host != null;
        public void Resethost() => __pbn__host = null;
        private string __pbn__host;

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue("")]
        public string vhost
        {
            get => __pbn__vhost ?? "";
            set => __pbn__vhost = value;
        }
        public bool ShouldSerializevhost() => __pbn__vhost != null;
        public void Resetvhost() => __pbn__vhost = null;
        private string __pbn__vhost;

        [global::ProtoBuf.ProtoMember(10)]
        public bool use_as_proxy
        {
            get => __pbn__use_as_proxy.GetValueOrDefault();
            set => __pbn__use_as_proxy = value;
        }
        public bool ShouldSerializeuse_as_proxy() => __pbn__use_as_proxy != null;
        public void Resetuse_as_proxy() => __pbn__use_as_proxy = null;
        private bool? __pbn__use_as_proxy;

        [global::ProtoBuf.ProtoMember(11)]
        [global::System.ComponentModel.DefaultValue("")]
        public string proxy_request_path_template
        {
            get => __pbn__proxy_request_path_template ?? "";
            set => __pbn__proxy_request_path_template = value;
        }
        public bool ShouldSerializeproxy_request_path_template() => __pbn__proxy_request_path_template != null;
        public void Resetproxy_request_path_template() => __pbn__proxy_request_path_template = null;
        private string __pbn__proxy_request_path_template;

        [global::ProtoBuf.ProtoMember(12)]
        [global::System.ComponentModel.DefaultValue("")]
        public string https_support
        {
            get => __pbn__https_support ?? "";
            set => __pbn__https_support = value;
        }
        public bool ShouldSerializehttps_support() => __pbn__https_support != null;
        public void Resethttps_support() => __pbn__https_support = null;
        private string __pbn__https_support;

        [global::ProtoBuf.ProtoMember(13)]
        public global::System.Collections.Generic.List<uint> allowed_app_ids { get; } = new global::System.Collections.Generic.List<uint>();

        [global::ProtoBuf.ProtoMember(15)]
        public uint priority_class
        {
            get => __pbn__priority_class.GetValueOrDefault();
            set => __pbn__priority_class = value;
        }
        public bool ShouldSerializepriority_class() => __pbn__priority_class != null;
        public void Resetpriority_class() => __pbn__priority_class = null;
        private uint? __pbn__priority_class;

        [global::ProtoBuf.ProtoMember(16)]
        public global::System.Collections.Generic.List<string> bypass_proxies_of_type { get; } = new global::System.Collections.Generic.List<string>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CContentServerDirectory_GetServersForSteamPipe_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<CContentServerDirectory_ServerInfo> servers { get; } = new global::System.Collections.Generic.List<CContentServerDirectory_ServerInfo>();

        [global::ProtoBuf.ProtoMember(2)]
        public bool no_change
        {
            get => __pbn__no_change.GetValueOrDefault();
            set => __pbn__no_change = value;
        }
        public bool ShouldSerializeno_change() => __pbn__no_change != null;
        public void Resetno_change() => __pbn__no_change = null;
        private bool? __pbn__no_change;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CContentServerDirectory_GetDepotPatchInfo_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get => __pbn__appid.GetValueOrDefault();
            set => __pbn__appid = value;
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        public uint depotid
        {
            get => __pbn__depotid.GetValueOrDefault();
            set => __pbn__depotid = value;
        }
        public bool ShouldSerializedepotid() => __pbn__depotid != null;
        public void Resetdepotid() => __pbn__depotid = null;
        private uint? __pbn__depotid;

        [global::ProtoBuf.ProtoMember(3)]
        public ulong source_manifestid
        {
            get => __pbn__source_manifestid.GetValueOrDefault();
            set => __pbn__source_manifestid = value;
        }
        public bool ShouldSerializesource_manifestid() => __pbn__source_manifestid != null;
        public void Resetsource_manifestid() => __pbn__source_manifestid = null;
        private ulong? __pbn__source_manifestid;

        [global::ProtoBuf.ProtoMember(4)]
        public ulong target_manifestid
        {
            get => __pbn__target_manifestid.GetValueOrDefault();
            set => __pbn__target_manifestid = value;
        }
        public bool ShouldSerializetarget_manifestid() => __pbn__target_manifestid != null;
        public void Resettarget_manifestid() => __pbn__target_manifestid = null;
        private ulong? __pbn__target_manifestid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CContentServerDirectory_GetDepotPatchInfo_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public bool is_available
        {
            get => __pbn__is_available.GetValueOrDefault();
            set => __pbn__is_available = value;
        }
        public bool ShouldSerializeis_available() => __pbn__is_available != null;
        public void Resetis_available() => __pbn__is_available = null;
        private bool? __pbn__is_available;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong patch_size
        {
            get => __pbn__patch_size.GetValueOrDefault();
            set => __pbn__patch_size = value;
        }
        public bool ShouldSerializepatch_size() => __pbn__patch_size != null;
        public void Resetpatch_size() => __pbn__patch_size = null;
        private ulong? __pbn__patch_size;

        [global::ProtoBuf.ProtoMember(3)]
        public ulong patched_chunks_size
        {
            get => __pbn__patched_chunks_size.GetValueOrDefault();
            set => __pbn__patched_chunks_size = value;
        }
        public bool ShouldSerializepatched_chunks_size() => __pbn__patched_chunks_size != null;
        public void Resetpatched_chunks_size() => __pbn__patched_chunks_size = null;
        private ulong? __pbn__patched_chunks_size;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CContentServerDirectory_GetClientUpdateHosts_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string cached_signature
        {
            get => __pbn__cached_signature ?? "";
            set => __pbn__cached_signature = value;
        }
        public bool ShouldSerializecached_signature() => __pbn__cached_signature != null;
        public void Resetcached_signature() => __pbn__cached_signature = null;
        private string __pbn__cached_signature;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CContentServerDirectory_GetClientUpdateHosts_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string hosts_kv
        {
            get => __pbn__hosts_kv ?? "";
            set => __pbn__hosts_kv = value;
        }
        public bool ShouldSerializehosts_kv() => __pbn__hosts_kv != null;
        public void Resethosts_kv() => __pbn__hosts_kv = null;
        private string __pbn__hosts_kv;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong valid_until_time
        {
            get => __pbn__valid_until_time.GetValueOrDefault();
            set => __pbn__valid_until_time = value;
        }
        public bool ShouldSerializevalid_until_time() => __pbn__valid_until_time != null;
        public void Resetvalid_until_time() => __pbn__valid_until_time = null;
        private ulong? __pbn__valid_until_time;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string ip_country
        {
            get => __pbn__ip_country ?? "";
            set => __pbn__ip_country = value;
        }
        public bool ShouldSerializeip_country() => __pbn__ip_country != null;
        public void Resetip_country() => __pbn__ip_country = null;
        private string __pbn__ip_country;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CContentServerDirectory_GetManifestRequestCode_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint app_id
        {
            get => __pbn__app_id.GetValueOrDefault();
            set => __pbn__app_id = value;
        }
        public bool ShouldSerializeapp_id() => __pbn__app_id != null;
        public void Resetapp_id() => __pbn__app_id = null;
        private uint? __pbn__app_id;

        [global::ProtoBuf.ProtoMember(2)]
        public uint depot_id
        {
            get => __pbn__depot_id.GetValueOrDefault();
            set => __pbn__depot_id = value;
        }
        public bool ShouldSerializedepot_id() => __pbn__depot_id != null;
        public void Resetdepot_id() => __pbn__depot_id = null;
        private uint? __pbn__depot_id;

        [global::ProtoBuf.ProtoMember(3)]
        public ulong manifest_id
        {
            get => __pbn__manifest_id.GetValueOrDefault();
            set => __pbn__manifest_id = value;
        }
        public bool ShouldSerializemanifest_id() => __pbn__manifest_id != null;
        public void Resetmanifest_id() => __pbn__manifest_id = null;
        private ulong? __pbn__manifest_id;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string app_branch
        {
            get => __pbn__app_branch ?? "";
            set => __pbn__app_branch = value;
        }
        public bool ShouldSerializeapp_branch() => __pbn__app_branch != null;
        public void Resetapp_branch() => __pbn__app_branch = null;
        private string __pbn__app_branch;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string branch_password_hash
        {
            get => __pbn__branch_password_hash ?? "";
            set => __pbn__branch_password_hash = value;
        }
        public bool ShouldSerializebranch_password_hash() => __pbn__branch_password_hash != null;
        public void Resetbranch_password_hash() => __pbn__branch_password_hash = null;
        private string __pbn__branch_password_hash;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CContentServerDirectory_GetManifestRequestCode_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong manifest_request_code
        {
            get => __pbn__manifest_request_code.GetValueOrDefault();
            set => __pbn__manifest_request_code = value;
        }
        public bool ShouldSerializemanifest_request_code() => __pbn__manifest_request_code != null;
        public void Resetmanifest_request_code() => __pbn__manifest_request_code = null;
        private ulong? __pbn__manifest_request_code;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CContentServerDirectory_GetCDNAuthToken_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint depot_id
        {
            get => __pbn__depot_id.GetValueOrDefault();
            set => __pbn__depot_id = value;
        }
        public bool ShouldSerializedepot_id() => __pbn__depot_id != null;
        public void Resetdepot_id() => __pbn__depot_id = null;
        private uint? __pbn__depot_id;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string host_name
        {
            get => __pbn__host_name ?? "";
            set => __pbn__host_name = value;
        }
        public bool ShouldSerializehost_name() => __pbn__host_name != null;
        public void Resethost_name() => __pbn__host_name = null;
        private string __pbn__host_name;

        [global::ProtoBuf.ProtoMember(3)]
        public uint app_id
        {
            get => __pbn__app_id.GetValueOrDefault();
            set => __pbn__app_id = value;
        }
        public bool ShouldSerializeapp_id() => __pbn__app_id != null;
        public void Resetapp_id() => __pbn__app_id = null;
        private uint? __pbn__app_id;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CContentServerDirectory_GetCDNAuthToken_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string token
        {
            get => __pbn__token ?? "";
            set => __pbn__token = value;
        }
        public bool ShouldSerializetoken() => __pbn__token != null;
        public void Resettoken() => __pbn__token = null;
        private string __pbn__token;

        [global::ProtoBuf.ProtoMember(2)]
        public uint expiration_time
        {
            get => __pbn__expiration_time.GetValueOrDefault();
            set => __pbn__expiration_time = value;
        }
        public bool ShouldSerializeexpiration_time() => __pbn__expiration_time != null;
        public void Resetexpiration_time() => __pbn__expiration_time = null;
        private uint? __pbn__expiration_time;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CContentServerDirectory_RequestPeerContentServer_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong remote_client_id
        {
            get => __pbn__remote_client_id.GetValueOrDefault();
            set => __pbn__remote_client_id = value;
        }
        public bool ShouldSerializeremote_client_id() => __pbn__remote_client_id != null;
        public void Resetremote_client_id() => __pbn__remote_client_id = null;
        private ulong? __pbn__remote_client_id;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong steamid
        {
            get => __pbn__steamid.GetValueOrDefault();
            set => __pbn__steamid = value;
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

        [global::ProtoBuf.ProtoMember(3)]
        public ulong server_remote_client_id
        {
            get => __pbn__server_remote_client_id.GetValueOrDefault();
            set => __pbn__server_remote_client_id = value;
        }
        public bool ShouldSerializeserver_remote_client_id() => __pbn__server_remote_client_id != null;
        public void Resetserver_remote_client_id() => __pbn__server_remote_client_id = null;
        private ulong? __pbn__server_remote_client_id;

        [global::ProtoBuf.ProtoMember(4)]
        public uint app_id
        {
            get => __pbn__app_id.GetValueOrDefault();
            set => __pbn__app_id = value;
        }
        public bool ShouldSerializeapp_id() => __pbn__app_id != null;
        public void Resetapp_id() => __pbn__app_id = null;
        private uint? __pbn__app_id;

        [global::ProtoBuf.ProtoMember(5)]
        public uint current_build_id
        {
            get => __pbn__current_build_id.GetValueOrDefault();
            set => __pbn__current_build_id = value;
        }
        public bool ShouldSerializecurrent_build_id() => __pbn__current_build_id != null;
        public void Resetcurrent_build_id() => __pbn__current_build_id = null;
        private uint? __pbn__current_build_id;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CContentServerDirectory_RequestPeerContentServer_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint server_port
        {
            get => __pbn__server_port.GetValueOrDefault();
            set => __pbn__server_port = value;
        }
        public bool ShouldSerializeserver_port() => __pbn__server_port != null;
        public void Resetserver_port() => __pbn__server_port = null;
        private uint? __pbn__server_port;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<uint> installed_depots { get; } = new global::System.Collections.Generic.List<uint>();

        [global::ProtoBuf.ProtoMember(3)]
        public ulong access_token
        {
            get => __pbn__access_token.GetValueOrDefault();
            set => __pbn__access_token = value;
        }
        public bool ShouldSerializeaccess_token() => __pbn__access_token != null;
        public void Resetaccess_token() => __pbn__access_token = null;
        private ulong? __pbn__access_token;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CContentServerDirectory_GetPeerContentInfo_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong remote_client_id
        {
            get => __pbn__remote_client_id.GetValueOrDefault();
            set => __pbn__remote_client_id = value;
        }
        public bool ShouldSerializeremote_client_id() => __pbn__remote_client_id != null;
        public void Resetremote_client_id() => __pbn__remote_client_id = null;
        private ulong? __pbn__remote_client_id;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong steamid
        {
            get => __pbn__steamid.GetValueOrDefault();
            set => __pbn__steamid = value;
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

        [global::ProtoBuf.ProtoMember(3)]
        public ulong server_remote_client_id
        {
            get => __pbn__server_remote_client_id.GetValueOrDefault();
            set => __pbn__server_remote_client_id = value;
        }
        public bool ShouldSerializeserver_remote_client_id() => __pbn__server_remote_client_id != null;
        public void Resetserver_remote_client_id() => __pbn__server_remote_client_id = null;
        private ulong? __pbn__server_remote_client_id;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CContentServerDirectory_GetPeerContentInfo_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<uint> appids { get; } = new global::System.Collections.Generic.List<uint>();

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string ip_public
        {
            get => __pbn__ip_public ?? "";
            set => __pbn__ip_public = value;
        }
        public bool ShouldSerializeip_public() => __pbn__ip_public != null;
        public void Resetip_public() => __pbn__ip_public = null;
        private string __pbn__ip_public;

    }

    public class ContentServerDirectory : SteamUnifiedMessages.UnifiedService
    {
        public override string ServiceName { get; } = "ContentServerDirectory";

        public AsyncJob<SteamUnifiedMessages.ServiceMsg<CContentServerDirectory_GetServersForSteamPipe_Response>> GetServersForSteamPipe(CContentServerDirectory_GetServersForSteamPipe_Request request)
        {
            return UnifiedMessages.SendMessage<CContentServerDirectory_GetServersForSteamPipe_Request, CContentServerDirectory_GetServersForSteamPipe_Response>( "ContentServerDirectory.GetServersForSteamPipe#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMsg<CContentServerDirectory_GetDepotPatchInfo_Response>> GetDepotPatchInfo(CContentServerDirectory_GetDepotPatchInfo_Request request)
        {
            return UnifiedMessages.SendMessage<CContentServerDirectory_GetDepotPatchInfo_Request, CContentServerDirectory_GetDepotPatchInfo_Response>( "ContentServerDirectory.GetDepotPatchInfo#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMsg<CContentServerDirectory_GetClientUpdateHosts_Response>> GetClientUpdateHosts(CContentServerDirectory_GetClientUpdateHosts_Request request)
        {
            return UnifiedMessages.SendMessage<CContentServerDirectory_GetClientUpdateHosts_Request, CContentServerDirectory_GetClientUpdateHosts_Response>( "ContentServerDirectory.GetClientUpdateHosts#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMsg<CContentServerDirectory_GetManifestRequestCode_Response>> GetManifestRequestCode(CContentServerDirectory_GetManifestRequestCode_Request request)
        {
            return UnifiedMessages.SendMessage<CContentServerDirectory_GetManifestRequestCode_Request, CContentServerDirectory_GetManifestRequestCode_Response>( "ContentServerDirectory.GetManifestRequestCode#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMsg<CContentServerDirectory_GetCDNAuthToken_Response>> GetCDNAuthToken(CContentServerDirectory_GetCDNAuthToken_Request request)
        {
            return UnifiedMessages.SendMessage<CContentServerDirectory_GetCDNAuthToken_Request, CContentServerDirectory_GetCDNAuthToken_Response>( "ContentServerDirectory.GetCDNAuthToken#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMsg<CContentServerDirectory_RequestPeerContentServer_Response>> RequestPeerContentServer(CContentServerDirectory_RequestPeerContentServer_Request request)
        {
            return UnifiedMessages.SendMessage<CContentServerDirectory_RequestPeerContentServer_Request, CContentServerDirectory_RequestPeerContentServer_Response>( "ContentServerDirectory.RequestPeerContentServer#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMsg<CContentServerDirectory_GetPeerContentInfo_Response>> GetPeerContentInfo(CContentServerDirectory_GetPeerContentInfo_Request request)
        {
            return UnifiedMessages.SendMessage<CContentServerDirectory_GetPeerContentInfo_Request, CContentServerDirectory_GetPeerContentInfo_Response>( "ContentServerDirectory.GetPeerContentInfo#1", request );
        }

        public override void HandleMsg( string methodName, IPacketMsg packetMsg )
        {
            switch ( methodName )
            {
                case "GetServersForSteamPipe":
                    UnifiedMessages.HandleServiceMsg<CContentServerDirectory_GetServersForSteamPipe_Response>( packetMsg );
                    break;
                case "GetDepotPatchInfo":
                    UnifiedMessages.HandleServiceMsg<CContentServerDirectory_GetDepotPatchInfo_Response>( packetMsg );
                    break;
                case "GetClientUpdateHosts":
                    UnifiedMessages.HandleServiceMsg<CContentServerDirectory_GetClientUpdateHosts_Response>( packetMsg );
                    break;
                case "GetManifestRequestCode":
                    UnifiedMessages.HandleServiceMsg<CContentServerDirectory_GetManifestRequestCode_Response>( packetMsg );
                    break;
                case "GetCDNAuthToken":
                    UnifiedMessages.HandleServiceMsg<CContentServerDirectory_GetCDNAuthToken_Response>( packetMsg );
                    break;
                case "RequestPeerContentServer":
                    UnifiedMessages.HandleServiceMsg<CContentServerDirectory_RequestPeerContentServer_Response>( packetMsg );
                    break;
                case "GetPeerContentInfo":
                    UnifiedMessages.HandleServiceMsg<CContentServerDirectory_GetPeerContentInfo_Response>( packetMsg );
                    break;
            }
        }
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
