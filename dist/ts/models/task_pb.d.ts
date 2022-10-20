// package: grpc
// file: models/task.proto

import * as jspb from "google-protobuf";

export class Task extends jspb.Message {
  getId(): string;
  setId(value: string): void;

  getSpiderId(): string;
  setSpiderId(value: string): void;

  getStatus(): string;
  setStatus(value: string): void;

  getNodeId(): string;
  setNodeId(value: string): void;

  getCmd(): string;
  setCmd(value: string): void;

  getParam(): string;
  setParam(value: string): void;

  getError(): string;
  setError(value: string): void;

  getPid(): number;
  setPid(value: number): void;

  getRunType(): string;
  setRunType(value: string): void;

  getScheduleId(): string;
  setScheduleId(value: string): void;

  getType(): string;
  setType(value: string): void;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): Task.AsObject;
  static toObject(includeInstance: boolean, msg: Task): Task.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: Task, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): Task;
  static deserializeBinaryFromReader(message: Task, reader: jspb.BinaryReader): Task;
}

export namespace Task {
  export type AsObject = {
    id: string,
    spiderId: string,
    status: string,
    nodeId: string,
    cmd: string,
    param: string,
    error: string,
    pid: number,
    runType: string,
    scheduleId: string,
    type: string,
  }
}

