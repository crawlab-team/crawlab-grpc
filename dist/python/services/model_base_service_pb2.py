# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: services/model_base_service.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


from entity import request_pb2 as entity_dot_request__pb2
from entity import response_pb2 as entity_dot_response__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n!services/model_base_service.proto\x12\x04grpc\x1a\x14\x65ntity/request.proto\x1a\x15\x65ntity/response.proto2\xac\x04\n\x10ModelBaseService\x12*\n\x07GetById\x12\r.grpc.Request\x1a\x0e.grpc.Response\"\x00\x12&\n\x03Get\x12\r.grpc.Request\x1a\x0e.grpc.Response\"\x00\x12*\n\x07GetList\x12\r.grpc.Request\x1a\x0e.grpc.Response\"\x00\x12-\n\nDeleteById\x12\r.grpc.Request\x1a\x0e.grpc.Response\"\x00\x12)\n\x06\x44\x65lete\x12\r.grpc.Request\x1a\x0e.grpc.Response\"\x00\x12-\n\nDeleteList\x12\r.grpc.Request\x1a\x0e.grpc.Response\"\x00\x12\x32\n\x0f\x46orceDeleteList\x12\r.grpc.Request\x1a\x0e.grpc.Response\"\x00\x12-\n\nUpdateById\x12\r.grpc.Request\x1a\x0e.grpc.Response\"\x00\x12)\n\x06Update\x12\r.grpc.Request\x1a\x0e.grpc.Response\"\x00\x12,\n\tUpdateDoc\x12\r.grpc.Request\x1a\x0e.grpc.Response\"\x00\x12)\n\x06Insert\x12\r.grpc.Request\x1a\x0e.grpc.Response\"\x00\x12(\n\x05\x43ount\x12\r.grpc.Request\x1a\x0e.grpc.Response\"\x00\x42\x08Z\x06.;grpcb\x06proto3')

_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, globals())
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'services.model_base_service_pb2', globals())
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  DESCRIPTOR._serialized_options = b'Z\006.;grpc'
  _MODELBASESERVICE._serialized_start=89
  _MODELBASESERVICE._serialized_end=645
# @@protoc_insertion_point(module_scope)
