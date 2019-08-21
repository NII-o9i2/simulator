// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: path_bounds_decider_config.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.planning
{

    [global::ProtoBuf.ProtoContract()]
    public partial class PathBoundsDeciderConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public PathBoundsDeciderConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public bool is_lane_borrowing
        {
            get { return __pbn__is_lane_borrowing.GetValueOrDefault(); }
            set { __pbn__is_lane_borrowing = value; }
        }
        public bool ShouldSerializeis_lane_borrowing()
        {
            return __pbn__is_lane_borrowing != null;
        }
        public void Resetis_lane_borrowing()
        {
            __pbn__is_lane_borrowing = null;
        }
        private bool? __pbn__is_lane_borrowing;

        [global::ProtoBuf.ProtoMember(2)]
        public bool is_pull_over
        {
            get { return __pbn__is_pull_over.GetValueOrDefault(); }
            set { __pbn__is_pull_over = value; }
        }
        public bool ShouldSerializeis_pull_over()
        {
            return __pbn__is_pull_over != null;
        }
        public void Resetis_pull_over()
        {
            __pbn__is_pull_over = null;
        }
        private bool? __pbn__is_pull_over;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(25)]
        public double pull_over_destination_to_adc_buffer
        {
            get { return __pbn__pull_over_destination_to_adc_buffer ?? 25; }
            set { __pbn__pull_over_destination_to_adc_buffer = value; }
        }
        public bool ShouldSerializepull_over_destination_to_adc_buffer()
        {
            return __pbn__pull_over_destination_to_adc_buffer != null;
        }
        public void Resetpull_over_destination_to_adc_buffer()
        {
            __pbn__pull_over_destination_to_adc_buffer = null;
        }
        private double? __pbn__pull_over_destination_to_adc_buffer;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(10)]
        public double pull_over_destination_to_pathend_buffer
        {
            get { return __pbn__pull_over_destination_to_pathend_buffer ?? 10; }
            set { __pbn__pull_over_destination_to_pathend_buffer = value; }
        }
        public bool ShouldSerializepull_over_destination_to_pathend_buffer()
        {
            return __pbn__pull_over_destination_to_pathend_buffer != null;
        }
        public void Resetpull_over_destination_to_pathend_buffer()
        {
            __pbn__pull_over_destination_to_pathend_buffer = null;
        }
        private double? __pbn__pull_over_destination_to_pathend_buffer;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(0.15)]
        public double pull_over_road_edge_buffer
        {
            get { return __pbn__pull_over_road_edge_buffer ?? 0.15; }
            set { __pbn__pull_over_road_edge_buffer = value; }
        }
        public bool ShouldSerializepull_over_road_edge_buffer()
        {
            return __pbn__pull_over_road_edge_buffer != null;
        }
        public void Resetpull_over_road_edge_buffer()
        {
            __pbn__pull_over_road_edge_buffer = null;
        }
        private double? __pbn__pull_over_road_edge_buffer;

    }

}

#pragma warning restore 0612, 1591, 3021