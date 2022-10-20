// package: grpc
// file: models/node.proto

import * as jspb from "google-protobuf";

export class Node extends jspb.Message {
  getId(): string;
  setId(value: string): void;

  getName(): string;
  setName(value: string): void;

  getIp(): string;
  setIp(value: string): void;

  getPort(): string;
  setPort(value: string): void;

  getMac(): string;
  setMac(value: string): void;

  getHostname(): string;
  setHostname(value: string): void;

  getDescription(): string;
  setDescription(value: string): void;

  getKey(): string;
  setKey(value: string): void;

  getIsMaster(): boolean;
  setIsMaster(value: boolean): void;

  getUpdateTs(): string;
  setUpdateTs(value: string): void;

  getCreateTs(): string;
  setCreateTs(value: string): void;

  getUpdateTsUnix(): number;
  setUpdateTsUnix(value: number): void;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): Node.AsObject;
  static toObject(includeInstance: boolean, msg: Node): Node.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: Node, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): Node;
  static deserializeBinaryFromReader(message: Node, reader: jspb.BinaryReader): Node;
}

export namespace Node {
  export type AsObject = {
    id: string,
    name: string,
    ip: string,
    port: string,
    mac: string,
    hostname: string,
    description: string,
    key: string,
    isMaster: boolean,
    updateTs: string,
    createTs: string,
    updateTsUnix: number,
  }
}

