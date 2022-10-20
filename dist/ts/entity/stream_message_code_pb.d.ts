// package: grpc
// file: entity/stream_message_code.proto

import * as jspb from "google-protobuf";

export interface StreamMessageCodeMap {
  PING: 0;
  RUN_TASK: 1;
  CANCEL_TASK: 2;
  INSERT_DATA: 3;
  INSERT_LOGS: 4;
  SEND_EVENT: 5;
  INSTALL_PLUGIN: 6;
  UNINSTALL_PLUGIN: 7;
  START_PLUGIN: 8;
  STOP_PLUGIN: 9;
  CONNECT: 10;
  DISCONNECT: 11;
  SEND: 12;
}

export const StreamMessageCode: StreamMessageCodeMap;

