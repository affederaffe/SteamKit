// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: steammessages_video.steamclient.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CVideo_ClientGetVideoURL_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong video_id
        {
            get => __pbn__video_id.GetValueOrDefault();
            set => __pbn__video_id = value;
        }
        public bool ShouldSerializevideo_id() => __pbn__video_id != null;
        public void Resetvideo_id() => __pbn__video_id = null;
        private ulong? __pbn__video_id;

        [global::ProtoBuf.ProtoMember(2)]
        public uint client_cellid
        {
            get => __pbn__client_cellid.GetValueOrDefault();
            set => __pbn__client_cellid = value;
        }
        public bool ShouldSerializeclient_cellid() => __pbn__client_cellid != null;
        public void Resetclient_cellid() => __pbn__client_cellid = null;
        private uint? __pbn__client_cellid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CVideo_ClientGetVideoURL_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong video_id
        {
            get => __pbn__video_id.GetValueOrDefault();
            set => __pbn__video_id = value;
        }
        public bool ShouldSerializevideo_id() => __pbn__video_id != null;
        public void Resetvideo_id() => __pbn__video_id = null;
        private ulong? __pbn__video_id;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string video_url
        {
            get => __pbn__video_url ?? "";
            set => __pbn__video_url = value;
        }
        public bool ShouldSerializevideo_url() => __pbn__video_url != null;
        public void Resetvideo_url() => __pbn__video_url = null;
        private string __pbn__video_url;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class VideoBookmark : global::ProtoBuf.IExtensible
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
        public uint playback_position_in_seconds
        {
            get => __pbn__playback_position_in_seconds.GetValueOrDefault();
            set => __pbn__playback_position_in_seconds = value;
        }
        public bool ShouldSerializeplayback_position_in_seconds() => __pbn__playback_position_in_seconds != null;
        public void Resetplayback_position_in_seconds() => __pbn__playback_position_in_seconds = null;
        private uint? __pbn__playback_position_in_seconds;

        [global::ProtoBuf.ProtoMember(3)]
        public ulong video_track_id
        {
            get => __pbn__video_track_id.GetValueOrDefault();
            set => __pbn__video_track_id = value;
        }
        public bool ShouldSerializevideo_track_id() => __pbn__video_track_id != null;
        public void Resetvideo_track_id() => __pbn__video_track_id = null;
        private ulong? __pbn__video_track_id;

        [global::ProtoBuf.ProtoMember(4)]
        public ulong audio_track_id
        {
            get => __pbn__audio_track_id.GetValueOrDefault();
            set => __pbn__audio_track_id = value;
        }
        public bool ShouldSerializeaudio_track_id() => __pbn__audio_track_id != null;
        public void Resetaudio_track_id() => __pbn__audio_track_id = null;
        private ulong? __pbn__audio_track_id;

        [global::ProtoBuf.ProtoMember(5)]
        public ulong timedtext_track_id
        {
            get => __pbn__timedtext_track_id.GetValueOrDefault();
            set => __pbn__timedtext_track_id = value;
        }
        public bool ShouldSerializetimedtext_track_id() => __pbn__timedtext_track_id != null;
        public void Resettimedtext_track_id() => __pbn__timedtext_track_id = null;
        private ulong? __pbn__timedtext_track_id;

        [global::ProtoBuf.ProtoMember(6)]
        public uint last_modified
        {
            get => __pbn__last_modified.GetValueOrDefault();
            set => __pbn__last_modified = value;
        }
        public bool ShouldSerializelast_modified() => __pbn__last_modified != null;
        public void Resetlast_modified() => __pbn__last_modified = null;
        private uint? __pbn__last_modified;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool hide_from_watch_history
        {
            get => __pbn__hide_from_watch_history ?? false;
            set => __pbn__hide_from_watch_history = value;
        }
        public bool ShouldSerializehide_from_watch_history() => __pbn__hide_from_watch_history != null;
        public void Resethide_from_watch_history() => __pbn__hide_from_watch_history = null;
        private bool? __pbn__hide_from_watch_history;

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool hide_from_library
        {
            get => __pbn__hide_from_library ?? false;
            set => __pbn__hide_from_library = value;
        }
        public bool ShouldSerializehide_from_library() => __pbn__hide_from_library != null;
        public void Resethide_from_library() => __pbn__hide_from_library = null;
        private bool? __pbn__hide_from_library;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CVideo_SetVideoBookmark_Notification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<VideoBookmark> bookmarks { get; } = new global::System.Collections.Generic.List<VideoBookmark>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CVideo_GetVideoBookmarks_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<uint> appids { get; } = new global::System.Collections.Generic.List<uint>();

        [global::ProtoBuf.ProtoMember(2)]
        public uint updated_since
        {
            get => __pbn__updated_since.GetValueOrDefault();
            set => __pbn__updated_since = value;
        }
        public bool ShouldSerializeupdated_since() => __pbn__updated_since != null;
        public void Resetupdated_since() => __pbn__updated_since = null;
        private uint? __pbn__updated_since;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CVideo_GetVideoBookmarks_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<VideoBookmark> bookmarks { get; } = new global::System.Collections.Generic.List<VideoBookmark>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CVideo_UnlockedH264_Notification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public byte[] encryption_key
        {
            get => __pbn__encryption_key;
            set => __pbn__encryption_key = value;
        }
        public bool ShouldSerializeencryption_key() => __pbn__encryption_key != null;
        public void Resetencryption_key() => __pbn__encryption_key = null;
        private byte[] __pbn__encryption_key;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CFovasVideo_ClientGetOPFSettings_Request : global::ProtoBuf.IExtensible
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
        public uint client_cellid
        {
            get => __pbn__client_cellid.GetValueOrDefault();
            set => __pbn__client_cellid = value;
        }
        public bool ShouldSerializeclient_cellid() => __pbn__client_cellid != null;
        public void Resetclient_cellid() => __pbn__client_cellid = null;
        private uint? __pbn__client_cellid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CFovasVideo_ClientGetOPFSettings_Response : global::ProtoBuf.IExtensible
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
        [global::System.ComponentModel.DefaultValue("")]
        public string opf_settings
        {
            get => __pbn__opf_settings ?? "";
            set => __pbn__opf_settings = value;
        }
        public bool ShouldSerializeopf_settings() => __pbn__opf_settings != null;
        public void Resetopf_settings() => __pbn__opf_settings = null;
        private string __pbn__opf_settings;

    }

    public class Video : SteamUnifiedMessages.IUnifiedService
    {
        public static string ServiceName { get; } = "Video";

        /// <inheritdoc />
        public SteamUnifiedMessages UnifiedMessages { get; init; }

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CVideo_ClientGetVideoURL_Response>> ClientGetVideoURL(CVideo_ClientGetVideoURL_Request request)
        {
            return UnifiedMessages.SendMessage<CVideo_ClientGetVideoURL_Request, CVideo_ClientGetVideoURL_Response>( "Video.ClientGetVideoURL#1", request );
        }

        public void SetVideoBookmark(CVideo_SetVideoBookmark_Notification request)
        {
            UnifiedMessages.SendNotification<CVideo_SetVideoBookmark_Notification>( "Video.SetVideoBookmark#1", request );
        }

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CVideo_GetVideoBookmarks_Response>> GetVideoBookmarks(CVideo_GetVideoBookmarks_Request request)
        {
            return UnifiedMessages.SendMessage<CVideo_GetVideoBookmarks_Request, CVideo_GetVideoBookmarks_Response>( "Video.GetVideoBookmarks#1", request );
        }

        public void HandleResponseMsg( string methodName, PacketClientMsgProtobuf packetMsg )
        {
            switch ( methodName )
            {
                case "ClientGetVideoURL":
                    UnifiedMessages.HandleResponseMsg<CVideo_ClientGetVideoURL_Response>( packetMsg );
                    break;
                case "GetVideoBookmarks":
                    UnifiedMessages.HandleResponseMsg<CVideo_GetVideoBookmarks_Response>( packetMsg );
                    break;
            }
        }

        public void HandleNotificationMsg( string methodName, PacketClientMsgProtobuf packetMsg )
        {
            switch ( methodName )
            {
                case "SetVideoBookmark":
                    UnifiedMessages.HandleNotificationMsg<CVideo_SetVideoBookmark_Notification>( packetMsg );
                    break;
            }
        }
    }

    public class VideoClient : SteamUnifiedMessages.IUnifiedService
    {
        public static string ServiceName { get; } = "VideoClient";

        /// <inheritdoc />
        public SteamUnifiedMessages UnifiedMessages { get; init; }

        public void NotifyUnlockedH264(CVideo_UnlockedH264_Notification request)
        {
            UnifiedMessages.SendNotification<CVideo_UnlockedH264_Notification>( "VideoClient.NotifyUnlockedH264#1", request );
        }

        public void HandleResponseMsg( string methodName, PacketClientMsgProtobuf packetMsg )
        {
        }

        public void HandleNotificationMsg( string methodName, PacketClientMsgProtobuf packetMsg )
        {
            switch ( methodName )
            {
                case "NotifyUnlockedH264":
                    UnifiedMessages.HandleNotificationMsg<CVideo_UnlockedH264_Notification>( packetMsg );
                    break;
            }
        }
    }

    public class FovasVideo : SteamUnifiedMessages.IUnifiedService
    {
        public static string ServiceName { get; } = "FovasVideo";

        /// <inheritdoc />
        public SteamUnifiedMessages UnifiedMessages { get; init; }

        public AsyncJob<SteamUnifiedMessages.ServiceMethodResponse<CFovasVideo_ClientGetOPFSettings_Response>> ClientGetOPFSettings(CFovasVideo_ClientGetOPFSettings_Request request)
        {
            return UnifiedMessages.SendMessage<CFovasVideo_ClientGetOPFSettings_Request, CFovasVideo_ClientGetOPFSettings_Response>( "FovasVideo.ClientGetOPFSettings#1", request );
        }

        public void HandleResponseMsg( string methodName, PacketClientMsgProtobuf packetMsg )
        {
            switch ( methodName )
            {
                case "ClientGetOPFSettings":
                    UnifiedMessages.HandleResponseMsg<CFovasVideo_ClientGetOPFSettings_Response>( packetMsg );
                    break;
            }
        }

        public void HandleNotificationMsg( string methodName, PacketClientMsgProtobuf packetMsg )
        {
        }
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
