<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: model.proto

namespace Crawlab_grpc;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Generated from protobuf message <code>crawlab_grpc.NodeSettings</code>
 */
class NodeSettings extends \Google\Protobuf\Internal\Message
{
    /**
     * Generated from protobuf field <code>int32 max_runners = 1;</code>
     */
    protected $max_runners = 0;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type int $max_runners
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Model::initOnce();
        parent::__construct($data);
    }

    /**
     * Generated from protobuf field <code>int32 max_runners = 1;</code>
     * @return int
     */
    public function getMaxRunners()
    {
        return $this->max_runners;
    }

    /**
     * Generated from protobuf field <code>int32 max_runners = 1;</code>
     * @param int $var
     * @return $this
     */
    public function setMaxRunners($var)
    {
        GPBUtil::checkInt32($var);
        $this->max_runners = $var;

        return $this;
    }

}
