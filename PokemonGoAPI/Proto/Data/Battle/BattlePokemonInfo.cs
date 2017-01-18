// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: BattlePokemonInfo.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Battle {

  /// <summary>Holder for reflection information generated from BattlePokemonInfo.proto</summary>
  public static partial class BattlePokemonInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for BattlePokemonInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattlePokemonInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdCYXR0bGVQb2tlbW9uSW5mby5wcm90bxIWUE9HT1Byb3Rvcy5EYXRhLkJh",
            "dHRsZRohUE9HT1Byb3Rvcy9EYXRhL1Bva2Vtb25EYXRhLnByb3RvIncKEUJh",
            "dHRsZVBva2Vtb25JbmZvEjIKDHBva2Vtb25fZGF0YRgBIAEoCzIcLlBPR09Q",
            "cm90b3MuRGF0YS5Qb2tlbW9uRGF0YRIWCg5jdXJyZW50X2hlYWx0aBgCIAEo",
            "BRIWCg5jdXJyZW50X2VuZXJneRgDIAEoBWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.PokemonDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Battle.BattlePokemonInfo), global::POGOProtos.Data.Battle.BattlePokemonInfo.Parser, new[]{ "PokemonData", "CurrentHealth", "CurrentEnergy" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BattlePokemonInfo : pb::IMessage<BattlePokemonInfo> {
    private static readonly pb::MessageParser<BattlePokemonInfo> _parser = new pb::MessageParser<BattlePokemonInfo>(() => new BattlePokemonInfo());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BattlePokemonInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Battle.BattlePokemonInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BattlePokemonInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BattlePokemonInfo(BattlePokemonInfo other) : this() {
      PokemonData = other.pokemonData_ != null ? other.PokemonData.Clone() : null;
      currentHealth_ = other.currentHealth_;
      currentEnergy_ = other.currentEnergy_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BattlePokemonInfo Clone() {
      return new BattlePokemonInfo(this);
    }

    /// <summary>Field number for the "pokemon_data" field.</summary>
    public const int PokemonDataFieldNumber = 1;
    private global::POGOProtos.Data.PokemonData pokemonData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.PokemonData PokemonData {
      get { return pokemonData_; }
      set {
        pokemonData_ = value;
      }
    }

    /// <summary>Field number for the "current_health" field.</summary>
    public const int CurrentHealthFieldNumber = 2;
    private int currentHealth_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CurrentHealth {
      get { return currentHealth_; }
      set {
        currentHealth_ = value;
      }
    }

    /// <summary>Field number for the "current_energy" field.</summary>
    public const int CurrentEnergyFieldNumber = 3;
    private int currentEnergy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CurrentEnergy {
      get { return currentEnergy_; }
      set {
        currentEnergy_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BattlePokemonInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BattlePokemonInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PokemonData, other.PokemonData)) return false;
      if (CurrentHealth != other.CurrentHealth) return false;
      if (CurrentEnergy != other.CurrentEnergy) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (pokemonData_ != null) hash ^= PokemonData.GetHashCode();
      if (CurrentHealth != 0) hash ^= CurrentHealth.GetHashCode();
      if (CurrentEnergy != 0) hash ^= CurrentEnergy.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (pokemonData_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(PokemonData);
      }
      if (CurrentHealth != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(CurrentHealth);
      }
      if (CurrentEnergy != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(CurrentEnergy);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (pokemonData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonData);
      }
      if (CurrentHealth != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CurrentHealth);
      }
      if (CurrentEnergy != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CurrentEnergy);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BattlePokemonInfo other) {
      if (other == null) {
        return;
      }
      if (other.pokemonData_ != null) {
        if (pokemonData_ == null) {
          pokemonData_ = new global::POGOProtos.Data.PokemonData();
        }
        PokemonData.MergeFrom(other.PokemonData);
      }
      if (other.CurrentHealth != 0) {
        CurrentHealth = other.CurrentHealth;
      }
      if (other.CurrentEnergy != 0) {
        CurrentEnergy = other.CurrentEnergy;
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
            if (pokemonData_ == null) {
              pokemonData_ = new global::POGOProtos.Data.PokemonData();
            }
            input.ReadMessage(pokemonData_);
            break;
          }
          case 16: {
            CurrentHealth = input.ReadInt32();
            break;
          }
          case 24: {
            CurrentEnergy = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
