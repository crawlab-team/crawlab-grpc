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
        \GPBMetadata\Entity\Request::initOnce();
        \GPBMetadata\Entity\Response::initOnce();
        \GPBMetadata\Entity\StreamMessage::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
services/task_service.protogrpcentity/response.protoentity/stream_message.proto2�
TaskService.
GetTaskInfo.grpc.Request.grpc.Response" +
SaveItem.grpc.Request.grpc.Response" ,
	SaveItems.grpc.Request.grpc.Response" ,
	FetchTask.grpc.Request.grpc.Response" 4
	Subscribe.grpc.StreamMessage.grpc.Response" (BZ.;grpcbproto3'
        , true);

        static::$is_initialized = true;
    }
}

