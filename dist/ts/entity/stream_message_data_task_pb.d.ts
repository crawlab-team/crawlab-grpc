// package: grpc
// file: entity/stream_message_data_task.proto

import * as jspb from "google-protobuf";

export class StreamMessageDataTask extends jspb.Message {
  getTaskId(): string;
  setTaskId(value: string): void;

  getData(): string;
  setData(value: string): void;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): StreamMessageDataTask.AsObject;
  static toObject(includeInstance: boolean, msg: StreamMessageDataTask): StreamMessageDataTask.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: StreamMessageDataTask, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): StreamMessageDataTask;
  static deserializeBinaryFromReader(message: StreamMessageDataTask, reader: jspb.BinaryReader): StreamMessageDataTask;
}

export namespace StreamMessageDataTask {
  export type AsObject = {
    taskId: string,
    data: string,
  }
}

