<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: services/model_delegate.proto

namespace GPBMetadata\Services;

class ModelDelegate
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Entity\Request::initOnce();
        \GPBMetadata\Entity\Response::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
services/model_delegate.protogrpcentity/response.proto26
ModelDelegate%
Do.grpc.Request.grpc.Response" BZ.;grpcbproto3'
        , true);

        static::$is_initialized = true;
    }
}

