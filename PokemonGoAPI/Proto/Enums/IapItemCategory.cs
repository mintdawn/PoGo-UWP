// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: IapItemCategory.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Enums {

  /// <summary>Holder for reflection information generated from IapItemCategory.proto</summary>
  public static partial class IapItemCategoryReflection {

    #region Descriptor
    /// <summary>File descriptor for IapItemCategory.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IapItemCategoryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVJYXBJdGVtQ2F0ZWdvcnkucHJvdG8SEFBPR09Qcm90b3MuRW51bXMqrQEK",
            "E0hvbG9JYXBJdGVtQ2F0ZWdvcnkSFQoRSUFQX0NBVEVHT1JZX05PTkUQABIX",
            "ChNJQVBfQ0FURUdPUllfQlVORExFEAESFgoSSUFQX0NBVEVHT1JZX0lURU1T",
            "EAISGQoVSUFQX0NBVEVHT1JZX1VQR1JBREVTEAMSGgoWSUFQX0NBVEVHT1JZ",
            "X1BPS0VDT0lOUxAEEhcKE0lBUF9DQVRFR09SWV9BVkFUQVIQBWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Enums.HoloIapItemCategory), }, null));
    }
    #endregion

  }
  #region Enums
  public enum HoloIapItemCategory {
    [pbr::OriginalName("IAP_CATEGORY_NONE")] IapCategoryNone = 0,
    [pbr::OriginalName("IAP_CATEGORY_BUNDLE")] IapCategoryBundle = 1,
    [pbr::OriginalName("IAP_CATEGORY_ITEMS")] IapCategoryItems = 2,
    [pbr::OriginalName("IAP_CATEGORY_UPGRADES")] IapCategoryUpgrades = 3,
    [pbr::OriginalName("IAP_CATEGORY_POKECOINS")] IapCategoryPokecoins = 4,
    [pbr::OriginalName("IAP_CATEGORY_AVATAR")] IapCategoryAvatar = 5,
  }

  #endregion

}

#endregion Designer generated code
