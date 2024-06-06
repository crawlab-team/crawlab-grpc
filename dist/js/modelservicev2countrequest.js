// source: entity/model_service_v2_request.proto
/**
 * @fileoverview
 * @enhanceable
 * @suppress {messageConventions} JS Compiler reports an error if a variable or
 *     field starts with 'MSG_' and isn't a translatable message.
 * @public
 */
// GENERATED CODE -- DO NOT EDIT!

goog.provide('proto.grpc.ModelServiceV2CountRequest');

goog.require('jspb.BinaryReader');
goog.require('jspb.BinaryWriter');
goog.require('jspb.Message');

/**
 * Generated by JsPbCodeGenerator.
 * @param {Array=} opt_data Optional initial data array, typically from a
 * server response, or constructed directly in Javascript. The array is used
 * in place and becomes part of the constructed object. It is not cloned.
 * If no data is provided, the constructed object will be empty, but still
 * valid.
 * @extends {jspb.Message}
 * @constructor
 */
proto.grpc.ModelServiceV2CountRequest = function(opt_data) {
  jspb.Message.initialize(this, opt_data, 0, -1, null, null);
};
goog.inherits(proto.grpc.ModelServiceV2CountRequest, jspb.Message);
if (goog.DEBUG && !COMPILED) {
  /**
   * @public
   * @override
   */
  proto.grpc.ModelServiceV2CountRequest.displayName = 'proto.grpc.ModelServiceV2CountRequest';
}



if (jspb.Message.GENERATE_TO_OBJECT) {
/**
 * Creates an object representation of this proto.
 * Field names that are reserved in JavaScript and will be renamed to pb_name.
 * Optional fields that are not set will be set to undefined.
 * To access a reserved field use, foo.pb_<name>, eg, foo.pb_default.
 * For the list of reserved names please see:
 *     net/proto2/compiler/js/internal/generator.cc#kKeyword.
 * @param {boolean=} opt_includeInstance Deprecated. whether to include the
 *     JSPB instance for transitional soy proto support:
 *     http://goto/soy-param-migration
 * @return {!Object}
 */
proto.grpc.ModelServiceV2CountRequest.prototype.toObject = function(opt_includeInstance) {
  return proto.grpc.ModelServiceV2CountRequest.toObject(opt_includeInstance, this);
};


/**
 * Static version of the {@see toObject} method.
 * @param {boolean|undefined} includeInstance Deprecated. Whether to include
 *     the JSPB instance for transitional soy proto support:
 *     http://goto/soy-param-migration
 * @param {!proto.grpc.ModelServiceV2CountRequest} msg The msg instance to transform.
 * @return {!Object}
 * @suppress {unusedLocalVariables} f is only used for nested messages
 */
proto.grpc.ModelServiceV2CountRequest.toObject = function(includeInstance, msg) {
  var f, obj = {
    nodeKey: jspb.Message.getFieldWithDefault(msg, 1, ""),
    modelType: jspb.Message.getFieldWithDefault(msg, 2, ""),
    query: msg.getQuery_asB64()
  };

  if (includeInstance) {
    obj.$jspbMessageInstance = msg;
  }
  return obj;
};
}


/**
 * Deserializes binary data (in protobuf wire format).
 * @param {jspb.ByteSource} bytes The bytes to deserialize.
 * @return {!proto.grpc.ModelServiceV2CountRequest}
 */
proto.grpc.ModelServiceV2CountRequest.deserializeBinary = function(bytes) {
  var reader = new jspb.BinaryReader(bytes);
  var msg = new proto.grpc.ModelServiceV2CountRequest;
  return proto.grpc.ModelServiceV2CountRequest.deserializeBinaryFromReader(msg, reader);
};


/**
 * Deserializes binary data (in protobuf wire format) from the
 * given reader into the given message object.
 * @param {!proto.grpc.ModelServiceV2CountRequest} msg The message object to deserialize into.
 * @param {!jspb.BinaryReader} reader The BinaryReader to use.
 * @return {!proto.grpc.ModelServiceV2CountRequest}
 */
