// Code generated by protoc-gen-go-grpc. DO NOT EDIT.

package crawlab_grpc

import (
	context "context"
	grpc "google.golang.org/grpc"
	codes "google.golang.org/grpc/codes"
	status "google.golang.org/grpc/status"
)

// This is a compile-time assertion to ensure that this generated file
// is compatible with the grpc package it is being compiled against.
const _ = grpc.SupportPackageIsVersion7

// TaskServiceClient is the client API for TaskService service.
//
// For semantics around ctx use and closing/ending streaming RPCs, please refer to https://pkg.go.dev/google.golang.org/grpc/?tab=doc#ClientConn.NewStream.
type TaskServiceClient interface {
	GetTaskInfo(ctx context.Context, in *TaskServiceRequest, opts ...grpc.CallOption) (*TaskServiceResponse, error)
	SaveItem(ctx context.Context, in *TaskServiceRequest, opts ...grpc.CallOption) (*TaskServiceResponse, error)
	SaveItems(ctx context.Context, in *TaskServiceRequest, opts ...grpc.CallOption) (*TaskServiceResponse, error)
}

type taskServiceClient struct {
	cc grpc.ClientConnInterface
}

func NewTaskServiceClient(cc grpc.ClientConnInterface) TaskServiceClient {
	return &taskServiceClient{cc}
}

func (c *taskServiceClient) GetTaskInfo(ctx context.Context, in *TaskServiceRequest, opts ...grpc.CallOption) (*TaskServiceResponse, error) {
	out := new(TaskServiceResponse)
	err := c.cc.Invoke(ctx, "/crawlab_grpc.TaskService/GetTaskInfo", in, out, opts...)
	if err != nil {
		return nil, err
	}
	return out, nil
}

func (c *taskServiceClient) SaveItem(ctx context.Context, in *TaskServiceRequest, opts ...grpc.CallOption) (*TaskServiceResponse, error) {
	out := new(TaskServiceResponse)
	err := c.cc.Invoke(ctx, "/crawlab_grpc.TaskService/SaveItem", in, out, opts...)
	if err != nil {
		return nil, err
	}
	return out, nil
}

func (c *taskServiceClient) SaveItems(ctx context.Context, in *TaskServiceRequest, opts ...grpc.CallOption) (*TaskServiceResponse, error) {
	out := new(TaskServiceResponse)
	err := c.cc.Invoke(ctx, "/crawlab_grpc.TaskService/SaveItems", in, out, opts...)
	if err != nil {
		return nil, err
	}
	return out, nil
}

// TaskServiceServer is the server API for TaskService service.
// All implementations must embed UnimplementedTaskServiceServer
// for forward compatibility
type TaskServiceServer interface {
	GetTaskInfo(context.Context, *TaskServiceRequest) (*TaskServiceResponse, error)
	SaveItem(context.Context, *TaskServiceRequest) (*TaskServiceResponse, error)
	SaveItems(context.Context, *TaskServiceRequest) (*TaskServiceResponse, error)
	mustEmbedUnimplementedTaskServiceServer()
}

// UnimplementedTaskServiceServer must be embedded to have forward compatible implementations.
type UnimplementedTaskServiceServer struct {
}

func (UnimplementedTaskServiceServer) GetTaskInfo(context.Context, *TaskServiceRequest) (*TaskServiceResponse, error) {
	return nil, status.Errorf(codes.Unimplemented, "method GetTaskInfo not implemented")
}
func (UnimplementedTaskServiceServer) SaveItem(context.Context, *TaskServiceRequest) (*TaskServiceResponse, error) {
	return nil, status.Errorf(codes.Unimplemented, "method SaveItem not implemented")
}
func (UnimplementedTaskServiceServer) SaveItems(context.Context, *TaskServiceRequest) (*TaskServiceResponse, error) {
	return nil, status.Errorf(codes.Unimplemented, "method SaveItems not implemented")
}
func (UnimplementedTaskServiceServer) mustEmbedUnimplementedTaskServiceServer() {}

// UnsafeTaskServiceServer may be embedded to opt out of forward compatibility for this service.
// Use of this interface is not recommended, as added methods to TaskServiceServer will
// result in compilation errors.
type UnsafeTaskServiceServer interface {
	mustEmbedUnimplementedTaskServiceServer()
}

func RegisterTaskServiceServer(s grpc.ServiceRegistrar, srv TaskServiceServer) {
	s.RegisterService(&_TaskService_serviceDesc, srv)
}

func _TaskService_GetTaskInfo_Handler(srv interface{}, ctx context.Context, dec func(interface{}) error, interceptor grpc.UnaryServerInterceptor) (interface{}, error) {
	in := new(TaskServiceRequest)
	if err := dec(in); err != nil {
		return nil, err
	}
	if interceptor == nil {
		return srv.(TaskServiceServer).GetTaskInfo(ctx, in)
	}
	info := &grpc.UnaryServerInfo{
		Server:     srv,
		FullMethod: "/crawlab_grpc.TaskService/GetTaskInfo",
	}
	handler := func(ctx context.Context, req interface{}) (interface{}, error) {
		return srv.(TaskServiceServer).GetTaskInfo(ctx, req.(*TaskServiceRequest))
	}
	return interceptor(ctx, in, info, handler)
}

func _TaskService_SaveItem_Handler(srv interface{}, ctx context.Context, dec func(interface{}) error, interceptor grpc.UnaryServerInterceptor) (interface{}, error) {
	in := new(TaskServiceRequest)
	if err := dec(in); err != nil {
		return nil, err
	}
	if interceptor == nil {
		return srv.(TaskServiceServer).SaveItem(ctx, in)
	}
	info := &grpc.UnaryServerInfo{
		Server:     srv,
		FullMethod: "/crawlab_grpc.TaskService/SaveItem",
	}
	handler := func(ctx context.Context, req interface{}) (interface{}, error) {
		return srv.(TaskServiceServer).SaveItem(ctx, req.(*TaskServiceRequest))
	}
	return interceptor(ctx, in, info, handler)
}

func _TaskService_SaveItems_Handler(srv interface{}, ctx context.Context, dec func(interface{}) error, interceptor grpc.UnaryServerInterceptor) (interface{}, error) {
	in := new(TaskServiceRequest)
	if err := dec(in); err != nil {
		return nil, err
	}
	if interceptor == nil {
		return srv.(TaskServiceServer).SaveItems(ctx, in)
	}
	info := &grpc.UnaryServerInfo{
		Server:     srv,
		FullMethod: "/crawlab_grpc.TaskService/SaveItems",
	}
	handler := func(ctx context.Context, req interface{}) (interface{}, error) {
		return srv.(TaskServiceServer).SaveItems(ctx, req.(*TaskServiceRequest))
	}
	return interceptor(ctx, in, info, handler)
}

var _TaskService_serviceDesc = grpc.ServiceDesc{
	ServiceName: "crawlab_grpc.TaskService",
	HandlerType: (*TaskServiceServer)(nil),
	Methods: []grpc.MethodDesc{
		{
			MethodName: "GetTaskInfo",
			Handler:    _TaskService_GetTaskInfo_Handler,
		},
		{
			MethodName: "SaveItem",
			Handler:    _TaskService_SaveItem_Handler,
		},
		{
			MethodName: "SaveItems",
			Handler:    _TaskService_SaveItems_Handler,
		},
	},
	Streams:  []grpc.StreamDesc{},
	Metadata: "task.proto",
}