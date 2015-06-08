// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: heartbeat.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace CloudFoundry.Dropsonde.Events {

  namespace Proto {

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Heartbeat {

      #region Extension registration
      public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
      }
      #endregion
      #region Static variables
      internal static pbd::MessageDescriptor internal__static_events_Heartbeat__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::CloudFoundry.Dropsonde.Events.Heartbeat, global::CloudFoundry.Dropsonde.Events.Heartbeat.Builder> internal__static_events_Heartbeat__FieldAccessorTable;
      #endregion
      #region Descriptor
      public static pbd::FileDescriptor Descriptor {
        get { return descriptor; }
      }
      private static pbd::FileDescriptor descriptor;

      static Heartbeat() {
        byte[] descriptorData = global::System.Convert.FromBase64String(
            string.Concat(
              "Cg9oZWFydGJlYXQucHJvdG8SBmV2ZW50cxoKdXVpZC5wcm90byJ5CglIZWFy", 
              "dGJlYXQSEQoJc2VudENvdW50GAEgAigEEhUKDXJlY2VpdmVkQ291bnQYAiAC", 
              "KAQSEgoKZXJyb3JDb3VudBgDIAIoBBIuChhjb250cm9sTWVzc2FnZUlkZW50", 
              "aWZpZXIYBCABKAsyDC5ldmVudHMuVVVJREJVCiFvcmcuY2xvdWRmb3VuZHJ5", 
              "LmRyb3Bzb25kZS5ldmVudHNCEEhlYXJ0YmVhdEZhY3RvcnmqAh1DbG91ZEZv", 
            "dW5kcnkuRHJvcHNvbmRlLkV2ZW50cw=="));
        pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
          descriptor = root;
          internal__static_events_Heartbeat__Descriptor = Descriptor.MessageTypes[0];
          internal__static_events_Heartbeat__FieldAccessorTable = 
              new pb::FieldAccess.FieldAccessorTable<global::CloudFoundry.Dropsonde.Events.Heartbeat, global::CloudFoundry.Dropsonde.Events.Heartbeat.Builder>(internal__static_events_Heartbeat__Descriptor,
                  new string[] { "SentCount", "ReceivedCount", "ErrorCount", "ControlMessageIdentifier", });
          pb::ExtensionRegistry registry = pb::ExtensionRegistry.CreateInstance();
          RegisterAllExtensions(registry);
          global::CloudFoundry.Dropsonde.Events.Uuid.RegisterAllExtensions(registry);
          return registry;
        };
        pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
            new pbd::FileDescriptor[] {
            global::CloudFoundry.Dropsonde.Events.Uuid.Descriptor, 
            }, assigner);
      }
      #endregion

    }
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Heartbeat : pb::GeneratedMessage<Heartbeat, Heartbeat.Builder> {
    private Heartbeat() { }
    private static readonly Heartbeat defaultInstance = new Heartbeat().MakeReadOnly();
    private static readonly string[] _heartbeatFieldNames = new string[] { "controlMessageIdentifier", "errorCount", "receivedCount", "sentCount" };
    private static readonly uint[] _heartbeatFieldTags = new uint[] { 34, 24, 16, 8 };
    public static Heartbeat DefaultInstance {
      get { return defaultInstance; }
    }

    public override Heartbeat DefaultInstanceForType {
      get { return DefaultInstance; }
    }

    protected override Heartbeat ThisMessage {
      get { return this; }
    }

    public static pbd::MessageDescriptor Descriptor {
      get { return global::CloudFoundry.Dropsonde.Events.Proto.Heartbeat.internal__static_events_Heartbeat__Descriptor; }
    }

    protected override pb::FieldAccess.FieldAccessorTable<Heartbeat, Heartbeat.Builder> InternalFieldAccessors {
      get { return global::CloudFoundry.Dropsonde.Events.Proto.Heartbeat.internal__static_events_Heartbeat__FieldAccessorTable; }
    }

    public const int SentCountFieldNumber = 1;
    private bool hasSentCount;
    private ulong sentCount_;
    public bool HasSentCount {
      get { return hasSentCount; }
    }
    public ulong SentCount {
      get { return sentCount_; }
    }

    public const int ReceivedCountFieldNumber = 2;
    private bool hasReceivedCount;
    private ulong receivedCount_;
    public bool HasReceivedCount {
      get { return hasReceivedCount; }
    }
    public ulong ReceivedCount {
      get { return receivedCount_; }
    }

    public const int ErrorCountFieldNumber = 3;
    private bool hasErrorCount;
    private ulong errorCount_;
    public bool HasErrorCount {
      get { return hasErrorCount; }
    }
    public ulong ErrorCount {
      get { return errorCount_; }
    }

    public const int ControlMessageIdentifierFieldNumber = 4;
    private bool hasControlMessageIdentifier;
    private global::CloudFoundry.Dropsonde.Events.UUID controlMessageIdentifier_;
    public bool HasControlMessageIdentifier {
      get { return hasControlMessageIdentifier; }
    }
    public global::CloudFoundry.Dropsonde.Events.UUID ControlMessageIdentifier {
      get { return controlMessageIdentifier_ ?? global::CloudFoundry.Dropsonde.Events.UUID.DefaultInstance; }
    }

    public override bool IsInitialized {
      get {
        if (!hasSentCount) return false;
        if (!hasReceivedCount) return false;
        if (!hasErrorCount) return false;
        if (HasControlMessageIdentifier) {
          if (!ControlMessageIdentifier.IsInitialized) return false;
        }
        return true;
      }
    }

    public override void WriteTo(pb::ICodedOutputStream output) {
      CalcSerializedSize();
      string[] field_names = _heartbeatFieldNames;
      if (hasSentCount) {
        output.WriteUInt64(1, field_names[3], SentCount);
      }
      if (hasReceivedCount) {
        output.WriteUInt64(2, field_names[2], ReceivedCount);
      }
      if (hasErrorCount) {
        output.WriteUInt64(3, field_names[1], ErrorCount);
      }
      if (hasControlMessageIdentifier) {
        output.WriteMessage(4, field_names[0], ControlMessageIdentifier);
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
      if (hasSentCount) {
        size += pb::CodedOutputStream.ComputeUInt64Size(1, SentCount);
      }
      if (hasReceivedCount) {
        size += pb::CodedOutputStream.ComputeUInt64Size(2, ReceivedCount);
      }
      if (hasErrorCount) {
        size += pb::CodedOutputStream.ComputeUInt64Size(3, ErrorCount);
      }
      if (hasControlMessageIdentifier) {
        size += pb::CodedOutputStream.ComputeMessageSize(4, ControlMessageIdentifier);
      }
      size += UnknownFields.SerializedSize;
      memoizedSerializedSize = size;
      return size;
    }
    public static Heartbeat ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Heartbeat ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Heartbeat ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Heartbeat ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Heartbeat ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Heartbeat ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Heartbeat ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static Heartbeat ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static Heartbeat ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Heartbeat ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private Heartbeat MakeReadOnly() {
      return this;
    }

    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(Heartbeat prototype) {
      return new Builder(prototype);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<Heartbeat, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(Heartbeat cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

      private bool resultIsReadOnly;
      private Heartbeat result;

      private Heartbeat PrepareBuilder() {
        if (resultIsReadOnly) {
          Heartbeat original = result;
          result = new Heartbeat();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

      protected override Heartbeat MessageBeingBuilt {
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
        get { return global::CloudFoundry.Dropsonde.Events.Heartbeat.Descriptor; }
      }

      public override Heartbeat DefaultInstanceForType {
        get { return global::CloudFoundry.Dropsonde.Events.Heartbeat.DefaultInstance; }
      }

      public override Heartbeat BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

      public override Builder MergeFrom(pb::IMessage other) {
        if (other is Heartbeat) {
          return MergeFrom((Heartbeat) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

      public override Builder MergeFrom(Heartbeat other) {
        if (other == global::CloudFoundry.Dropsonde.Events.Heartbeat.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasSentCount) {
          SentCount = other.SentCount;
        }
        if (other.HasReceivedCount) {
          ReceivedCount = other.ReceivedCount;
        }
        if (other.HasErrorCount) {
          ErrorCount = other.ErrorCount;
        }
        if (other.HasControlMessageIdentifier) {
          MergeControlMessageIdentifier(other.ControlMessageIdentifier);
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
            int field_ordinal = global::System.Array.BinarySearch(_heartbeatFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _heartbeatFieldTags[field_ordinal];
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
              result.hasSentCount = input.ReadUInt64(ref result.sentCount_);
              break;
            }
            case 16: {
              result.hasReceivedCount = input.ReadUInt64(ref result.receivedCount_);
              break;
            }
            case 24: {
              result.hasErrorCount = input.ReadUInt64(ref result.errorCount_);
              break;
            }
            case 34: {
              global::CloudFoundry.Dropsonde.Events.UUID.Builder subBuilder = global::CloudFoundry.Dropsonde.Events.UUID.CreateBuilder();
              if (result.hasControlMessageIdentifier) {
                subBuilder.MergeFrom(ControlMessageIdentifier);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              ControlMessageIdentifier = subBuilder.BuildPartial();
              break;
            }
          }
        }

        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }


      public bool HasSentCount {
        get { return result.hasSentCount; }
      }
      public ulong SentCount {
        get { return result.SentCount; }
        set { SetSentCount(value); }
      }
      public Builder SetSentCount(ulong value) {
        PrepareBuilder();
        result.hasSentCount = true;
        result.sentCount_ = value;
        return this;
      }
      public Builder ClearSentCount() {
        PrepareBuilder();
        result.hasSentCount = false;
        result.sentCount_ = 0UL;
        return this;
      }

      public bool HasReceivedCount {
        get { return result.hasReceivedCount; }
      }
      public ulong ReceivedCount {
        get { return result.ReceivedCount; }
        set { SetReceivedCount(value); }
      }
      public Builder SetReceivedCount(ulong value) {
        PrepareBuilder();
        result.hasReceivedCount = true;
        result.receivedCount_ = value;
        return this;
      }
      public Builder ClearReceivedCount() {
        PrepareBuilder();
        result.hasReceivedCount = false;
        result.receivedCount_ = 0UL;
        return this;
      }

      public bool HasErrorCount {
        get { return result.hasErrorCount; }
      }
      public ulong ErrorCount {
        get { return result.ErrorCount; }
        set { SetErrorCount(value); }
      }
      public Builder SetErrorCount(ulong value) {
        PrepareBuilder();
        result.hasErrorCount = true;
        result.errorCount_ = value;
        return this;
      }
      public Builder ClearErrorCount() {
        PrepareBuilder();
        result.hasErrorCount = false;
        result.errorCount_ = 0UL;
        return this;
      }

      public bool HasControlMessageIdentifier {
       get { return result.hasControlMessageIdentifier; }
      }
      public global::CloudFoundry.Dropsonde.Events.UUID ControlMessageIdentifier {
        get { return result.ControlMessageIdentifier; }
        set { SetControlMessageIdentifier(value); }
      }
      public Builder SetControlMessageIdentifier(global::CloudFoundry.Dropsonde.Events.UUID value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasControlMessageIdentifier = true;
        result.controlMessageIdentifier_ = value;
        return this;
      }
      public Builder SetControlMessageIdentifier(global::CloudFoundry.Dropsonde.Events.UUID.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasControlMessageIdentifier = true;
        result.controlMessageIdentifier_ = builderForValue.Build();
        return this;
      }
      public Builder MergeControlMessageIdentifier(global::CloudFoundry.Dropsonde.Events.UUID value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasControlMessageIdentifier &&
            result.controlMessageIdentifier_ != global::CloudFoundry.Dropsonde.Events.UUID.DefaultInstance) {
            result.controlMessageIdentifier_ = global::CloudFoundry.Dropsonde.Events.UUID.CreateBuilder(result.controlMessageIdentifier_).MergeFrom(value).BuildPartial();
        } else {
          result.controlMessageIdentifier_ = value;
        }
        result.hasControlMessageIdentifier = true;
        return this;
      }
      public Builder ClearControlMessageIdentifier() {
        PrepareBuilder();
        result.hasControlMessageIdentifier = false;
        result.controlMessageIdentifier_ = null;
        return this;
      }
    }
    static Heartbeat() {
      object.ReferenceEquals(global::CloudFoundry.Dropsonde.Events.Proto.Heartbeat.Descriptor, null);
    }
  }

  #endregion

}

#endregion Designer generated code