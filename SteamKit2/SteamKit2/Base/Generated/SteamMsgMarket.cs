// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: steammessages_market.steamclient.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CEconMarket_IsMarketplaceAllowed_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string webcookie
        {
            get => __pbn__webcookie ?? "";
            set => __pbn__webcookie = value;
        }
        public bool ShouldSerializewebcookie() => __pbn__webcookie != null;
        public void Resetwebcookie() => __pbn__webcookie = null;
        private string __pbn__webcookie;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CEconMarket_IsMarketplaceAllowed_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public bool allowed
        {
            get => __pbn__allowed.GetValueOrDefault();
            set => __pbn__allowed = value;
        }
        public bool ShouldSerializeallowed() => __pbn__allowed != null;
        public void Resetallowed() => __pbn__allowed = null;
        private bool? __pbn__allowed;

        [global::ProtoBuf.ProtoMember(2)]
        public uint reason
        {
            get => __pbn__reason.GetValueOrDefault();
            set => __pbn__reason = value;
        }
        public bool ShouldSerializereason() => __pbn__reason != null;
        public void Resetreason() => __pbn__reason = null;
        private uint? __pbn__reason;

        [global::ProtoBuf.ProtoMember(3)]
        public uint allowed_at_time
        {
            get => __pbn__allowed_at_time.GetValueOrDefault();
            set => __pbn__allowed_at_time = value;
        }
        public bool ShouldSerializeallowed_at_time() => __pbn__allowed_at_time != null;
        public void Resetallowed_at_time() => __pbn__allowed_at_time = null;
        private uint? __pbn__allowed_at_time;

        [global::ProtoBuf.ProtoMember(4)]
        public uint steamguard_required_days
        {
            get => __pbn__steamguard_required_days.GetValueOrDefault();
            set => __pbn__steamguard_required_days = value;
        }
        public bool ShouldSerializesteamguard_required_days() => __pbn__steamguard_required_days != null;
        public void Resetsteamguard_required_days() => __pbn__steamguard_required_days = null;
        private uint? __pbn__steamguard_required_days;

        [global::ProtoBuf.ProtoMember(7)]
        public bool forms_requested
        {
            get => __pbn__forms_requested.GetValueOrDefault();
            set => __pbn__forms_requested = value;
        }
        public bool ShouldSerializeforms_requested() => __pbn__forms_requested != null;
        public void Resetforms_requested() => __pbn__forms_requested = null;
        private bool? __pbn__forms_requested;

        [global::ProtoBuf.ProtoMember(8)]
        public bool forms_require_verification
        {
            get => __pbn__forms_require_verification.GetValueOrDefault();
            set => __pbn__forms_require_verification = value;
        }
        public bool ShouldSerializeforms_require_verification() => __pbn__forms_require_verification != null;
        public void Resetforms_require_verification() => __pbn__forms_require_verification = null;
        private bool? __pbn__forms_require_verification;

        [global::ProtoBuf.ProtoMember(9)]
        public uint new_device_cooldown_days
        {
            get => __pbn__new_device_cooldown_days.GetValueOrDefault();
            set => __pbn__new_device_cooldown_days = value;
        }
        public bool ShouldSerializenew_device_cooldown_days() => __pbn__new_device_cooldown_days != null;
        public void Resetnew_device_cooldown_days() => __pbn__new_device_cooldown_days = null;
        private uint? __pbn__new_device_cooldown_days;

    }

    public class EconMarket : SteamUnifiedMessages.UnifiedService
    {
        public override string ServiceName { get; } = "EconMarket";

        public AsyncJob<SteamUnifiedMessages.ServiceMsg<CEconMarket_IsMarketplaceAllowed_Response>> IsMarketplaceAllowed(CEconMarket_IsMarketplaceAllowed_Request request)
        {
            return UnifiedMessages.SendMessage<CEconMarket_IsMarketplaceAllowed_Request, CEconMarket_IsMarketplaceAllowed_Response>( "EconMarket.IsMarketplaceAllowed#1", request );
        }

        public override void HandleMsg( string methodName, IPacketMsg packetMsg )
        {
            switch ( methodName )
            {
                case "IsMarketplaceAllowed":
                    UnifiedMessages.HandleServiceMsg<CEconMarket_IsMarketplaceAllowed_Response>( packetMsg );
                    break;
            }
        }
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
