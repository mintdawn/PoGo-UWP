// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: InventoryUpgradeType.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Inventory {

  /// <summary>Holder for reflection information generated from InventoryUpgradeType.proto</summary>
  public static partial class InventoryUpgradeTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for InventoryUpgradeType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InventoryUpgradeTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpJbnZlbnRvcnlVcGdyYWRlVHlwZS5wcm90bxIUUE9HT1Byb3Rvcy5JbnZl",
            "bnRvcnkqYgoUSW52ZW50b3J5VXBncmFkZVR5cGUSEQoNVVBHUkFERV9VTlNF",
            "VBAAEhkKFUlOQ1JFQVNFX0lURU1fU1RPUkFHRRABEhwKGElOQ1JFQVNFX1BP",
            "S0VNT05fU1RPUkFHRRACYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Inventory.InventoryUpgradeType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum InventoryUpgradeType {
    [pbr::OriginalName("UPGRADE_UNSET")] UpgradeUnset = 0,
    [pbr::OriginalName("INCREASE_ITEM_STORAGE")] IncreaseItemStorage = 1,
    [pbr::OriginalName("INCREASE_POKEMON_STORAGE")] IncreasePokemonStorage = 2,
  }

  #endregion

}

#endregion Designer generated code
