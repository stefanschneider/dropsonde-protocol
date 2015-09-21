// Generated by ProtoGen, Version=2.4.1.555, Culture=neutral, PublicKeyToken=55f7125234beb589.  DO NOT EDIT!
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace CloudFoundry.Dropsonde.Events {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class Uuid {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_events_UUID__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::CloudFoundry.Dropsonde.Events.UUID, global::CloudFoundry.Dropsonde.Events.UUID.Builder> internal__static_events_UUID__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static Uuid() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cgp1dWlkLnByb3RvEgZldmVudHMiIQoEVVVJRBILCgNsb3cYASACKAQSDAoE", 
            "aGlnaBgCIAIoBEIwCiFvcmcuY2xvdWRmb3VuZHJ5LmRyb3Bzb25kZS5ldmVu", 
          "dHNCC1V1aWRGYWN0b3J5"));
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_events_UUID__Descriptor = Descriptor.MessageTypes[0];
        internal__static_events_UUID__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::CloudFoundry.Dropsonde.Events.UUID, global::CloudFoundry.Dropsonde.Events.UUID.Builder>(internal__static_events_UUID__Descriptor,
                new string[] { "Low", "High", });
        return null;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          }, assigner);
    }
    #endregion
    
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class UUID : pb::GeneratedMessage<UUID, UUID.Builder> {
    private UUID() { }
    private static readonly UUID defaultInstance = new UUID().MakeReadOnly();
    private static readonly string[] _uUIDFieldNames = new string[] { "high", "low" };
    private static readonly uint[] _uUIDFieldTags = new uint[] { 16, 8 };
    public static UUID DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override UUID DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override UUID ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::CloudFoundry.Dropsonde.Events.Uuid.internal__static_events_UUID__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<UUID, UUID.Builder> InternalFieldAccessors {
      get { return global::CloudFoundry.Dropsonde.Events.Uuid.internal__static_events_UUID__FieldAccessorTable; }
    }
    
    public const int LowFieldNumber = 1;
    private bool hasLow;
    private ulong low_;
    public bool HasLow {
      get { return hasLow; }
    }
    [global::System.CLSCompliant(false)]
    public ulong Low {
      get { return low_; }
    }
    
    public const int HighFieldNumber = 2;
    private bool hasHigh;
    private ulong high_;
    public bool HasHigh {
      get { return hasHigh; }
    }
    [global::System.CLSCompliant(false)]
    public ulong High {
      get { return high_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasLow) return false;
        if (!hasHigh) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      CalcSerializedSize();
      string[] field_names = _uUIDFieldNames;
      if (hasLow) {
        output.WriteUInt64(1, field_names[1], Low);
      }
      if (hasHigh) {
        output.WriteUInt64(2, field_names[0], High);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        return CalcSerializedSize();
      }
    }
    
    private int CalcSerializedSize() {
      int size = memoizedSerializedSize;
      if (size != -1) return size;
      
      size = 0;
      if (hasLow) {
        size += pb::CodedOutputStream.ComputeUInt64Size(1, Low);
      }
      if (hasHigh) {
        size += pb::CodedOutputStream.ComputeUInt64Size(2, High);
      }
      size += UnknownFields.SerializedSize;
      memoizedSerializedSize = size;
      return size;
    }
    public static UUID ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static UUID ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static UUID ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static UUID ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static UUID ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static UUID ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static UUID ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static UUID ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static UUID ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static UUID ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private UUID MakeReadOnly() {
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(UUID prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<UUID, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(UUID cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private UUID result;
      
      private UUID PrepareBuilder() {
        if (resultIsReadOnly) {
          UUID original = result;
          result = new UUID();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override UUID MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }
      
      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }
      
      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::CloudFoundry.Dropsonde.Events.UUID.Descriptor; }
      }
      
      public override UUID DefaultInstanceForType {
        get { return global::CloudFoundry.Dropsonde.Events.UUID.DefaultInstance; }
      }
      
      public override UUID BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is UUID) {
          return MergeFrom((UUID) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(UUID other) {
        if (other == global::CloudFoundry.Dropsonde.Events.UUID.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasLow) {
          Low = other.Low;
        }
        if (other.HasHigh) {
          High = other.High;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_uUIDFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _uUIDFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 8: {
              result.hasLow = input.ReadUInt64(ref result.low_);
              break;
            }
            case 16: {
              result.hasHigh = input.ReadUInt64(ref result.high_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasLow {
        get { return result.hasLow; }
      }
      [global::System.CLSCompliant(false)]
      public ulong Low {
        get { return result.Low; }
        set { SetLow(value); }
      }
      [global::System.CLSCompliant(false)]
      public Builder SetLow(ulong value) {
        PrepareBuilder();
        result.hasLow = true;
        result.low_ = value;
        return this;
      }
      public Builder ClearLow() {
        PrepareBuilder();
        result.hasLow = false;
        result.low_ = 0UL;
        return this;
      }
      
      public bool HasHigh {
        get { return result.hasHigh; }
      }
      [global::System.CLSCompliant(false)]
      public ulong High {
        get { return result.High; }
        set { SetHigh(value); }
      }
      [global::System.CLSCompliant(false)]
      public Builder SetHigh(ulong value) {
        PrepareBuilder();
        result.hasHigh = true;
        result.high_ = value;
        return this;
      }
      public Builder ClearHigh() {
        PrepareBuilder();
        result.hasHigh = false;
        result.high_ = 0UL;
        return this;
      }
    }
    static UUID() {
      object.ReferenceEquals(global::CloudFoundry.Dropsonde.Events.Uuid.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code
