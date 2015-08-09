// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: uuid.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CloudFoundry.Dropsonde.Events {

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class Uuid {

    #region Descriptor
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Uuid() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cgp1dWlkLnByb3RvEgZldmVudHMiIQoEVVVJRBILCgNsb3cYASABKAQSDAoE", 
            "aGlnaBgCIAEoBEJQCiFvcmcuY2xvdWRmb3VuZHJ5LmRyb3Bzb25kZS5ldmVu", 
            "dHNCC1V1aWRGYWN0b3J5qgIdQ2xvdWRGb3VuZHJ5LkRyb3Bzb25kZS5FdmVu", 
            "dHNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedCodeInfo(null, new pbr::GeneratedCodeInfo[] {
            new pbr::GeneratedCodeInfo(typeof(global::CloudFoundry.Dropsonde.Events.UUID), new[]{ "Low", "High" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class UUID : pb::IMessage<UUID> {
    private static readonly pb::MessageParser<UUID> _parser = new pb::MessageParser<UUID>(() => new UUID());
    public static pb::MessageParser<UUID> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::CloudFoundry.Dropsonde.Events.Uuid.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public UUID() {
      OnConstruction();
    }

    partial void OnConstruction();

    public UUID(UUID other) : this() {
      low_ = other.low_;
      high_ = other.high_;
    }

    public UUID Clone() {
      return new UUID(this);
    }

    public const int LowFieldNumber = 1;
    private ulong low_;
    public ulong Low {
      get { return low_; }
      set {
        low_ = value;
      }
    }

    public const int HighFieldNumber = 2;
    private ulong high_;
    public ulong High {
      get { return high_; }
      set {
        high_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as UUID);
    }

    public bool Equals(UUID other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Low != other.Low) return false;
      if (High != other.High) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Low != 0UL) hash ^= Low.GetHashCode();
      if (High != 0UL) hash ^= High.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Low != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(Low);
      }
      if (High != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(High);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Low != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Low);
      }
      if (High != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(High);
      }
      return size;
    }

    public void MergeFrom(UUID other) {
      if (other == null) {
        return;
      }
      if (other.Low != 0UL) {
        Low = other.Low;
      }
      if (other.High != 0UL) {
        High = other.High;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Low = input.ReadUInt64();
            break;
          }
          case 16: {
            High = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
