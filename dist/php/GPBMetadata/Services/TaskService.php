<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: services/task_service.proto

namespace GPBMetadata\Services;

class TaskService
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Entity\Response::initOnce();
        \GPBMetadata\Entity\StreamMessage::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
services/task_service.protogrpcentity/stream_message.proto2C
TaskService4
	Subscribe.grpc.StreamMessage.grpc.Response" (BZ.;grpcbproto3'
        , true);

        static::$is_initialized = true;
    }
}

