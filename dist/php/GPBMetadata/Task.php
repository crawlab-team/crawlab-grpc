<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: task.proto

namespace GPBMetadata;

class Task
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        $pool->internalAddGeneratedFile(
            '
�

task.proto"3
TaskServiceRequest
task_id (	
data (	"D
TaskServiceResponse
status (	
message (	
data (	2�
TaskService6
GetTask.TaskServiceRequest.TaskServiceResponse" 8
	GetSpider.TaskServiceRequest.TaskServiceResponse" 6
GetNode.TaskServiceRequest.TaskServiceResponse" 7
SaveItem.TaskServiceRequest.TaskServiceResponse" BZ.;crawlab_grpcbproto3'
        , true);

        static::$is_initialized = true;
    }
}

