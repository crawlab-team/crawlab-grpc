<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: entity/stream_message_code.proto

namespace GPBMetadata\Entity;

class StreamMessageCode
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        $pool->internalAddGeneratedFile(
            '
�
 entity/stream_message_code.protogrpc*�
StreamMessageCode
PING 
RUN_TASK
CANCEL_TASK
INSERT_DATA
INSERT_LOGS

SEND_EVENT
INSTALL_PLUGIN
UNINSTALL_PLUGIN
START_PLUGIN
STOP_PLUGIN	
CONNECT


DISCONNECT
SENDBZ.;grpcbproto3'
        , true);

        static::$is_initialized = true;
    }
}

