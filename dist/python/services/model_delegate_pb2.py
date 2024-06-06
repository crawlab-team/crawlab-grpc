# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: services/model_delegate.proto

from google.protobuf import descriptor as _descriptor
from google.protobuf import message as _message
from google.protobuf import reflection as _reflection
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


from entity import request_pb2 as entity_dot_request__pb2
from entity import response_pb2 as entity_dot_response__pb2


DESCRIPTOR = _descriptor.FileDescriptor(
  name='services/model_delegate.proto',
  package='grpc',
  syntax='proto3',
  serialized_options=b'Z\006.;grpc',
  create_key=_descriptor._internal_create_key,
  serialized_pb=b'\n\x1dservices/model_delegate.proto\x12\x04grpc\x1a\x14\x65ntity/request.proto\x1a\x15\x65ntity/response.proto26\n\rModelDelegate\x12%\n\x02\x44o\x12\r.grpc.Request\x1a\x0e.grpc.Response\"\x00\x42\x08Z\x06.;grpcb\x06proto3'
  ,
  dependencies=[entity_dot_request__pb2.DESCRIPTOR,entity_dot_response__pb2.DESCRIPTOR,])



_sym_db.RegisterFileDescriptor(DESCRIPTOR)


DESCRIPTOR._options = None

_MODELDELEGATE = _descriptor.ServiceDescriptor(
  name='ModelDelegate',
  full_name='grpc.ModelDelegate',
  file=DESCRIPTOR,
  index=0,
  serialized_options=None,
  create_key=_descriptor._internal_create_key,
  serialized_start=84,
  serialized_end=138,
  methods=[
  _descriptor.MethodDescriptor(
    name='Do',
    full_name='grpc.ModelDelegate.Do',
    index=0,
    containing_service=None,
    input_type=entity_dot_request__pb2._REQUEST,
    output_type=entity_dot_response__pb2._RESPONSE,
    serialized_options=None,
    create_key=_descriptor._internal_create_key,
  ),
])
_sym_db.RegisterServiceDescriptor(_MODELDELEGATE)

DESCRIPTOR.services_by_name['ModelDelegate'] = _MODELDELEGATE

# @@protoc_insertion_point(module_scope)
