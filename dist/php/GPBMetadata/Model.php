<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: model.proto

namespace GPBMetadata;

class Model
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        $pool->internalAddGeneratedFile(
            '
�	
model.protocrawlab_grpc"�
Task
_id (	
	spider_id (	
start_ts (	
	finish_ts (	
status (	
node_id (	
cmd (	
param	 (	
error
 (	
result_count (
error_log_count (

runtime_duration (
total_duration (
pid (
run_type (	
schedule_id (	
type (	
user_id (	
	create_ts (	
	update_ts (	"�
Spider
_id (	
name (	
display_name (	
type (	
col (	
envs (2.crawlab_grpc.Env
remark	 (	

project_id (	
	is_public (
cmd
	is_scrapy (
template (	
is_dedup (
dedup_field (	
dedup_method (	
is_web_hook (
web_hook_url (	
user_id (	
	create_ts (	
	update_ts (	"�
Node
_id (	
name (	
status (	

ip (	
port (	
mac (	
hostname (	
description (	
key	 (	,
settings
 (2.crawlab_grpc.NodeSettings
	is_master (
	update_ts (	
	create_ts
update_ts_unix (""
Env
name (	
value (	"#
NodeSettings
max_runners (BZ.;crawlab_grpcbproto3'
        , true);

        static::$is_initialized = true;
    }
}
