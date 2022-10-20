// package: grpc
// file: entity/response.proto

import * as jspb from "google-protobuf";
import * as entity_response_code_pb from "../entity/response_code_pb";

export class Response extends jspb.Message {
  getCode(): entity_response_code_pb.ResponseCodeMap[keyof entity_response_code_pb.ResponseCodeMap];
  setCode(value: entity_response_code_pb.ResponseCodeMap[keyof entity_response_code_pb.ResponseCodeMap]): void;

  getMessage(): string;
  setMessage(value: string): void;

  getData(): Uint8Array | string;
  getData_asU8(): Uint8Array;
  getData_asB64(): string;
  setData(value: Uint8Array | string): void;

  getError(): string;
  setError(value: string): void;

  getTotal(): number;
  setTotal(value: number): void;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): Response.AsObject;
  static toObject(includeInstance: boolean, msg: Response): Response.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: Response, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): Response;
  static deserializeBinaryFromReader(message: Response, reader: jspb.BinaryReader): Response;
}

export namespace Response {
  export type AsObject = {
    code: entity_response_code_pb.ResponseCodeMap[keyof entity_response_code_pb.ResponseCodeMap],
    message: string,
    data: Uint8Array | string,
    error: string,
    total: number,
  }
}

