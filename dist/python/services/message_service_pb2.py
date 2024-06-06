# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: services/message_service.proto

from google.protobuf import descriptor as _descriptor
from google.protobuf import message as _message
from google.protobuf import reflection as _reflection
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


from entity import stream_message_pb2 as entity_dot_stream__message__pb2


DESCRIPTOR = _descriptor.FileDescriptor(
  name='services/message_service.proto',
  package='grpc',
  syntax='proto3',
  serialized_options=b'Z\006.;grpc',
  create_key=_descriptor._internal_create_key,
  serialized_pb=b'\n\x1eservices/message_service.proto\x12\x04grpc\x1a\x1b\x65ntity/stream_message.proto2K\n\x0eMessageService\x12\x39\n\x07\x43onnect\x12\x13.grpc.StreamMessage\x1a\x13.grpc.StreamMessage\"\x00(\x01\x30\x01\x42\x08Z\x06.;grpcb\x06proto3'
  ,
  dependencies=[entity_dot_stream__message__pb2.DESCRIPTOR,])



_sym_db.RegisterFileDescriptor(DESCRIPTOR)


DESCRIPTOR._options = None

_MESSAGESERVICE = _descriptor.ServiceDescriptor(
  name='MessageService',
  full_name='grpc.MessageService',
  file=DESCRIPTOR,
  index=0,
  serialized_options=None,
  create_key=_descriptor._internal_create_key,
  serialized_start=69,
  serialized_end=144,
  methods=[
  _descriptor.MethodDescriptor(
    name='Connect',
    full_name='grpc.MessageService.Connect',
    index=0,
    containing_service=None,
    input_type=entity_dot_stream__message__pb2._STREAMMESSAGE,
    output_type=entity_dot_stream__message__pb2._STREAMMESSAGE,
    serialized_options=None,
    create_key=_descriptor._internal_create_key,
  ),
])
_sym_db.RegisterServiceDescriptor(_MESSAGESERVICE)

DESCRIPTOR.services_by_name['MessageService'] = _MESSAGESERVICE

# @@protoc_insertion_point(module_scope)
