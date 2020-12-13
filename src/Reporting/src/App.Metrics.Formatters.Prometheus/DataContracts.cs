//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: prometheus.proto
namespace App.Metrics.Formatters.Prometheus
{
    [global::ProtoBuf.ProtoContract(Name = @"LabelPair")]
    public partial class LabelPair : global::ProtoBuf.IExtensible
    {
        public LabelPair() { }

        private string _name = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _value = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"value", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string value
        {
            get { return _value; }
            set { _value = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::ProtoBuf.ProtoContract(Name = @"Gauge")]
    public partial class Gauge : global::ProtoBuf.IExtensible
    {
        public Gauge() { }

        private double _value = default(double);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(double))]
        public double value
        {
            get { return _value; }
            set { _value = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::ProtoBuf.ProtoContract(Name = @"Counter")]
    public partial class Counter : global::ProtoBuf.IExtensible
    {
        public Counter() { }

        private double _value = default(double);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(double))]
        public double value
        {
            get { return _value; }
            set { _value = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::ProtoBuf.ProtoContract(Name = @"Quantile")]
    public partial class Quantile : global::ProtoBuf.IExtensible
    {
        public Quantile() { }

        private double _quantile = default(double);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"quantile", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(double))]
        public double quantile
        {
            get { return _quantile; }
            set { _quantile = value; }
        }
        private double _value = default(double);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(double))]
        public double value
        {
            get { return _value; }
            set { _value = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::ProtoBuf.ProtoContract(Name = @"Summary")]
    public partial class Summary : global::ProtoBuf.IExtensible
    {
        public Summary() { }

        private ulong _sample_count = default(ulong);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"sample_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(ulong))]
        public ulong sample_count
        {
            get { return _sample_count; }
            set { _sample_count = value; }
        }
        private double _sample_sum = default(double);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"sample_sum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(double))]
        public double sample_sum
        {
            get { return _sample_sum; }
            set { _sample_sum = value; }
        }
        private readonly global::System.Collections.Generic.List<Quantile> _quantile = new global::System.Collections.Generic.List<Quantile>();
        [global::ProtoBuf.ProtoMember(3, Name = @"quantile", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Quantile> quantile
        {
            get { return _quantile; }
        }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::ProtoBuf.ProtoContract(Name = @"Untyped")]
    public partial class Untyped : global::ProtoBuf.IExtensible
    {
        public Untyped() { }

        private double _value = default(double);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(double))]
        public double value
        {
            get { return _value; }
            set { _value = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::ProtoBuf.ProtoContract(Name = @"Histogram")]
    public partial class Histogram : global::ProtoBuf.IExtensible
    {
        public Histogram() { }

        private ulong _sample_count = default(ulong);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"sample_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(ulong))]
        public ulong sample_count
        {
            get { return _sample_count; }
            set { _sample_count = value; }
        }
        private double _sample_sum = default(double);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"sample_sum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(double))]
        public double sample_sum
        {
            get { return _sample_sum; }
            set { _sample_sum = value; }
        }
        private readonly global::System.Collections.Generic.List<Bucket> _bucket = new global::System.Collections.Generic.List<Bucket>();
        [global::ProtoBuf.ProtoMember(3, Name = @"bucket", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Bucket> bucket
        {
            get { return _bucket; }
        }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::ProtoBuf.ProtoContract(Name = @"Bucket")]
    public partial class Bucket : global::ProtoBuf.IExtensible
    {
        public Bucket() { }

        private ulong _cumulative_count = default(ulong);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"cumulative_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(ulong))]
        public ulong cumulative_count
        {
            get { return _cumulative_count; }
            set { _cumulative_count = value; }
        }
        private double _upper_bound = default(double);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"upper_bound", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(double))]
        public double upper_bound
        {
            get { return _upper_bound; }
            set { _upper_bound = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::ProtoBuf.ProtoContract(Name = @"MetricFamily")]
    public partial class Metric : global::ProtoBuf.IExtensible
    {
        public Metric() { }

        private global::System.Collections.Generic.List<LabelPair> _label;
        [global::ProtoBuf.ProtoMember(1, Name = @"label", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<LabelPair> label
        {
            get { return _label; }
            set { _label = value; }
        }

        private Gauge _gauge = null;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"gauge", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public Gauge gauge
        {
            get { return _gauge; }
            set { _gauge = value; }
        }
        private Counter _counter = null;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"counter", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public Counter counter
        {
            get { return _counter; }
            set { _counter = value; }
        }
        private Summary _summary = null;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"summary", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public Summary summary
        {
            get { return _summary; }
            set { _summary = value; }
        }
        private Untyped _untyped = null;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"untyped", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public Untyped untyped
        {
            get { return _untyped; }
            set { _untyped = value; }
        }
        private Histogram _histogram = null;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name = @"histogram", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public Histogram histogram
        {
            get { return _histogram; }
            set { _histogram = value; }
        }
        private long _timestamp_ms = default(long);
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"timestamp_ms", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(long))]
        public long timestamp_ms
        {
            get { return _timestamp_ms; }
            set { _timestamp_ms = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::ProtoBuf.ProtoContract(Name = @"MetricFamily")]
    public partial class MetricFamily : global::ProtoBuf.IExtensible
    {
        public MetricFamily() { }

        private string _name = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _help = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"help", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string help
        {
            get { return _help; }
            set { _help = value; }
        }
        private MetricType _type = MetricType.COUNTER;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(MetricType.COUNTER)]
        public MetricType type
        {
            get { return _type; }
            set { _type = value; }
        }
        private readonly global::System.Collections.Generic.List<Metric> _metric = new global::System.Collections.Generic.List<Metric>();
        [global::ProtoBuf.ProtoMember(4, Name = @"MetricFamily", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Metric> metric
        {
            get { return _metric; }
        }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::ProtoBuf.ProtoContract(Name = @"MetricType")]
    public enum MetricType
    {

        [global::ProtoBuf.ProtoEnum(Name = @"COUNTER")]
        COUNTER = 0,

        [global::ProtoBuf.ProtoEnum(Name = @"GAUGE")]
        GAUGE = 1,

        [global::ProtoBuf.ProtoEnum(Name = @"SUMMARY")]
        SUMMARY = 2,

        [global::ProtoBuf.ProtoEnum(Name = @"UNTYPED")]
        UNTYPED = 3,

        [global::ProtoBuf.ProtoEnum(Name = @"HISTOGRAM")]
        HISTOGRAM = 4
    }

}