proto.grpc.ModelServiceV2CountRequest.deserializeBinaryFromReader = function(msg, reader) {
  while (reader.nextField()) {
    if (reader.isEndGroup()) {
      break;
    }
    var field = reader.getFieldNumber();
    switch (field) {
    case 1:
      var value = /** @type {string} */ (reader.readString());
      msg.setNodeKey(value);
      break;
    case 2:
      var value = /** @type {string} */ (reader.readString());
      msg.setModelType(value);
      break;
    case 3:
      var value = /** @type {!Uint8Array} */ (reader.readBytes());
      msg.setQuery(value);
      break;
    default:
      reader.skipField();
      break;
    }
  }
  return msg;
};


/**
 * Serializes the message to binary data (in protobuf wire format).
 * @return {!Uint8Array}
 */
proto.grpc.ModelServiceV2CountRequest.prototype.serializeBinary = function() {
  var writer = new jspb.BinaryWriter();
  proto.grpc.ModelServiceV2CountRequest.serializeBinaryToWriter(this, writer);
  return writer.getResultBuffer();
};


/**
 * Serializes the given message to binary data (in protobuf wire
 * format), writing to the given BinaryWriter.
 * @param {!proto.grpc.ModelServiceV2CountRequest} message
 * @param {!jspb.BinaryWriter} writer
 * @suppress {unusedLocalVariables} f is only used for nested messages
 */
proto.grpc.ModelServiceV2CountRequest.serializeBinaryToWriter = function(message, writer) {
  var f = undefined;
  f = message.getNodeKey();
  if (f.length > 0) {
    writer.writeString(
      1,
      f
    );
  }
  f = message.getModelType();
  if (f.length > 0) {
    writer.writeString(
      2,
      f
    );
  }
  f = message.getQuery_asU8();
  if (f.length > 0) {
    writer.writeBytes(
      3,
      f
    );
  }
};


/**
 * optional string node_key = 1;
 * @return {string}
 */
proto.grpc.ModelServiceV2CountRequest.prototype.getNodeKey = function() {
  return /** @type {string} */ (jspb.Message.getFieldWithDefault(this, 1, ""));
};


/**
 * @param {string} value
 * @return {!proto.grpc.ModelServiceV2CountRequest} returns this
 */
proto.grpc.ModelServiceV2CountRequest.prototype.setNodeKey = function(value) {
  return jspb.Message.setProto3StringField(this, 1, value);
};


/**
 * optional string model_type = 2;
 * @return {string}
 */
proto.grpc.ModelServiceV2CountRequest.prototype.getModelType = function() {
  return /** @type {string} */ (jspb.Message.getFieldWithDefault(this, 2, ""));
};


/**
 * @param {string} value
 * @return {!proto.grpc.ModelServiceV2CountRequest} returns this
 */
proto.grpc.ModelServiceV2CountRequest.prototype.setModelType = function(value) {
  return jspb.Message.setProto3StringField(this, 2, value);
};


/**
 * optional bytes query = 3;
 * @return {string}
 */
proto.grpc.ModelServiceV2CountRequest.prototype.getQuery = function() {
  return /** @type {string} */ (jspb.Message.getFieldWithDefault(this, 3, ""));
};


/**
 * optional bytes query = 3;
 * This is a type-conversion wrapper around `getQuery()`
 * @return {string}
 */
proto.grpc.ModelServiceV2CountRequest.prototype.getQuery_asB64 = function() {
  return /** @type {string} */ (jspb.Message.bytesAsB64(
      this.getQuery()));
};


/**
 * optional bytes query = 3;
 * Note that Uint8Array is not supported on all browsers.
 * @see http://caniuse.com/Uint8Array
 * This is a type-conversion wrapper around `getQuery()`
 * @return {!Uint8Array}
 */
proto.grpc.ModelServiceV2CountRequest.prototype.getQuery_asU8 = function() {
  return /** @type {!Uint8Array} */ (jspb.Message.bytesAsU8(
      this.getQuery()));
};


/**
 * @param {!(string|Uint8Array)} value
 * @return {!proto.grpc.ModelServiceV2CountRequest} returns this
 */
proto.grpc.ModelServiceV2CountRequest.prototype.setQuery = function(value) {
  return jspb.Message.setProto3BytesField(this, 3, value);
};


