// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: services/model_base_service_v2.proto

package grpc;

public final class ModelBaseServiceV2OuterClass {
  private ModelBaseServiceV2OuterClass() {}
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
      "\n$services/model_base_service_v2.proto\022\004" +
      "grpc\032%entity/model_service_v2_request.pr" +
      "oto\032\025entity/response.proto2\324\007\n\022ModelBase" +
      "ServiceV2\022?\n\007GetById\022\".grpc.ModelService" +
      "V2GetByIdRequest\032\016.grpc.Response\"\000\022=\n\006Ge" +
      "tOne\022!.grpc.ModelServiceV2GetOneRequest\032" +
      "\016.grpc.Response\"\000\022?\n\007GetMany\022\".grpc.Mode" +
      "lServiceV2GetManyRequest\032\016.grpc.Response" +
      "\"\000\022E\n\nDeleteById\022%.grpc.ModelServiceV2De" +
      "leteByIdRequest\032\016.grpc.Response\"\000\022C\n\tDel" +
      "eteOne\022$.grpc.ModelServiceV2DeleteOneReq" +
      "uest\032\016.grpc.Response\"\000\022E\n\nDeleteMany\022%.g" +
      "rpc.ModelServiceV2DeleteManyRequest\032\016.gr" +
      "pc.Response\"\000\022E\n\nUpdateById\022%.grpc.Model" +
      "ServiceV2UpdateByIdRequest\032\016.grpc.Respon" +
      "se\"\000\022C\n\tUpdateOne\022$.grpc.ModelServiceV2U" +
      "pdateOneRequest\032\016.grpc.Response\"\000\022E\n\nUpd" +
      "ateMany\022%.grpc.ModelServiceV2UpdateManyR" +
      "equest\032\016.grpc.Response\"\000\022G\n\013ReplaceById\022" +
      "&.grpc.ModelServiceV2ReplaceByIdRequest\032" +
      "\016.grpc.Response\"\000\022E\n\nReplaceOne\022%.grpc.M" +
      "odelServiceV2ReplaceOneRequest\032\016.grpc.Re" +
      "sponse\"\000\022C\n\tInsertOne\022$.grpc.ModelServic" +
      "eV2InsertOneRequest\032\016.grpc.Response\"\000\022E\n" +
      "\nInsertMany\022%.grpc.ModelServiceV2InsertM" +
      "anyRequest\032\016.grpc.Response\"\000\022;\n\005Count\022 ." +
      "grpc.ModelServiceV2CountRequest\032\016.grpc.R" +
      "esponse\"\000B\010Z\006.;grpcb\006proto3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          grpc.ModelServiceV2Request.getDescriptor(),
          grpc.ResponseOuterClass.getDescriptor(),
        });
    grpc.ModelServiceV2Request.getDescriptor();
    grpc.ResponseOuterClass.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}