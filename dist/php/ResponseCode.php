<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: code.proto

/**
 * Protobuf type <code>ResponseCode</code>
 */
class ResponseCode
{
    /**
     * Generated from protobuf enum <code>OK = 0;</code>
     */
    const OK = 0;
    /**
     * Generated from protobuf enum <code>ERROR = 1;</code>
     */
    const ERROR = 1;

    private static $valueToName = [
        self::OK => 'OK',
        self::ERROR => 'ERROR',
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
