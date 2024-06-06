// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: entity/stream_message.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Grpc {

  /// <summary>Holder for reflection information generated from entity/stream_message.proto</summary>
  public static partial class StreamMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for entity/stream_message.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StreamMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtlbnRpdHkvc3RyZWFtX21lc3NhZ2UucHJvdG8SBGdycGMaIGVudGl0eS9z",
            "dHJlYW1fbWVzc2FnZV9jb2RlLnByb3RvIowBCg1TdHJlYW1NZXNzYWdlEiUK",
            "BGNvZGUYASABKA4yFy5ncnBjLlN0cmVhbU1lc3NhZ2VDb2RlEhAKCG5vZGVf",
            "a2V5GAIgASgJEgsKA2tleRgDIAEoCRIMCgRmcm9tGAQgASgJEgoKAnRvGAUg",
            "ASgJEgwKBGRhdGEYBiABKAwSDQoFZXJyb3IYByABKAlCCFoGLjtncnBjYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Grpc.StreamMessageCodeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Grpc.StreamMessage), global::Grpc.StreamMessage.Parser, new[]{ "Code", "NodeKey", "Key", "From", "To", "Data", "Error" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class StreamMessage : pb::IMessage<StreamMessage> {
    private static readonly pb::MessageParser<StreamMessage> _parser = new pb::MessageParser<StreamMessage>(() => new StreamMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StreamMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.StreamMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StreamMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StreamMessage(StreamMessage other) : this() {
      code_ = other.code_;
      nodeKey_ = other.nodeKey_;
      key_ = other.key_;
      from_ = other.from_;
      to_ = other.to_;
      data_ = other.data_;
      error_ = other.error_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StreamMessage Clone() {
      return new StreamMessage(this);
    }

    /// <summary>Field number for the "code" field.</summary>
    public const int CodeFieldNumber = 1;
    private global::Grpc.StreamMessageCode code_ = global::Grpc.StreamMessageCode.Ping;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Grpc.StreamMessageCode Code {
      get { return code_; }
      set {
        code_ = value;
      }
    }

    /// <summary>Field number for the "node_key" field.</summary>
    public const int NodeKeyFieldNumber = 2;
    private string nodeKey_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NodeKey {
      get { return nodeKey_; }
      set {
        nodeKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "key" field.</summary>
    public const int KeyFieldNumber = 3;
    private string key_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Key {
      get { return key_; }
      set {
        key_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "from" field.</summary>
    public const int FromFieldNumber = 4;
    private string from_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string From {
      get { return from_; }
      set {
        from_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "to" field.</summary>
    public const int ToFieldNumber = 5;
    private string to_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string To {
      get { return to_; }
      set {
        to_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 6;
    private pb::ByteString data_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Data {
      get { return data_; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "error" field.</summary>
    public const int ErrorFieldNumber = 7;
    private string error_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Error {
      get { return error_; }
      set {
        error_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StreamMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StreamMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Code != other.Code) return false;
      if (NodeKey != other.NodeKey) return false;
      if (Key != other.Key) return false;
      if (From != other.From) return false;
      if (To != other.To) return false;
      if (Data != other.Data) return false;
      if (Error != other.Error) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Code != global::Grpc.StreamMessageCode.Ping) hash ^= Code.GetHashCode();
      if (NodeKey.Length != 0) hash ^= NodeKey.GetHashCode();
      if (Key.Length != 0) hash ^= Key.GetHashCode();
      if (From.Length != 0) hash ^= From.GetHashCode();
      if (To.Length != 0) hash ^= To.GetHashCode();
      if (Data.Length != 0) hash ^= Data.GetHashCode();
      if (Error.Length != 0) hash ^= Error.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Code != global::Grpc.StreamMessageCode.Ping) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Code);
      }
      if (NodeKey.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NodeKey);
      }
      if (Key.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Key);
      }
      if (From.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(From);
      }
      if (To.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(To);
      }
      if (Data.Length != 0) {
        output.WriteRawTag(50);
        output.WriteBytes(Data);
      }
      if (Error.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Error);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Code != global::Grpc.StreamMessageCode.Ping) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Code);
      }
      if (NodeKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NodeKey);
      }
      if (Key.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Key);
      }
      if (From.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(From);
      }
      if (To.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(To);
      }
      if (Data.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Data);
      }
      if (Error.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Error);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StreamMessage other) {
      if (other == null) {
        return;
      }
      if (other.Code != global::Grpc.StreamMessageCode.Ping) {
        Code = other.Code;
      }
      if (other.NodeKey.Length != 0) {
        NodeKey = other.NodeKey;
      }
      if (other.Key.Length != 0) {
        Key = other.Key;
      }
      if (other.From.Length != 0) {
        From = other.From;
      }
      if (other.To.Length != 0) {
        To = other.To;
      }
      if (other.Data.Length != 0) {
        Data = other.Data;
      }
      if (other.Error.Length != 0) {
        Error = other.Error;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Code = (global::Grpc.StreamMessageCode) input.ReadEnum();
            break;
          }
          case 18: {
            NodeKey = input.ReadString();
            break;
          }
          case 26: {
            Key = input.ReadString();
            break;
          }
          case 34: {
            From = input.ReadString();
            break;
          }
          case 42: {
            To = input.ReadString();
            break;
          }
          case 50: {
            Data = input.ReadBytes();
            break;
          }
          case 58: {
            Error = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
