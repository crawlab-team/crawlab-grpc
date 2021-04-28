# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: node.proto
"""Generated protocol buffer code."""
from google.protobuf import descriptor as _descriptor
from google.protobuf import message as _message
from google.protobuf import reflection as _reflection
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import response_pb2 as response__pb2


DESCRIPTOR = _descriptor.FileDescriptor(
  name='node.proto',
  package='grpc',
  syntax='proto3',
  serialized_options=b'Z\006.;grpc',
  create_key=_descriptor._internal_create_key,
  serialized_pb=b'\n\nnode.proto\x12\x04grpc\x1a\x0eresponse.proto2c\n\x0bNodeService\x12+\n\x08Register\x12\r.grpc.Request\x1a\x0e.grpc.Response\"\x00\x12\'\n\x04Ping\x12\r.grpc.Request\x1a\x0e.grpc.Response\"\x00\x42\x08Z\x06.;grpcb\x06proto3'
  ,
  dependencies=[response__pb2.DESCRIPTOR,])



_sym_db.RegisterFileDescriptor(DESCRIPTOR)


DESCRIPTOR._options = None

_NODESERVICE = _descriptor.ServiceDescriptor(
  name='NodeService',
  full_name='grpc.NodeService',
  file=DESCRIPTOR,
  index=0,
  serialized_options=None,
  create_key=_descriptor._internal_create_key,
  serialized_start=36,
  serialized_end=135,
  methods=[
  _descriptor.MethodDescriptor(
    name='Register',
    full_name='grpc.NodeService.Register',
    index=0,
    containing_service=None,
    input_type=response__pb2._REQUEST,
    output_type=response__pb2._RESPONSE,
    serialized_options=None,
    create_key=_descriptor._internal_create_key,
  ),
  _descriptor.MethodDescriptor(
    name='Ping',
    full_name='grpc.NodeService.Ping',
    index=1,
    containing_service=None,
    input_type=response__pb2._REQUEST,
    output_type=response__pb2._RESPONSE,
    serialized_options=None,
    create_key=_descriptor._internal_create_key,
  ),
])
_sym_db.RegisterServiceDescriptor(_NODESERVICE)

DESCRIPTOR.services_by_name['NodeService'] = _NODESERVICE

# @@protoc_insertion_point(module_scope)
