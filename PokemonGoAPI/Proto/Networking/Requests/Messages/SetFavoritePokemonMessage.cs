// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: SetFavoritePokemonMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from SetFavoritePokemonMessage.proto</summary>
  public static partial class SetFavoritePokemonMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for SetFavoritePokemonMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SetFavoritePokemonMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9TZXRGYXZvcml0ZVBva2Vtb25NZXNzYWdlLnByb3RvEidQT0dPUHJvdG9z",
            "Lk5ldHdvcmtpbmcuUmVxdWVzdHMuTWVzc2FnZXMiRAoZU2V0RmF2b3JpdGVQ",
            "b2tlbW9uTWVzc2FnZRISCgpwb2tlbW9uX2lkGAEgASgDEhMKC2lzX2Zhdm9y",
            "aXRlGAIgASgIYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Messages.SetFavoritePokemonMessage), global::POGOProtos.Networking.Requests.Messages.SetFavoritePokemonMessage.Parser, new[]{ "PokemonId", "IsFavorite" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SetFavoritePokemonMessage : pb::IMessage<SetFavoritePokemonMessage> {
    private static readonly pb::MessageParser<SetFavoritePokemonMessage> _parser = new pb::MessageParser<SetFavoritePokemonMessage>(() => new SetFavoritePokemonMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SetFavoritePokemonMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Requests.Messages.SetFavoritePokemonMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetFavoritePokemonMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetFavoritePokemonMessage(SetFavoritePokemonMessage other) : this() {
      pokemonId_ = other.pokemonId_;
      isFavorite_ = other.isFavorite_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetFavoritePokemonMessage Clone() {
      return new SetFavoritePokemonMessage(this);
    }

    /// <summary>Field number for the "pokemon_id" field.</summary>
    public const int PokemonIdFieldNumber = 1;
    private long pokemonId_;
    /// <summary>
    ///  Do not change https://github.com/AeonLucid/POGOProtos/pull/126
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long PokemonId {
      get { return pokemonId_; }
      set {
        pokemonId_ = value;
      }
    }

    /// <summary>Field number for the "is_favorite" field.</summary>
    public const int IsFavoriteFieldNumber = 2;
    private bool isFavorite_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsFavorite {
      get { return isFavorite_; }
      set {
        isFavorite_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SetFavoritePokemonMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SetFavoritePokemonMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PokemonId != other.PokemonId) return false;
      if (IsFavorite != other.IsFavorite) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PokemonId != 0L) hash ^= PokemonId.GetHashCode();
      if (IsFavorite != false) hash ^= IsFavorite.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (PokemonId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(PokemonId);
      }
      if (IsFavorite != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsFavorite);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PokemonId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(PokemonId);
      }
      if (IsFavorite != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SetFavoritePokemonMessage other) {
      if (other == null) {
        return;
      }
      if (other.PokemonId != 0L) {
        PokemonId = other.PokemonId;
      }
      if (other.IsFavorite != false) {
        IsFavorite = other.IsFavorite;
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
            PokemonId = input.ReadInt64();
            break;
          }
          case 16: {
            IsFavorite = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
