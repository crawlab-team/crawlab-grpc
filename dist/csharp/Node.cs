// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: models/node.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Grpc {

  /// <summary>Holder for reflection information generated from models/node.proto</summary>
  public static partial class NodeReflection {

    #region Descriptor
    /// <summary>File descriptor for models/node.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NodeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFtb2RlbHMvbm9kZS5wcm90bxIEZ3JwYyLNAQoETm9kZRILCgNfaWQYASAB",
            "KAkSDAoEbmFtZRgCIAEoCRIKCgJpcBgDIAEoCRIMCgRwb3J0GAUgASgJEgsK",
            "A21hYxgGIAEoCRIQCghob3N0bmFtZRgHIAEoCRITCgtkZXNjcmlwdGlvbhgI",
            "IAEoCRILCgNrZXkYCSABKAkSEQoJaXNfbWFzdGVyGAsgASgIEhEKCXVwZGF0",
            "ZV90cxgMIAEoCRIRCgljcmVhdGVfdHMYDSABKAkSFgoOdXBkYXRlX3RzX3Vu",
            "aXgYDiABKANCCFoGLjtncnBjYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Grpc.Node), global::Grpc.Node.Parser, new[]{ "Id", "Name", "Ip", "Port", "Mac", "Hostname", "Description", "Key", "IsMaster", "UpdateTs", "CreateTs", "UpdateTsUnix" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Node : pb::IMessage<Node>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Node> _parser = new pb::MessageParser<Node>(() => new Node());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Node> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.NodeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Node() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Node(Node other) : this() {
      Id_ = other.Id_;
      name_ = other.name_;
      ip_ = other.ip_;
      port_ = other.port_;
      mac_ = other.mac_;
      hostname_ = other.hostname_;
      description_ = other.description_;
      key_ = other.key_;
      isMaster_ = other.isMaster_;
      updateTs_ = other.updateTs_;
      createTs_ = other.createTs_;
      updateTsUnix_ = other.updateTsUnix_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Node Clone() {
      return new Node(this);
    }

    /// <summary>Field number for the "_id" field.</summary>
    public const int IdFieldNumber = 1;
    private string Id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Id {
      get { return Id_; }
      set {
        Id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ip" field.</summary>
    public const int IpFieldNumber = 3;
    private string ip_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Ip {
      get { return ip_; }
      set {
        ip_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "port" field.</summary>
    public const int PortFieldNumber = 5;
    private string port_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Port {
      get { return port_; }
      set {
        port_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "mac" field.</summary>
    public const int MacFieldNumber = 6;
    private string mac_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Mac {
      get { return mac_; }
      set {
        mac_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "hostname" field.</summary>
    public const int HostnameFieldNumber = 7;
    private string hostname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Hostname {
      get { return hostname_; }
      set {
        hostname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 8;
    private string description_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "key" field.</summary>
    public const int KeyFieldNumber = 9;
    private string key_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Key {
      get { return key_; }
      set {
        key_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "is_master" field.</summary>
    public const int IsMasterFieldNumber = 11;
    private bool isMaster_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsMaster {
      get { return isMaster_; }
      set {
        isMaster_ = value;
      }
    }

    /// <summary>Field number for the "update_ts" field.</summary>
    public const int UpdateTsFieldNumber = 12;
    private string updateTs_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string UpdateTs {
      get { return updateTs_; }
      set {
        updateTs_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "create_ts" field.</summary>
    public const int CreateTsFieldNumber = 13;
    private string createTs_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CreateTs {
      get { return createTs_; }
      set {
        createTs_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "update_ts_unix" field.</summary>
    public const int UpdateTsUnixFieldNumber = 14;
    private long updateTsUnix_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long UpdateTsUnix {
      get { return updateTsUnix_; }
      set {
        updateTsUnix_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Node);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Node other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (Ip != other.Ip) return false;
      if (Port != other.Port) return false;
      if (Mac != other.Mac) return false;
      if (Hostname != other.Hostname) return false;
      if (Description != other.Description) return false;
      if (Key != other.Key) return false;
      if (IsMaster != other.IsMaster) return false;
      if (UpdateTs != other.UpdateTs) return false;
      if (CreateTs != other.CreateTs) return false;
      if (UpdateTsUnix != other.UpdateTsUnix) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Ip.Length != 0) hash ^= Ip.GetHashCode();
      if (Port.Length != 0) hash ^= Port.GetHashCode();
      if (Mac.Length != 0) hash ^= Mac.GetHashCode();
      if (Hostname.Length != 0) hash ^= Hostname.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (Key.Length != 0) hash ^= Key.GetHashCode();
      if (IsMaster != false) hash ^= IsMaster.GetHashCode();
      if (UpdateTs.Length != 0) hash ^= UpdateTs.GetHashCode();
      if (CreateTs.Length != 0) hash ^= CreateTs.GetHashCode();
      if (UpdateTsUnix != 0L) hash ^= UpdateTsUnix.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Ip.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Ip);
      }
      if (Port.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Port);
      }
      if (Mac.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Mac);
      }
      if (Hostname.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Hostname);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Description);
      }
      if (Key.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Key);
      }
      if (IsMaster != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsMaster);
      }
      if (UpdateTs.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(UpdateTs);
      }
      if (CreateTs.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(CreateTs);
      }
      if (UpdateTsUnix != 0L) {
        output.WriteRawTag(112);
        output.WriteInt64(UpdateTsUnix);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Ip.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Ip);
      }
      if (Port.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Port);
      }
      if (Mac.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Mac);
      }
      if (Hostname.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Hostname);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Description);
      }
      if (Key.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Key);
      }
      if (IsMaster != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsMaster);
      }
      if (UpdateTs.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(UpdateTs);
      }
      if (CreateTs.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(CreateTs);
      }
      if (UpdateTsUnix != 0L) {
        output.WriteRawTag(112);
        output.WriteInt64(UpdateTsUnix);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Ip.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Ip);
      }
      if (Port.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Port);
      }
      if (Mac.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Mac);
      }
      if (Hostname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Hostname);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (Key.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Key);
      }
      if (IsMaster != false) {
        size += 1 + 1;
      }
      if (UpdateTs.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UpdateTs);
      }
      if (CreateTs.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CreateTs);
      }
      if (UpdateTsUnix != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(UpdateTsUnix);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Node other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Ip.Length != 0) {
        Ip = other.Ip;
      }
      if (other.Port.Length != 0) {
        Port = other.Port;
      }
      if (other.Mac.Length != 0) {
        Mac = other.Mac;
      }
      if (other.Hostname.Length != 0) {
        Hostname = other.Hostname;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.Key.Length != 0) {
        Key = other.Key;
      }
      if (other.IsMaster != false) {
        IsMaster = other.IsMaster;
      }
      if (other.UpdateTs.Length != 0) {
        UpdateTs = other.UpdateTs;
      }
      if (other.CreateTs.Length != 0) {
        CreateTs = other.CreateTs;
      }
      if (other.UpdateTsUnix != 0L) {
        UpdateTsUnix = other.UpdateTsUnix;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            Ip = input.ReadString();
            break;
          }
          case 42: {
            Port = input.ReadString();
            break;
          }
          case 50: {
            Mac = input.ReadString();
            break;
          }
          case 58: {
            Hostname = input.ReadString();
            break;
          }
          case 66: {
            Description = input.ReadString();
            break;
          }
          case 74: {
            Key = input.ReadString();
            break;
          }
          case 88: {
            IsMaster = input.ReadBool();
            break;
          }
          case 98: {
            UpdateTs = input.ReadString();
            break;
          }
          case 106: {
            CreateTs = input.ReadString();
            break;
          }
          case 112: {
            UpdateTsUnix = input.ReadInt64();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            Ip = input.ReadString();
            break;
          }
          case 42: {
            Port = input.ReadString();
            break;
          }
          case 50: {
            Mac = input.ReadString();
            break;
          }
          case 58: {
            Hostname = input.ReadString();
            break;
          }
          case 66: {
            Description = input.ReadString();
            break;
          }
          case 74: {
            Key = input.ReadString();
            break;
          }
          case 88: {
            IsMaster = input.ReadBool();
            break;
          }
          case 98: {
            UpdateTs = input.ReadString();
            break;
          }
          case 106: {
            CreateTs = input.ReadString();
            break;
          }
          case 112: {
            UpdateTsUnix = input.ReadInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
