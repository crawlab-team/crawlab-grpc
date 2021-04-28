// Code generated by protoc-gen-go-grpc. DO NOT EDIT.

package grpc

import (
	context "context"
	grpc "google.golang.org/grpc"
	codes "google.golang.org/grpc/codes"
	status "google.golang.org/grpc/status"
)

// This is a compile-time assertion to ensure that this generated file
// is compatible with the grpc package it is being compiled against.
const _ = grpc.SupportPackageIsVersion7

// MasterNodeServiceClient is the client API for MasterNodeService service.
//
// For semantics around ctx use and closing/ending streaming RPCs, please refer to https://pkg.go.dev/google.golang.org/grpc/?tab=doc#ClientConn.NewStream.
type MasterNodeServiceClient interface {
	Register(ctx context.Context, in *Request, opts ...grpc.CallOption) (*Response, error)
	Ping(ctx context.Context, in *Request, opts ...grpc.CallOption) (*Response, error)
}

type masterNodeServiceClient struct {
	cc grpc.ClientConnInterface
}

func NewMasterNodeServiceClient(cc grpc.ClientConnInterface) MasterNodeServiceClient {
	return &masterNodeServiceClient{cc}
}

func (c *masterNodeServiceClient) Register(ctx context.Context, in *Request, opts ...grpc.CallOption) (*Response, error) {
	out := new(Response)
	err := c.cc.Invoke(ctx, "/grpc.MasterNodeService/Register", in, out, opts...)
	if err != nil {
		return nil, err
	}
	return out, nil
}

func (c *masterNodeServiceClient) Ping(ctx context.Context, in *Request, opts ...grpc.CallOption) (*Response, error) {
	out := new(Response)
	err := c.cc.Invoke(ctx, "/grpc.MasterNodeService/Ping", in, out, opts...)
	if err != nil {
		return nil, err
	}
	return out, nil
}

// MasterNodeServiceServer is the server API for MasterNodeService service.
// All implementations must embed UnimplementedMasterNodeServiceServer
// for forward compatibility
type MasterNodeServiceServer interface {
	Register(context.Context, *Request) (*Response, error)
	Ping(context.Context, *Request) (*Response, error)
	mustEmbedUnimplementedMasterNodeServiceServer()
}

// UnimplementedMasterNodeServiceServer must be embedded to have forward compatible implementations.
type UnimplementedMasterNodeServiceServer struct {
}

func (UnimplementedMasterNodeServiceServer) Register(context.Context, *Request) (*Response, error) {
	return nil, status.Errorf(codes.Unimplemented, "method Register not implemented")
}
func (UnimplementedMasterNodeServiceServer) Ping(context.Context, *Request) (*Response, error) {
	return nil, status.Errorf(codes.Unimplemented, "method Ping not implemented")
}
func (UnimplementedMasterNodeServiceServer) mustEmbedUnimplementedMasterNodeServiceServer() {}

// UnsafeMasterNodeServiceServer may be embedded to opt out of forward compatibility for this service.
// Use of this interface is not recommended, as added methods to MasterNodeServiceServer will
// result in compilation errors.
type UnsafeMasterNodeServiceServer interface {
	mustEmbedUnimplementedMasterNodeServiceServer()
}

func RegisterMasterNodeServiceServer(s grpc.ServiceRegistrar, srv MasterNodeServiceServer) {
	s.RegisterService(&_MasterNodeService_serviceDesc, srv)
}

func _MasterNodeService_Register_Handler(srv interface{}, ctx context.Context, dec func(interface{}) error, interceptor grpc.UnaryServerInterceptor) (interface{}, error) {
	in := new(Request)
	if err := dec(in); err != nil {
		return nil, err
	}
	if interceptor == nil {
		return srv.(MasterNodeServiceServer).Register(ctx, in)
	}
	info := &grpc.UnaryServerInfo{
		Server:     srv,
		FullMethod: "/grpc.MasterNodeService/Register",
	}
	handler := func(ctx context.Context, req interface{}) (interface{}, error) {
		return srv.(MasterNodeServiceServer).Register(ctx, req.(*Request))
	}
	return interceptor(ctx, in, info, handler)
}

func _MasterNodeService_Ping_Handler(srv interface{}, ctx context.Context, dec func(interface{}) error, interceptor grpc.UnaryServerInterceptor) (interface{}, error) {
	in := new(Request)
	if err := dec(in); err != nil {
		return nil, err
	}
	if interceptor == nil {
		return srv.(MasterNodeServiceServer).Ping(ctx, in)
	}
	info := &grpc.UnaryServerInfo{
		Server:     srv,
		FullMethod: "/grpc.MasterNodeService/Ping",
	}
	handler := func(ctx context.Context, req interface{}) (interface{}, error) {
		return srv.(MasterNodeServiceServer).Ping(ctx, req.(*Request))
	}
	return interceptor(ctx, in, info, handler)
}

var _MasterNodeService_serviceDesc = grpc.ServiceDesc{
	ServiceName: "grpc.MasterNodeService",
	HandlerType: (*MasterNodeServiceServer)(nil),
	Methods: []grpc.MethodDesc{
		{
			MethodName: "Register",
			Handler:    _MasterNodeService_Register_Handler,
		},
		{
			MethodName: "Ping",
			Handler:    _MasterNodeService_Ping_Handler,
		},
	},
	Streams:  []grpc.StreamDesc{},
	Metadata: "services/master_node_service.proto",
}
