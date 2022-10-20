// package: grpc
// file: entity/node_info.proto

import * as jspb from "google-protobuf";

export class NodeInfo extends jspb.Message {
  getKey(): string;
  setKey(value: string): void;

  getIsMaster(): boolean;
  setIsMaster(value: boolean): void;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): NodeInfo.AsObject;
  static toObject(includeInstance: boolean, msg: NodeInfo): NodeInfo.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: NodeInfo, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): NodeInfo;
  static deserializeBinaryFromReader(message: NodeInfo, reader: jspb.BinaryReader): NodeInfo;
}

export namespace NodeInfo {
  export type AsObject = {
    key: string,
    isMaster: boolean,
  }
}

