# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: entity/node_info.proto
"""Generated protocol buffer code."""
from google.protobuf import descriptor as _descriptor
from google.protobuf import message as _message
from google.protobuf import reflection as _reflection
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()




DESCRIPTOR = _descriptor.FileDescriptor(
  name='entity/node_info.proto',
  package='grpc',
  syntax='proto3',
  serialized_options=b'Z\006.;grpc',
  create_key=_descriptor._internal_create_key,
  serialized_pb=b'\n\x16\x65ntity/node_info.proto\x12\x04grpc\"*\n\x08NodeInfo\x12\x0b\n\x03key\x18\x01 \x01(\t\x12\x11\n\tis_master\x18\x02 \x01(\x08\x42\x08Z\x06.;grpcb\x06proto3'
)




_NODEINFO = _descriptor.Descriptor(
  name='NodeInfo',
  full_name='grpc.NodeInfo',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  create_key=_descriptor._internal_create_key,
  fields=[
    _descriptor.FieldDescriptor(
      name='key', full_name='grpc.NodeInfo.key', index=0,
      number=1, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=b"".decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='is_master', full_name='grpc.NodeInfo.is_master', index=1,
      number=2, type=8, cpp_type=7, label=1,
      has_default_value=False, default_value=False,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=32,
  serialized_end=74,
)

DESCRIPTOR.message_types_by_name['NodeInfo'] = _NODEINFO
_sym_db.RegisterFileDescriptor(DESCRIPTOR)

NodeInfo = _reflection.GeneratedProtocolMessageType('NodeInfo', (_message.Message,), {
  'DESCRIPTOR' : _NODEINFO,
  '__module__' : 'entity.node_info_pb2'
  # @@protoc_insertion_point(class_scope:grpc.NodeInfo)
  })
_sym_db.RegisterMessage(NodeInfo)


DESCRIPTOR._options = None
# @@protoc_insertion_point(module_scope)
