// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: node.proto

package pb;

public final class Node {
  private Node() {}
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
      "\n\nnode.proto\022\002pb\032\016response.proto26\n\013Node" +
      "Service\022\'\n\010Register\022\013.pb.Request\032\014.pb.Re" +
      "sponse\"\000B\006Z\004.;pbb\006proto3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          pb.ResponseOuterClass.getDescriptor(),
        });
    pb.ResponseOuterClass.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}