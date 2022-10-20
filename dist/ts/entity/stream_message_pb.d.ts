// package: grpc
// file: entity/stream_message.proto

import * as jspb from "google-protobuf";
import * as entity_stream_message_code_pb from "../entity/stream_message_code_pb";

export class StreamMessage extends jspb.Message {
  getCode(): entity_stream_message_code_pb.StreamMessageCodeMap[keyof entity_stream_message_code_pb.StreamMessageCodeMap];
  setCode(value: entity_stream_message_code_pb.StreamMessageCodeMap[keyof entity_stream_message_code_pb.StreamMessageCodeMap]): void;

  getNodeKey(): string;
  setNodeKey(value: string): void;

  getKey(): string;
  setKey(value: string): void;

  getFrom(): string;
  setFrom(value: string): void;

  getTo(): string;
  setTo(value: string): void;

  getData(): Uint8Array | string;
  getData_asU8(): Uint8Array;
  getData_asB64(): string;
  setData(value: Uint8Array | string): void;

  getError(): string;
  setError(value: string): void;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): StreamMessage.AsObject;
  static toObject(includeInstance: boolean, msg: StreamMessage): StreamMessage.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: StreamMessage, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): StreamMessage;
  static deserializeBinaryFromReader(message: StreamMessage, reader: jspb.BinaryReader): StreamMessage;
}

export namespace StreamMessage {
  export type AsObject = {
    code: entity_stream_message_code_pb.StreamMessageCodeMap[keyof entity_stream_message_code_pb.StreamMessageCodeMap],
    nodeKey: string,
    key: string,
    from: string,
    to: string,
    data: Uint8Array | string,
    error: string,
  }
}

