// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: services/message_service.proto

package grpc;

public final class MessageServiceOuterClass {
  private MessageServiceOuterClass() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n\036services/message_service.proto\022\004grpc\032\033" +
      "entity/stream_message.proto2K\n\016MessageSe" +
      "rvice\0229\n\007Connect\022\023.grpc.StreamMessage\032\023." +
      "grpc.StreamMessage\"\000(\0010\001B\010Z\006.;grpcb\006prot" +
      "o3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          grpc.StreamMessageOuterClass.getDescriptor(),
        });
    grpc.StreamMessageOuterClass.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}