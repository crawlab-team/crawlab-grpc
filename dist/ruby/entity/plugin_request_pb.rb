# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: entity/plugin_request.proto

require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("entity/plugin_request.proto", :syntax => :proto3) do
    add_message "grpc.PluginRequest" do
      optional :name, :string, 1
      optional :data, :bytes, 2
    end
  end
end

module Grpc
  PluginRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("grpc.PluginRequest").msgclass
end