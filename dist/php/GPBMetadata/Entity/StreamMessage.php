<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: entity/stream_message.proto

namespace GPBMetadata\Entity;

class StreamMessage
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Entity\StreamMessageCode::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
entity/stream_message.protogrpc"�
StreamMessage%
code (2.grpc.StreamMessageCode
node_key (	
key (	
from (	

to (	
data (
error (	BZ.;grpcbproto3'
        , true);

        static::$is_initialized = true;
    }
}

