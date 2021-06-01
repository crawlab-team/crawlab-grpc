<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: entity/stream_message_code.proto

namespace Grpc;

use UnexpectedValueException;

/**
 * Protobuf type <code>grpc.StreamMessageCode</code>
 */
class StreamMessageCode
{
    /**
     * ping worker nodes to check their health
     *
     * Generated from protobuf enum <code>PING = 0;</code>
     */
    const PING = 0;
    /**
     * ask worker node(s) to run task with given id
     *
     * Generated from protobuf enum <code>RUN_TASK = 1;</code>
     */
    const RUN_TASK = 1;
    /**
     * ask worker node(s) to cancel task with given id
     *
     * Generated from protobuf enum <code>CANCEL_TASK = 2;</code>
     */
    const CANCEL_TASK = 2;
    /**
     * insert data
     *
     * Generated from protobuf enum <code>INSERT_DATA = 3;</code>
     */
    const INSERT_DATA = 3;
    /**
     * insert logs
     *
     * Generated from protobuf enum <code>INSERT_LOGS = 4;</code>
     */
    const INSERT_LOGS = 4;

    private static $valueToName = [
        self::PING => 'PING',
        self::RUN_TASK => 'RUN_TASK',
        self::CANCEL_TASK => 'CANCEL_TASK',
        self::INSERT_DATA => 'INSERT_DATA',
        self::INSERT_LOGS => 'INSERT_LOGS',
    ];

    public static function name($value)
    {
        if (!isset(self::$valueToName[$value])) {
            throw new UnexpectedValueException(sprintf(
                    'Enum %s has no name defined for value %s', __CLASS__, $value));
        }
        return self::$valueToName[$value];
    }


    public static function value($name)
    {
        $const = __CLASS__ . '::' . strtoupper($name);
        if (!defined($const)) {
            throw new UnexpectedValueException(sprintf(
                    'Enum %s has no value defined for name %s', __CLASS__, $name));
        }
        return constant($const);
    }
}

