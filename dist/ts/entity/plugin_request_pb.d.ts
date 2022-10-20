// package: grpc
// file: entity/plugin_request.proto

import * as jspb from "google-protobuf";

export class PluginRequest extends jspb.Message {
  getName(): string;
  setName(value: string): void;

  getNodeKey(): string;
  setNodeKey(value: string): void;

  getData(): Uint8Array | string;
  getData_asU8(): Uint8Array;
  getData_asB64(): string;
  setData(value: Uint8Array | string): void;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): PluginRequest.AsObject;
  static toObject(includeInstance: boolean, msg: PluginRequest): PluginRequest.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: PluginRequest, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): PluginRequest;
  static deserializeBinaryFromReader(message: PluginRequest, reader: jspb.BinaryReader): PluginRequest;
}

export namespace PluginRequest {
  export type AsObject = {
    name: string,
    nodeKey: string,
    data: Uint8Array | string,
  }
}

