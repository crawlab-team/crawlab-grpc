<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: services/node_service.proto

namespace GPBMetadata\Services;

class NodeService
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Entity\Request::initOnce();
        \GPBMetadata\Entity\Response::initOnce();
        \GPBMetadata\Entity\StreamMessage::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
services/node_service.protogrpcentity/response.protoentity/stream_message.proto2�
NodeService+
Register.grpc.Request.grpc.Response" 0
SendHeartbeat.grpc.Request.grpc.Response" \'
Ping.grpc.Request.grpc.Response" 3
	Subscribe.grpc.Request.grpc.StreamMessage" 0.
Unsubscribe.grpc.Request.grpc.Response" BZ.;grpcbproto3'
        , true);

        static::$is_initialized = true;
    }
}

