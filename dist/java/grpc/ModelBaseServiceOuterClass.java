// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: services/model_base_service.proto

package grpc;

public final class ModelBaseServiceOuterClass {
  private ModelBaseServiceOuterClass() {}
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
      "\n!services/model_base_service.proto\022\004grp" +
      "c\032\024entity/request.proto\032\025entity/response" +
      ".proto2\254\004\n\020ModelBaseService\022*\n\007GetById\022\r" +
      ".grpc.Request\032\016.grpc.Response\"\000\022&\n\003Get\022\r" +
      ".grpc.Request\032\016.grpc.Response\"\000\022*\n\007GetLi" +
      "st\022\r.grpc.Request\032\016.grpc.Response\"\000\022-\n\nD" +
      "eleteById\022\r.grpc.Request\032\016.grpc.Response" +
      "\"\000\022)\n\006Delete\022\r.grpc.Request\032\016.grpc.Respo" +
      "nse\"\000\022-\n\nDeleteList\022\r.grpc.Request\032\016.grp" +
      "c.Response\"\000\0222\n\017ForceDeleteList\022\r.grpc.R" +
      "equest\032\016.grpc.Response\"\000\022-\n\nUpdateById\022\r" +
      ".grpc.Request\032\016.grpc.Response\"\000\022)\n\006Updat" +
      "e\022\r.grpc.Request\032\016.grpc.Response\"\000\022,\n\tUp" +
      "dateDoc\022\r.grpc.Request\032\016.grpc.Response\"\000" +
      "\022)\n\006Insert\022\r.grpc.Request\032\016.grpc.Respons" +
      "e\"\000\022(\n\005Count\022\r.grpc.Request\032\016.grpc.Respo" +
      "nse\"\000B\010Z\006.;grpcb\006proto3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          grpc.RequestOuterClass.getDescriptor(),
          grpc.ResponseOuterClass.getDescriptor(),
        });
    grpc.RequestOuterClass.getDescriptor();
    grpc.ResponseOuterClass.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}
