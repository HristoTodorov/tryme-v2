// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: admin_tool.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Admindesk {
  /// <summary>
  ///  The AdminDesk service definition.
  /// </summary>
  public static class AdminDesk
  {
    static readonly string __ServiceName = "admindesk.AdminDesk";

    static readonly Marshaller<global::Admindesk.IdRequest> __Marshaller_IdRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Admindesk.IdRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Admindesk.SubjectsReply> __Marshaller_SubjectsReply = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Admindesk.SubjectsReply.Parser.ParseFrom);
    static readonly Marshaller<global::Admindesk.ClassesReply> __Marshaller_ClassesReply = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Admindesk.ClassesReply.Parser.ParseFrom);
    static readonly Marshaller<global::Admindesk.TestNamesReply> __Marshaller_TestNamesReply = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Admindesk.TestNamesReply.Parser.ParseFrom);
    static readonly Marshaller<global::Admindesk.TestReply> __Marshaller_TestReply = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Admindesk.TestReply.Parser.ParseFrom);

    static readonly Method<global::Admindesk.IdRequest, global::Admindesk.SubjectsReply> __Method_GetSubjects = new Method<global::Admindesk.IdRequest, global::Admindesk.SubjectsReply>(
        MethodType.Unary,
        __ServiceName,
        "GetSubjects",
        __Marshaller_IdRequest,
        __Marshaller_SubjectsReply);

    static readonly Method<global::Admindesk.IdRequest, global::Admindesk.ClassesReply> __Method_GetClasses = new Method<global::Admindesk.IdRequest, global::Admindesk.ClassesReply>(
        MethodType.Unary,
        __ServiceName,
        "GetClasses",
        __Marshaller_IdRequest,
        __Marshaller_ClassesReply);

    static readonly Method<global::Admindesk.IdRequest, global::Admindesk.TestNamesReply> __Method_GetTestNames = new Method<global::Admindesk.IdRequest, global::Admindesk.TestNamesReply>(
        MethodType.Unary,
        __ServiceName,
        "GetTestNames",
        __Marshaller_IdRequest,
        __Marshaller_TestNamesReply);

    static readonly Method<global::Admindesk.IdRequest, global::Admindesk.TestReply> __Method_GetTest = new Method<global::Admindesk.IdRequest, global::Admindesk.TestReply>(
        MethodType.Unary,
        __ServiceName,
        "GetTest",
        __Marshaller_IdRequest,
        __Marshaller_TestReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Admindesk.AdminToolReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AdminDesk</summary>
    public abstract class AdminDeskBase
    {
      /// <summary>
      ///  If id is specified then get specific Subjects.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Admindesk.SubjectsReply> GetSubjects(global::Admindesk.IdRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  If id is specified then get specific Classes.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Admindesk.ClassesReply> GetClasses(global::Admindesk.IdRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  If id is specified then get specific Themes.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Admindesk.TestNamesReply> GetTestNames(global::Admindesk.IdRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  IdRequest.id is required.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Admindesk.TestReply> GetTest(global::Admindesk.IdRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AdminDesk</summary>
    public class AdminDeskClient : ClientBase<AdminDeskClient>
    {
      /// <summary>Creates a new client for AdminDesk</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AdminDeskClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AdminDesk that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AdminDeskClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AdminDeskClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AdminDeskClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///  If id is specified then get specific Subjects.
      /// </summary>
      public virtual global::Admindesk.SubjectsReply GetSubjects(global::Admindesk.IdRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetSubjects(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  If id is specified then get specific Subjects.
      /// </summary>
      public virtual global::Admindesk.SubjectsReply GetSubjects(global::Admindesk.IdRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetSubjects, null, options, request);
      }
      /// <summary>
      ///  If id is specified then get specific Subjects.
      /// </summary>
      public virtual AsyncUnaryCall<global::Admindesk.SubjectsReply> GetSubjectsAsync(global::Admindesk.IdRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetSubjectsAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  If id is specified then get specific Subjects.
      /// </summary>
      public virtual AsyncUnaryCall<global::Admindesk.SubjectsReply> GetSubjectsAsync(global::Admindesk.IdRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetSubjects, null, options, request);
      }
      /// <summary>
      ///  If id is specified then get specific Classes.
      /// </summary>
      public virtual global::Admindesk.ClassesReply GetClasses(global::Admindesk.IdRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetClasses(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  If id is specified then get specific Classes.
      /// </summary>
      public virtual global::Admindesk.ClassesReply GetClasses(global::Admindesk.IdRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetClasses, null, options, request);
      }
      /// <summary>
      ///  If id is specified then get specific Classes.
      /// </summary>
      public virtual AsyncUnaryCall<global::Admindesk.ClassesReply> GetClassesAsync(global::Admindesk.IdRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetClassesAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  If id is specified then get specific Classes.
      /// </summary>
      public virtual AsyncUnaryCall<global::Admindesk.ClassesReply> GetClassesAsync(global::Admindesk.IdRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetClasses, null, options, request);
      }
      /// <summary>
      ///  If id is specified then get specific Themes.
      /// </summary>
      public virtual global::Admindesk.TestNamesReply GetTestNames(global::Admindesk.IdRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetTestNames(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  If id is specified then get specific Themes.
      /// </summary>
      public virtual global::Admindesk.TestNamesReply GetTestNames(global::Admindesk.IdRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetTestNames, null, options, request);
      }
      /// <summary>
      ///  If id is specified then get specific Themes.
      /// </summary>
      public virtual AsyncUnaryCall<global::Admindesk.TestNamesReply> GetTestNamesAsync(global::Admindesk.IdRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetTestNamesAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  If id is specified then get specific Themes.
      /// </summary>
      public virtual AsyncUnaryCall<global::Admindesk.TestNamesReply> GetTestNamesAsync(global::Admindesk.IdRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetTestNames, null, options, request);
      }
      /// <summary>
      ///  IdRequest.id is required.
      /// </summary>
      public virtual global::Admindesk.TestReply GetTest(global::Admindesk.IdRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetTest(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  IdRequest.id is required.
      /// </summary>
      public virtual global::Admindesk.TestReply GetTest(global::Admindesk.IdRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetTest, null, options, request);
      }
      /// <summary>
      ///  IdRequest.id is required.
      /// </summary>
      public virtual AsyncUnaryCall<global::Admindesk.TestReply> GetTestAsync(global::Admindesk.IdRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetTestAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  IdRequest.id is required.
      /// </summary>
      public virtual AsyncUnaryCall<global::Admindesk.TestReply> GetTestAsync(global::Admindesk.IdRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetTest, null, options, request);
      }
      protected override AdminDeskClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AdminDeskClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(AdminDeskBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetSubjects, serviceImpl.GetSubjects)
          .AddMethod(__Method_GetClasses, serviceImpl.GetClasses)
          .AddMethod(__Method_GetTestNames, serviceImpl.GetTestNames)
          .AddMethod(__Method_GetTest, serviceImpl.GetTest).Build();
    }

  }
}
#endregion
