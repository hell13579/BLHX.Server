// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: p17_pb.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace BLHX.Server.Common.Proto.p17
{

    [global::ProtoBuf.ProtoContract(Name = @"achievement_info")]
    public partial class AchievementInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"progress", IsRequired = true)]
        public uint Progress { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"timestamp", IsRequired = true)]
        public uint Timestamp { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"attire_info")]
    public partial class AttireInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"end_time", IsRequired = true)]
        public uint EndTime { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_17005")]
    public partial class Cs17005 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"award_index", IsRequired = true)]
        public uint AwardIndex { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_17101")]
    public partial class Cs17101 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"ship_group_id", IsRequired = true)]
        public uint ShipGroupId { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_17103")]
    public partial class Cs17103 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"ship_group_id", IsRequired = true)]
        public uint ShipGroupId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"context", IsRequired = true)]
        public string Context { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_17105")]
    public partial class Cs17105 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"ship_group_id", IsRequired = true)]
        public uint ShipGroupId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"discuss_id", IsRequired = true)]
        public uint DiscussId { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"good_or_bad", IsRequired = true)]
        public uint GoodOrBad { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_17107")]
    public partial class Cs17107 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"ship_group_id", IsRequired = true)]
        public uint ShipGroupId { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_17109")]
    public partial class Cs17109 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"ship_group_id", IsRequired = true)]
        public uint ShipGroupId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"discuss_id", IsRequired = true)]
        public uint DiscussId { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"reason", IsRequired = true)]
        public string Reason { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_17201")]
    public partial class Cs17201 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"type", IsRequired = true)]
        public uint Type { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_17203")]
    public partial class Cs17203 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"type", IsRequired = true)]
        public uint Type { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_17301")]
    public partial class Cs17301 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_17401")]
    public partial class Cs17401 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"medal_id")]
        public global::System.Collections.Generic.List<uint> MedalIds { get; set; } = new global::System.Collections.Generic.List<uint>();

        [global::ProtoBuf.ProtoMember(2, Name = @"fixed_const", IsRequired = true)]
        public uint FixedConst { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_17501")]
    public partial class Cs17501 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_17503")]
    public partial class Cs17503 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_17505")]
    public partial class Cs17505 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"action", IsRequired = true)]
        public uint Action { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_17507")]
    public partial class Cs17507 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"action", IsRequired = true)]
        public uint Action { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_17509")]
    public partial class Cs17509 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_17511")]
    public partial class Cs17511 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"action", IsRequired = true)]
        public uint Action { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_17601")]
    public partial class Cs17601 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"shipgroup", IsRequired = true)]
        public uint Shipgroup { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_17603")]
    public partial class Cs17603 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"shipgroup", IsRequired = true)]
        public uint Shipgroup { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"eqcode", IsRequired = true)]
        public string Eqcode { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_17605")]
    public partial class Cs17605 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"shipgroup", IsRequired = true)]
        public uint Shipgroup { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"shareid", IsRequired = true)]
        public uint Shareid { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_17607")]
    public partial class Cs17607 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"shipgroup", IsRequired = true)]
        public uint Shipgroup { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"shareid", IsRequired = true)]
        public uint Shareid { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"report_type", IsRequired = true)]
        public uint ReportType { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"discuss_info")]
    public partial class DiscussInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"good_count", IsRequired = true)]
        public uint GoodCount { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"nick_name", IsRequired = true)]
        public string NickName { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"context", IsRequired = true)]
        public string Context { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"bad_count", IsRequired = true)]
        public uint BadCount { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"eqcode_share_info")]
    public partial class EqcodeShareInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"eqcode", IsRequired = true)]
        public string Eqcode { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"like", IsRequired = true)]
        public uint Like { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"eval_point", IsRequired = true)]
        public uint EvalPoint { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"state", IsRequired = true)]
        public uint State { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"mulkeyvalue")]
    public partial class Mulkeyvalue : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"key", IsRequired = true)]
        public uint Key { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"value1", IsRequired = true)]
        public uint Value1 { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"value2")]
        public uint Value2
        {
            get => __pbn__Value2.GetValueOrDefault();
            set => __pbn__Value2 = value;
        }
        public bool ShouldSerializeValue2() => __pbn__Value2 != null;
        public void ResetValue2() => __pbn__Value2 = null;
        private uint? __pbn__Value2;

        [global::ProtoBuf.ProtoMember(4, Name = @"value3")]
        public uint Value3
        {
            get => __pbn__Value3.GetValueOrDefault();
            set => __pbn__Value3 = value;
        }
        public bool ShouldSerializeValue3() => __pbn__Value3 != null;
        public void ResetValue3() => __pbn__Value3 = null;
        private uint? __pbn__Value3;

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_17001")]
    public partial class Sc17001 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"finish_list")]
        public global::System.Collections.Generic.List<uint> FinishLists { get; set; } = new global::System.Collections.Generic.List<uint>();

        [global::ProtoBuf.ProtoMember(2, Name = @"progress_list")]
        public global::System.Collections.Generic.List<AchievementInfo> ProgressLists { get; set; } = new global::System.Collections.Generic.List<AchievementInfo>();

        [global::ProtoBuf.ProtoMember(3, Name = @"ship_info_list")]
        public global::System.Collections.Generic.List<ShipStatisticsInfo> ShipInfoLists { get; set; } = new global::System.Collections.Generic.List<ShipStatisticsInfo>();

        [global::ProtoBuf.ProtoMember(4, Name = @"ship_award_list")]
        public global::System.Collections.Generic.List<ShipStatisticsAward> ShipAwardLists { get; set; } = new global::System.Collections.Generic.List<ShipStatisticsAward>();

        [global::ProtoBuf.ProtoMember(5, Name = @"daily_discuss", IsRequired = true)]
        public uint DailyDiscuss { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"transform_list")]
        public global::System.Collections.Generic.List<uint> TransformLists { get; set; } = new global::System.Collections.Generic.List<uint>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_17002")]
    public partial class Sc17002 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"progress_list")]
        public global::System.Collections.Generic.List<AchievementInfo> ProgressLists { get; set; } = new global::System.Collections.Generic.List<AchievementInfo>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_17003")]
    public partial class Sc17003 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id_list")]
        public global::System.Collections.Generic.List<uint> IdLists { get; set; } = new global::System.Collections.Generic.List<uint>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_17004")]
    public partial class Sc17004 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"ship_info", IsRequired = true)]
        public ShipStatisticsInfo ShipInfo { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_17006")]
    public partial class Sc17006 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result", IsRequired = true)]
        public uint Result { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_17102")]
    public partial class Sc17102 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"ship_discuss", IsRequired = true)]
        public ShipDiscussInfo ShipDiscuss { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_17104")]
    public partial class Sc17104 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result", IsRequired = true)]
        public uint Result { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"ship_discuss")]
        public ShipDiscussInfo ShipDiscuss { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_17106")]
    public partial class Sc17106 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result", IsRequired = true)]
        public uint Result { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_17108")]
    public partial class Sc17108 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result", IsRequired = true)]
        public uint Result { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_17110")]
    public partial class Sc17110 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result", IsRequired = true)]
        public uint Result { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_17202")]
    public partial class Sc17202 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"daily_vote", IsRequired = true)]
        public uint DailyVote { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"love_vote", IsRequired = true)]
        public uint LoveVote { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"daily_ship_list")]
        public global::System.Collections.Generic.List<uint> DailyShipLists { get; set; } = new global::System.Collections.Generic.List<uint>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_17204")]
    public partial class Sc17204 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"list")]
        public global::System.Collections.Generic.List<Mulkeyvalue> Lists { get; set; } = new global::System.Collections.Generic.List<Mulkeyvalue>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_17302")]
    public partial class Sc17302 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result", IsRequired = true)]
        public uint Result { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"timestamp")]
        public uint Timestamp
        {
            get => __pbn__Timestamp.GetValueOrDefault();
            set => __pbn__Timestamp = value;
        }
        public bool ShouldSerializeTimestamp() => __pbn__Timestamp != null;
        public void ResetTimestamp() => __pbn__Timestamp = null;
        private uint? __pbn__Timestamp;

        [global::ProtoBuf.ProtoMember(3, Name = @"next")]
        public global::System.Collections.Generic.List<AchievementInfo> Nexts { get; set; } = new global::System.Collections.Generic.List<AchievementInfo>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_17402")]
    public partial class Sc17402 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result", IsRequired = true)]
        public uint Result { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_17502")]
    public partial class Sc17502 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result", IsRequired = true)]
        public uint Result { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_17504")]
    public partial class Sc17504 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result", IsRequired = true)]
        public uint Result { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_17506")]
    public partial class Sc17506 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result", IsRequired = true)]
        public uint Result { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_17508")]
    public partial class Sc17508 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result", IsRequired = true)]
        public uint Result { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_17510")]
    public partial class Sc17510 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result", IsRequired = true)]
        public uint Result { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_17512")]
    public partial class Sc17512 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result", IsRequired = true)]
        public uint Result { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_17602")]
    public partial class Sc17602 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result", IsRequired = true)]
        public uint Result { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"infos")]
        public global::System.Collections.Generic.List<EqcodeShareInfo> Infos { get; set; } = new global::System.Collections.Generic.List<EqcodeShareInfo>();

        [global::ProtoBuf.ProtoMember(3, Name = @"recent_infos")]
        public global::System.Collections.Generic.List<EqcodeShareInfo> RecentInfos { get; set; } = new global::System.Collections.Generic.List<EqcodeShareInfo>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_17604")]
    public partial class Sc17604 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result", IsRequired = true)]
        public uint Result { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_17606")]
    public partial class Sc17606 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result", IsRequired = true)]
        public uint Result { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_17608")]
    public partial class Sc17608 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result", IsRequired = true)]
        public uint Result { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"ship_discuss_info")]
    public partial class ShipDiscussInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"ship_group_id", IsRequired = true)]
        public uint ShipGroupId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"discuss_count", IsRequired = true)]
        public uint DiscussCount { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"heart_count", IsRequired = true)]
        public uint HeartCount { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"discuss_list")]
        public global::System.Collections.Generic.List<DiscussInfo> DiscussLists { get; set; } = new global::System.Collections.Generic.List<DiscussInfo>();

        [global::ProtoBuf.ProtoMember(5, Name = @"daily_discuss_count", IsRequired = true)]
        public uint DailyDiscussCount { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"ship_statistics_award")]
    public partial class ShipStatisticsAward : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"award_index")]
        public global::System.Collections.Generic.List<uint> AwardIndexs { get; set; } = new global::System.Collections.Generic.List<uint>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"ship_statistics_info")]
    public partial class ShipStatisticsInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"star", IsRequired = true)]
        public uint Star { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"heart_flag", IsRequired = true)]
        public uint HeartFlag { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"heart_count", IsRequired = true)]
        public uint HeartCount { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"marry_flag", IsRequired = true)]
        public uint MarryFlag { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"intimacy_max", IsRequired = true)]
        public uint IntimacyMax { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"lv_max", IsRequired = true)]
        public uint LvMax { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"voteinfo")]
    public partial class Voteinfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"count", IsRequired = true)]
        public uint Count { get; set; }

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
