# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: entity/stream_message_data_task.proto

require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("entity/stream_message_data_task.proto", :syntax => :proto3) do
    add_message "grpc.StreamMessageDataTask" do
      optional :task_id, :string, 1
      optional :data, :bytes, 2
    end
  end
end

module Grpc
  StreamMessageDataTask = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("grpc.StreamMessageDataTask").msgclass
end
