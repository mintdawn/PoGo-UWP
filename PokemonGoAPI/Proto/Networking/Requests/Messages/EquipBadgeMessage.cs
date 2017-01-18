// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: EquipBadgeMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from EquipBadgeMessage.proto</summary>
  public static partial class EquipBadgeMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for EquipBadgeMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EquipBadgeMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdFcXVpcEJhZGdlTWVzc2FnZS5wcm90bxInUE9HT1Byb3Rvcy5OZXR3b3Jr",
            "aW5nLlJlcXVlc3RzLk1lc3NhZ2VzGiBQT0dPUHJvdG9zL0VudW1zL0JhZGdl",
            "VHlwZS5wcm90byJEChFFcXVpcEJhZGdlTWVzc2FnZRIvCgpiYWRnZV90eXBl",
            "GAEgASgOMhsuUE9HT1Byb3Rvcy5FbnVtcy5CYWRnZVR5cGViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Enums.BadgeTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Messages.EquipBadgeMessage), global::POGOProtos.Networking.Requests.Messages.EquipBadgeMessage.Parser, new[]{ "BadgeType" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EquipBadgeMessage : pb::IMessage<EquipBadgeMessage> {
    private static readonly pb::MessageParser<EquipBadgeMessage> _parser = new pb::MessageParser<EquipBadgeMessage>(() => new EquipBadgeMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EquipBadgeMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Requests.Messages.EquipBadgeMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EquipBadgeMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EquipBadgeMessage(EquipBadgeMessage other) : this() {
      badgeType_ = other.badgeType_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EquipBadgeMessage Clone() {
      return new EquipBadgeMessage(this);
    }

    /// <summary>Field number for the "badge_type" field.</summary>
    public const int BadgeTypeFieldNumber = 1;
    private global::POGOProtos.Enums.BadgeType badgeType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.BadgeType BadgeType {
      get { return badgeType_; }
      set {
        badgeType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EquipBadgeMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EquipBadgeMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BadgeType != other.BadgeType) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (BadgeType != 0) hash ^= BadgeType.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (BadgeType != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) BadgeType);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (BadgeType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BadgeType);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EquipBadgeMessage other) {
      if (other == null) {
        return;
      }
      if (other.BadgeType != 0) {
        BadgeType = other.BadgeType;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            badgeType_ = (global::POGOProtos.Enums.BadgeType) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
