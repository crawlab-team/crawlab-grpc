// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: entity/stream_message_code.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Grpc {

  /// <summary>Holder for reflection information generated from entity/stream_message_code.proto</summary>
  public static partial class StreamMessageCodeReflection {

    #region Descriptor
    /// <summary>File descriptor for entity/stream_message_code.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StreamMessageCodeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBlbnRpdHkvc3RyZWFtX21lc3NhZ2VfY29kZS5wcm90bxIEZ3JwYypeChFT",
            "dHJlYW1NZXNzYWdlQ29kZRIICgRQSU5HEAASDAoIUlVOX1RBU0sQARIPCgtD",
            "QU5DRUxfVEFTSxACEg8KC0lOU0VSVF9EQVRBEAMSDwoLSU5TRVJUX0xPR1MQ",
            "BEIIWgYuO2dycGNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Grpc.StreamMessageCode), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum StreamMessageCode {
    /// <summary>
    /// ping worker nodes to check their health
    /// </summary>
    [pbr::OriginalName("PING")] Ping = 0,
    /// <summary>
    /// ask worker node(s) to run task with given id
    /// </summary>
    [pbr::OriginalName("RUN_TASK")] RunTask = 1,
    /// <summary>
    /// ask worker node(s) to cancel task with given id
    /// </summary>
    [pbr::OriginalName("CANCEL_TASK")] CancelTask = 2,
    /// <summary>
    /// insert data
    /// </summary>
    [pbr::OriginalName("INSERT_DATA")] InsertData = 3,
    /// <summary>
    /// insert logs
    /// </summary>
    [pbr::OriginalName("INSERT_LOGS")] InsertLogs = 4,
  }

  #endregion

}

#endregion Designer generated code
