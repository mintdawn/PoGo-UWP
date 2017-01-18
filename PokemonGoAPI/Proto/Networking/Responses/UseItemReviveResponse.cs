// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: UseItemReviveResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from UseItemReviveResponse.proto</summary>
  public static partial class UseItemReviveResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for UseItemReviveResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UseItemReviveResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtVc2VJdGVtUmV2aXZlUmVzcG9uc2UucHJvdG8SH1BPR09Qcm90b3MuTmV0",
            "d29ya2luZy5SZXNwb25zZXMi4QEKFVVzZUl0ZW1SZXZpdmVSZXNwb25zZRJN",
            "CgZyZXN1bHQYASABKA4yPS5QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9u",
            "c2VzLlVzZUl0ZW1SZXZpdmVSZXNwb25zZS5SZXN1bHQSDwoHc3RhbWluYRgC",
            "IAEoBSJoCgZSZXN1bHQSCQoFVU5TRVQQABILCgdTVUNDRVNTEAESFAoQRVJS",
            "T1JfTk9fUE9LRU1PThACEhQKEEVSUk9SX0NBTk5PVF9VU0UQAxIaChZFUlJP",
            "Ul9ERVBMT1lFRF9UT19GT1JUEARiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.UseItemReviveResponse), global::POGOProtos.Networking.Responses.UseItemReviveResponse.Parser, new[]{ "Result", "Stamina" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.UseItemReviveResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UseItemReviveResponse : pb::IMessage<UseItemReviveResponse> {
    private static readonly pb::MessageParser<UseItemReviveResponse> _parser = new pb::MessageParser<UseItemReviveResponse>(() => new UseItemReviveResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UseItemReviveResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.UseItemReviveResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemReviveResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemReviveResponse(UseItemReviveResponse other) : this() {
      result_ = other.result_;
      stamina_ = other.stamina_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemReviveResponse Clone() {
      return new UseItemReviveResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.UseItemReviveResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.UseItemReviveResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "stamina" field.</summary>
    public const int StaminaFieldNumber = 2;
    private int stamina_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Stamina {
      get { return stamina_; }
      set {
        stamina_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UseItemReviveResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UseItemReviveResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (Stamina != other.Stamina) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (Stamina != 0) hash ^= Stamina.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (Stamina != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Stamina);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (Stamina != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Stamina);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UseItemReviveResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.Stamina != 0) {
        Stamina = other.Stamina;
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
            result_ = (global::POGOProtos.Networking.Responses.UseItemReviveResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 16: {
            Stamina = input.ReadInt32();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the UseItemReviveResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR_NO_POKEMON")] ErrorNoPokemon = 2,
        [pbr::OriginalName("ERROR_CANNOT_USE")] ErrorCannotUse = 3,
        [pbr::OriginalName("ERROR_DEPLOYED_TO_FORT")] ErrorDeployedToFort = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
