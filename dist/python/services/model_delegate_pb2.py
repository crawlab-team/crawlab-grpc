# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: services/model_delegate.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


from entity import request_pb2 as entity_dot_request__pb2
from entity import response_pb2 as entity_dot_response__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n\x1dservices/model_delegate.proto\x12\x04grpc\x1a\x14\x65ntity/request.proto\x1a\x15\x65ntity/response.proto26\n\rModelDelegate\x12%\n\x02\x44o\x12\r.grpc.Request\x1a\x0e.grpc.Response\"\x00\x42\x08Z\x06.;grpcb\x06proto3')

_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, globals())
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'services.model_delegate_pb2', globals())
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  DESCRIPTOR._serialized_options = b'Z\006.;grpc'
  _MODELDELEGATE._serialized_start=84
  _MODELDELEGATE._serialized_end=138
# @@protoc_insertion_point(module_scope)
