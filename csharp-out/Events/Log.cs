// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: log.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace CloudFoundry.Dropsonde.Events {

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class Log {

    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_events_LogMessage__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::CloudFoundry.Dropsonde.Events.LogMessage, global::CloudFoundry.Dropsonde.Events.LogMessage.Builder> internal__static_events_LogMessage__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;

    static Log() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cglsb2cucHJvdG8SBmV2ZW50cyLFAQoKTG9nTWVzc2FnZRIPCgdtZXNzYWdl", 
            "GAEgAigMEjQKDG1lc3NhZ2VfdHlwZRgCIAIoDjIeLmV2ZW50cy5Mb2dNZXNz", 
            "YWdlLk1lc3NhZ2VUeXBlEhEKCXRpbWVzdGFtcBgDIAIoAxIOCgZhcHBfaWQY", 
            "BCABKAkSEwoLc291cmNlX3R5cGUYBSABKAkSFwoPc291cmNlX2luc3RhbmNl", 
            "GAYgASgJIh8KC01lc3NhZ2VUeXBlEgcKA09VVBABEgcKA0VSUhACQk8KIW9y", 
            "Zy5jbG91ZGZvdW5kcnkuZHJvcHNvbmRlLmV2ZW50c0IKTG9nRmFjdG9yeaoC", 
          "HUNsb3VkRm91bmRyeS5Ecm9wc29uZGUuRXZlbnRz"));
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_events_LogMessage__Descriptor = Descriptor.MessageTypes[0];
        internal__static_events_LogMessage__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::CloudFoundry.Dropsonde.Events.LogMessage, global::CloudFoundry.Dropsonde.Events.LogMessage.Builder>(internal__static_events_LogMessage__Descriptor,
                new string[] { "Message", "MessageType", "Timestamp", "AppId", "SourceType", "SourceInstance", });
        pb::ExtensionRegistry registry = pb::ExtensionRegistry.CreateInstance();
        RegisterAllExtensions(registry);
        return registry;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          }, assigner);
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class LogMessage : pb::GeneratedMessage<LogMessage, LogMessage.Builder> {
    private LogMessage() { }
    private static readonly LogMessage defaultInstance = new LogMessage().MakeReadOnly();
    private static readonly string[] _logMessageFieldNames = new string[] { "app_id", "message", "message_type", "source_instance", "source_type", "timestamp" };
    private static readonly uint[] _logMessageFieldTags = new uint[] { 34, 10, 16, 50, 42, 24 };
    public static LogMessage DefaultInstance {
      get { return defaultInstance; }
    }

    public override LogMessage DefaultInstanceForType {
      get { return DefaultInstance; }
    }

    protected override LogMessage ThisMessage {
      get { return this; }
    }

    public static pbd::MessageDescriptor Descriptor {
      get { return global::CloudFoundry.Dropsonde.Events.Log.internal__static_events_LogMessage__Descriptor; }
    }

    protected override pb::FieldAccess.FieldAccessorTable<LogMessage, LogMessage.Builder> InternalFieldAccessors {
      get { return global::CloudFoundry.Dropsonde.Events.Log.internal__static_events_LogMessage__FieldAccessorTable; }
    }

    #region Nested types
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum MessageType {
        OUT = 1,
        ERR = 2,
      }

    }
    #endregion

    public const int MessageFieldNumber = 1;
    private bool hasMessage;
    private pb::ByteString message_ = pb::ByteString.Empty;
    public bool HasMessage {
      get { return hasMessage; }
    }
    public pb::ByteString Message {
      get { return message_; }
    }

    public const int MessageTypeFieldNumber = 2;
    private bool hasMessageType;
    private global::CloudFoundry.Dropsonde.Events.LogMessage.Types.MessageType messageType_ = global::CloudFoundry.Dropsonde.Events.LogMessage.Types.MessageType.OUT;
    public bool HasMessageType {
      get { return hasMessageType; }
    }
    public global::CloudFoundry.Dropsonde.Events.LogMessage.Types.MessageType MessageType {
      get { return messageType_; }
    }

    public const int TimestampFieldNumber = 3;
    private bool hasTimestamp;
    private long timestamp_;
    public bool HasTimestamp {
      get { return hasTimestamp; }
    }
    public long Timestamp {
      get { return timestamp_; }
    }

    public const int AppIdFieldNumber = 4;
    private bool hasAppId;
    private string appId_ = "";
    public bool HasAppId {
      get { return hasAppId; }
    }
    public string AppId {
      get { return appId_; }
    }

    public const int SourceTypeFieldNumber = 5;
    private bool hasSourceType;
    private string sourceType_ = "";
    public bool HasSourceType {
      get { return hasSourceType; }
    }
    public string SourceType {
      get { return sourceType_; }
    }

    public const int SourceInstanceFieldNumber = 6;
    private bool hasSourceInstance;
    private string sourceInstance_ = "";
    public bool HasSourceInstance {
      get { return hasSourceInstance; }
    }
    public string SourceInstance {
      get { return sourceInstance_; }
    }

    public override bool IsInitialized {
      get {
        if (!hasMessage) return false;
        if (!hasMessageType) return false;
        if (!hasTimestamp) return false;
        return true;
      }
    }

    public override void WriteTo(pb::ICodedOutputStream output) {
      CalcSerializedSize();
      string[] field_names = _logMessageFieldNames;
      if (hasMessage) {
        output.WriteBytes(1, field_names[1], Message);
      }
      if (hasMessageType) {
        output.WriteEnum(2, field_names[2], (int) MessageType, MessageType);
      }
      if (hasTimestamp) {
        output.WriteInt64(3, field_names[5], Timestamp);
      }
      if (hasAppId) {
        output.WriteString(4, field_names[0], AppId);
      }
      if (hasSourceType) {
        output.WriteString(5, field_names[4], SourceType);
      }
      if (hasSourceInstance) {
        output.WriteString(6, field_names[3], SourceInstance);
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
      if (hasMessage) {
        size += pb::CodedOutputStream.ComputeBytesSize(1, Message);
      }
      if (hasMessageType) {
        size += pb::CodedOutputStream.ComputeEnumSize(2, (int) MessageType);
      }
      if (hasTimestamp) {
        size += pb::CodedOutputStream.ComputeInt64Size(3, Timestamp);
      }
      if (hasAppId) {
        size += pb::CodedOutputStream.ComputeStringSize(4, AppId);
      }
      if (hasSourceType) {
        size += pb::CodedOutputStream.ComputeStringSize(5, SourceType);
      }
      if (hasSourceInstance) {
        size += pb::CodedOutputStream.ComputeStringSize(6, SourceInstance);
      }
      size += UnknownFields.SerializedSize;
      memoizedSerializedSize = size;
      return size;
    }
    public static LogMessage ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static LogMessage ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static LogMessage ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static LogMessage ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static LogMessage ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static LogMessage ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static LogMessage ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static LogMessage ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static LogMessage ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static LogMessage ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private LogMessage MakeReadOnly() {
      return this;
    }

    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(LogMessage prototype) {
      return new Builder(prototype);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<LogMessage, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(LogMessage cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

      private bool resultIsReadOnly;
      private LogMessage result;

      private LogMessage PrepareBuilder() {
        if (resultIsReadOnly) {
          LogMessage original = result;
          result = new LogMessage();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

      protected override LogMessage MessageBeingBuilt {
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
        get { return global::CloudFoundry.Dropsonde.Events.LogMessage.Descriptor; }
      }

      public override LogMessage DefaultInstanceForType {
        get { return global::CloudFoundry.Dropsonde.Events.LogMessage.DefaultInstance; }
      }

      public override LogMessage BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

      public override Builder MergeFrom(pb::IMessage other) {
        if (other is LogMessage) {
          return MergeFrom((LogMessage) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

      public override Builder MergeFrom(LogMessage other) {
        if (other == global::CloudFoundry.Dropsonde.Events.LogMessage.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasMessage) {
          Message = other.Message;
        }
        if (other.HasMessageType) {
          MessageType = other.MessageType;
        }
        if (other.HasTimestamp) {
          Timestamp = other.Timestamp;
        }
        if (other.HasAppId) {
          AppId = other.AppId;
        }
        if (other.HasSourceType) {
          SourceType = other.SourceType;
        }
        if (other.HasSourceInstance) {
          SourceInstance = other.SourceInstance;
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
            int field_ordinal = global::System.Array.BinarySearch(_logMessageFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _logMessageFieldTags[field_ordinal];
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
            case 10: {
              result.hasMessage = input.ReadBytes(ref result.message_);
              break;
            }
            case 16: {
              object unknown;
              if(input.ReadEnum(ref result.messageType_, out unknown)) {
                result.hasMessageType = true;
              } else if(unknown is int) {
                if (unknownFields == null) {
                  unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                }
                unknownFields.MergeVarintField(2, (ulong)(int)unknown);
              }
              break;
            }
            case 24: {
              result.hasTimestamp = input.ReadInt64(ref result.timestamp_);
              break;
            }
            case 34: {
              result.hasAppId = input.ReadString(ref result.appId_);
              break;
            }
            case 42: {
              result.hasSourceType = input.ReadString(ref result.sourceType_);
              break;
            }
            case 50: {
              result.hasSourceInstance = input.ReadString(ref result.sourceInstance_);
              break;
            }
          }
        }

        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }


      public bool HasMessage {
        get { return result.hasMessage; }
      }
      public pb::ByteString Message {
        get { return result.Message; }
        set { SetMessage(value); }
      }
      public Builder SetMessage(pb::ByteString value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasMessage = true;
        result.message_ = value;
        return this;
      }
      public Builder ClearMessage() {
        PrepareBuilder();
        result.hasMessage = false;
        result.message_ = pb::ByteString.Empty;
        return this;
      }

      public bool HasMessageType {
        get { return result.hasMessageType; }
      }
      public global::CloudFoundry.Dropsonde.Events.LogMessage.Types.MessageType MessageType {
        get { return result.MessageType; }
        set { SetMessageType(value); }
      }
      public Builder SetMessageType(global::CloudFoundry.Dropsonde.Events.LogMessage.Types.MessageType value) {
        PrepareBuilder();
        result.hasMessageType = true;
        result.messageType_ = value;
        return this;
      }
      public Builder ClearMessageType() {
        PrepareBuilder();
        result.hasMessageType = false;
        result.messageType_ = global::CloudFoundry.Dropsonde.Events.LogMessage.Types.MessageType.OUT;
        return this;
      }

      public bool HasTimestamp {
        get { return result.hasTimestamp; }
      }
      public long Timestamp {
        get { return result.Timestamp; }
        set { SetTimestamp(value); }
      }
      public Builder SetTimestamp(long value) {
        PrepareBuilder();
        result.hasTimestamp = true;
        result.timestamp_ = value;
        return this;
      }
      public Builder ClearTimestamp() {
        PrepareBuilder();
        result.hasTimestamp = false;
        result.timestamp_ = 0L;
        return this;
      }

      public bool HasAppId {
        get { return result.hasAppId; }
      }
      public string AppId {
        get { return result.AppId; }
        set { SetAppId(value); }
      }
      public Builder SetAppId(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasAppId = true;
        result.appId_ = value;
        return this;
      }
      public Builder ClearAppId() {
        PrepareBuilder();
        result.hasAppId = false;
        result.appId_ = "";
        return this;
      }

      public bool HasSourceType {
        get { return result.hasSourceType; }
      }
      public string SourceType {
        get { return result.SourceType; }
        set { SetSourceType(value); }
      }
      public Builder SetSourceType(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasSourceType = true;
        result.sourceType_ = value;
        return this;
      }
      public Builder ClearSourceType() {
        PrepareBuilder();
        result.hasSourceType = false;
        result.sourceType_ = "";
        return this;
      }

      public bool HasSourceInstance {
        get { return result.hasSourceInstance; }
      }
      public string SourceInstance {
        get { return result.SourceInstance; }
        set { SetSourceInstance(value); }
      }
      public Builder SetSourceInstance(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasSourceInstance = true;
        result.sourceInstance_ = value;
        return this;
      }
      public Builder ClearSourceInstance() {
        PrepareBuilder();
        result.hasSourceInstance = false;
        result.sourceInstance_ = "";
        return this;
      }
    }
    static LogMessage() {
      object.ReferenceEquals(global::CloudFoundry.Dropsonde.Events.Log.Descriptor, null);
    }
  }

  #endregion

}

#endregion Designer generated code
