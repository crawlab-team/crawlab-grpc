<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: entity/response.proto

namespace GPBMetadata\Entity;

class Response
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Entity\ResponseCode::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
entity/response.protogrpc"d
Response
code (2.ResponseCode
message (	
data (
error (	
total (BZ.;grpcbproto3'
        , true);

        static::$is_initialized = true;
    }
}

