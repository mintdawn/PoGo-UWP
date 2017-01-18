// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: DownloadSettingsResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from DownloadSettingsResponse.proto</summary>
  public static partial class DownloadSettingsResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for DownloadSettingsResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DownloadSettingsResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5Eb3dubG9hZFNldHRpbmdzUmVzcG9uc2UucHJvdG8SH1BPR09Qcm90b3Mu",
            "TmV0d29ya2luZy5SZXNwb25zZXMaKFBPR09Qcm90b3MvU2V0dGluZ3MvR2xv",
            "YmFsU2V0dGluZ3MucHJvdG8ibgoYRG93bmxvYWRTZXR0aW5nc1Jlc3BvbnNl",
            "Eg0KBWVycm9yGAEgASgJEgwKBGhhc2gYAiABKAkSNQoIc2V0dGluZ3MYAyAB",
            "KAsyIy5QT0dPUHJvdG9zLlNldHRpbmdzLkdsb2JhbFNldHRpbmdzYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Settings.GlobalSettingsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.DownloadSettingsResponse), global::POGOProtos.Networking.Responses.DownloadSettingsResponse.Parser, new[]{ "Error", "Hash", "Settings" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DownloadSettingsResponse : pb::IMessage<DownloadSettingsResponse> {
    private static readonly pb::MessageParser<DownloadSettingsResponse> _parser = new pb::MessageParser<DownloadSettingsResponse>(() => new DownloadSettingsResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DownloadSettingsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.DownloadSettingsResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DownloadSettingsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DownloadSettingsResponse(DownloadSettingsResponse other) : this() {
      error_ = other.error_;
      hash_ = other.hash_;
      Settings = other.settings_ != null ? other.Settings.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DownloadSettingsResponse Clone() {
      return new DownloadSettingsResponse(this);
    }

    /// <summary>Field number for the "error" field.</summary>
    public const int ErrorFieldNumber = 1;
    private string error_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Error {
      get { return error_; }
      set {
        error_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "hash" field.</summary>
    public const int HashFieldNumber = 2;
    private string hash_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Hash {
      get { return hash_; }
      set {
        hash_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "settings" field.</summary>
    public const int SettingsFieldNumber = 3;
    private global::POGOProtos.Settings.GlobalSettings settings_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Settings.GlobalSettings Settings {
      get { return settings_; }
      set {
        settings_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DownloadSettingsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DownloadSettingsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Error != other.Error) return false;
      if (Hash != other.Hash) return false;
      if (!object.Equals(Settings, other.Settings)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Error.Length != 0) hash ^= Error.GetHashCode();
      if (Hash.Length != 0) hash ^= Hash.GetHashCode();
      if (settings_ != null) hash ^= Settings.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Error.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Error);
      }
      if (Hash.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Hash);
      }
      if (settings_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Settings);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Error.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Error);
      }
      if (Hash.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Hash);
      }
      if (settings_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Settings);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DownloadSettingsResponse other) {
      if (other == null) {
        return;
      }
      if (other.Error.Length != 0) {
        Error = other.Error;
      }
      if (other.Hash.Length != 0) {
        Hash = other.Hash;
      }
      if (other.settings_ != null) {
        if (settings_ == null) {
          settings_ = new global::POGOProtos.Settings.GlobalSettings();
        }
        Settings.MergeFrom(other.Settings);
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
          case 10: {
            Error = input.ReadString();
            break;
          }
          case 18: {
            Hash = input.ReadString();
            break;
          }
          case 26: {
            if (settings_ == null) {
              settings_ = new global::POGOProtos.Settings.GlobalSettings();
            }
            input.ReadMessage(settings_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
