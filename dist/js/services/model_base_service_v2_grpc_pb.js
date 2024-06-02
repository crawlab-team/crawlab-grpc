// GENERATED CODE -- DO NOT EDIT!

'use strict';
var grpc = require('@grpc/grpc-js');
var entity_request_pb = require('../entity/request_pb.js');
var entity_response_pb = require('../entity/response_pb.js');

function serialize_grpc_Request(arg) {
  if (!(arg instanceof entity_request_pb.Request)) {
    throw new Error('Expected argument of type grpc.Request');
  }
  return Buffer.from(arg.serializeBinary());
}

function deserialize_grpc_Request(buffer_arg) {
  return entity_request_pb.Request.deserializeBinary(new Uint8Array(buffer_arg));
}

function serialize_grpc_Response(arg) {
  if (!(arg instanceof entity_response_pb.Response)) {
    throw new Error('Expected argument of type grpc.Response');
  }
  return Buffer.from(arg.serializeBinary());
}

function deserialize_grpc_Response(buffer_arg) {
  return entity_response_pb.Response.deserializeBinary(new Uint8Array(buffer_arg));
}


var ModelBaseServiceV2Service = exports.ModelBaseServiceV2Service = {
  getById: {
    path: '/grpc.ModelBaseServiceV2/GetById',
    requestStream: false,
    responseStream: false,
    requestType: entity_request_pb.Request,
    responseType: entity_response_pb.Response,
    requestSerialize: serialize_grpc_Request,
    requestDeserialize: deserialize_grpc_Request,
    responseSerialize: serialize_grpc_Response,
    responseDeserialize: deserialize_grpc_Response,
  },
  get: {
    path: '/grpc.ModelBaseServiceV2/Get',
    requestStream: false,
    responseStream: false,
    requestType: entity_request_pb.Request,
    responseType: entity_response_pb.Response,
    requestSerialize: serialize_grpc_Request,
    requestDeserialize: deserialize_grpc_Request,
    responseSerialize: serialize_grpc_Response,
    responseDeserialize: deserialize_grpc_Response,
  },
  getList: {
    path: '/grpc.ModelBaseServiceV2/GetList',
    requestStream: false,
    responseStream: false,
    requestType: entity_request_pb.Request,
    responseType: entity_response_pb.Response,
    requestSerialize: serialize_grpc_Request,
    requestDeserialize: deserialize_grpc_Request,
    responseSerialize: serialize_grpc_Response,
    responseDeserialize: deserialize_grpc_Response,
  },
  deleteById: {
    path: '/grpc.ModelBaseServiceV2/DeleteById',
    requestStream: false,
    responseStream: false,
    requestType: entity_request_pb.Request,
    responseType: entity_response_pb.Response,
    requestSerialize: serialize_grpc_Request,
    requestDeserialize: deserialize_grpc_Request,
    responseSerialize: serialize_grpc_Response,
    responseDeserialize: deserialize_grpc_Response,
  },
  deleteList: {
    path: '/grpc.ModelBaseServiceV2/DeleteList',
    requestStream: false,
    responseStream: false,
    requestType: entity_request_pb.Request,
    responseType: entity_response_pb.Response,
    requestSerialize: serialize_grpc_Request,
    requestDeserialize: deserialize_grpc_Request,
    responseSerialize: serialize_grpc_Response,
    responseDeserialize: deserialize_grpc_Response,
  },
  updateById: {
    path: '/grpc.ModelBaseServiceV2/UpdateById',
    requestStream: false,
    responseStream: false,
    requestType: entity_request_pb.Request,
    responseType: entity_response_pb.Response,
    requestSerialize: serialize_grpc_Request,
    requestDeserialize: deserialize_grpc_Request,
    responseSerialize: serialize_grpc_Response,
    responseDeserialize: deserialize_grpc_Response,
  },
  updateOne: {
    path: '/grpc.ModelBaseServiceV2/UpdateOne',
    requestStream: false,
    responseStream: false,
    requestType: entity_request_pb.Request,
    responseType: entity_response_pb.Response,
    requestSerialize: serialize_grpc_Request,
    requestDeserialize: deserialize_grpc_Request,
    responseSerialize: serialize_grpc_Response,
    responseDeserialize: deserialize_grpc_Response,
  },
  updateMany: {
    path: '/grpc.ModelBaseServiceV2/UpdateMany',
    requestStream: false,
    responseStream: false,
    requestType: entity_request_pb.Request,
    responseType: entity_response_pb.Response,
    requestSerialize: serialize_grpc_Request,
    requestDeserialize: deserialize_grpc_Request,
    responseSerialize: serialize_grpc_Response,
    responseDeserialize: deserialize_grpc_Response,
  },
  replaceById: {
    path: '/grpc.ModelBaseServiceV2/ReplaceById',
    requestStream: false,
    responseStream: false,
    requestType: entity_request_pb.Request,
    responseType: entity_response_pb.Response,
    requestSerialize: serialize_grpc_Request,
    requestDeserialize: deserialize_grpc_Request,
    responseSerialize: serialize_grpc_Response,
    responseDeserialize: deserialize_grpc_Response,
  },
  replace: {
    path: '/grpc.ModelBaseServiceV2/Replace',
    requestStream: false,
    responseStream: false,
    requestType: entity_request_pb.Request,
    responseType: entity_response_pb.Response,
    requestSerialize: serialize_grpc_Request,
    requestDeserialize: deserialize_grpc_Request,
    responseSerialize: serialize_grpc_Response,
    responseDeserialize: deserialize_grpc_Response,
  },
  insertOne: {
    path: '/grpc.ModelBaseServiceV2/InsertOne',
    requestStream: false,
    responseStream: false,
    requestType: entity_request_pb.Request,
    responseType: entity_response_pb.Response,
    requestSerialize: serialize_grpc_Request,
    requestDeserialize: deserialize_grpc_Request,
    responseSerialize: serialize_grpc_Response,
    responseDeserialize: deserialize_grpc_Response,
  },
  insertMany: {
    path: '/grpc.ModelBaseServiceV2/InsertMany',
    requestStream: false,
    responseStream: false,
    requestType: entity_request_pb.Request,
    responseType: entity_response_pb.Response,
    requestSerialize: serialize_grpc_Request,
    requestDeserialize: deserialize_grpc_Request,
    responseSerialize: serialize_grpc_Response,
    responseDeserialize: deserialize_grpc_Response,
  },
  count: {
    path: '/grpc.ModelBaseServiceV2/Count',
    requestStream: false,
    responseStream: false,
    requestType: entity_request_pb.Request,
    responseType: entity_response_pb.Response,
    requestSerialize: serialize_grpc_Request,
    requestDeserialize: deserialize_grpc_Request,
    responseSerialize: serialize_grpc_Response,
    responseDeserialize: deserialize_grpc_Response,
  },
};

exports.ModelBaseServiceV2Client = grpc.makeGenericClientConstructor(ModelBaseServiceV2Service);
