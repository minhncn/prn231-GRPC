// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/category.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace PetShop.GRPC {
  public static partial class CategoryServices
  {
    static readonly string __ServiceName = "category.CategoryServices";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PetShop.GRPC.GetAllCategoriesRequest> __Marshaller_category_GetAllCategoriesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PetShop.GRPC.GetAllCategoriesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PetShop.GRPC.GetAllCategoriesResponse> __Marshaller_category_GetAllCategoriesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PetShop.GRPC.GetAllCategoriesResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PetShop.GRPC.CreateCategoryRequest> __Marshaller_category_CreateCategoryRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PetShop.GRPC.CreateCategoryRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PetShop.GRPC.CategoryResponse> __Marshaller_category_CategoryResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PetShop.GRPC.CategoryResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PetShop.GRPC.UpdateCategoryRequest> __Marshaller_category_UpdateCategoryRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PetShop.GRPC.UpdateCategoryRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PetShop.GRPC.DeleteCategoryRequest> __Marshaller_category_DeleteCategoryRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PetShop.GRPC.DeleteCategoryRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PetShop.GRPC.GetAllCategoriesRequest, global::PetShop.GRPC.GetAllCategoriesResponse> __Method_GetAllCategories = new grpc::Method<global::PetShop.GRPC.GetAllCategoriesRequest, global::PetShop.GRPC.GetAllCategoriesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllCategories",
        __Marshaller_category_GetAllCategoriesRequest,
        __Marshaller_category_GetAllCategoriesResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PetShop.GRPC.CreateCategoryRequest, global::PetShop.GRPC.CategoryResponse> __Method_CreateCategory = new grpc::Method<global::PetShop.GRPC.CreateCategoryRequest, global::PetShop.GRPC.CategoryResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateCategory",
        __Marshaller_category_CreateCategoryRequest,
        __Marshaller_category_CategoryResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PetShop.GRPC.UpdateCategoryRequest, global::PetShop.GRPC.CategoryResponse> __Method_UpdateCategory = new grpc::Method<global::PetShop.GRPC.UpdateCategoryRequest, global::PetShop.GRPC.CategoryResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateCategory",
        __Marshaller_category_UpdateCategoryRequest,
        __Marshaller_category_CategoryResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PetShop.GRPC.DeleteCategoryRequest, global::PetShop.GRPC.CategoryResponse> __Method_DeleteCategory = new grpc::Method<global::PetShop.GRPC.DeleteCategoryRequest, global::PetShop.GRPC.CategoryResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteCategory",
        __Marshaller_category_DeleteCategoryRequest,
        __Marshaller_category_CategoryResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::PetShop.GRPC.CategoryReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CategoryServices</summary>
    [grpc::BindServiceMethod(typeof(CategoryServices), "BindService")]
    public abstract partial class CategoryServicesBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PetShop.GRPC.GetAllCategoriesResponse> GetAllCategories(global::PetShop.GRPC.GetAllCategoriesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PetShop.GRPC.CategoryResponse> CreateCategory(global::PetShop.GRPC.CreateCategoryRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PetShop.GRPC.CategoryResponse> UpdateCategory(global::PetShop.GRPC.UpdateCategoryRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PetShop.GRPC.CategoryResponse> DeleteCategory(global::PetShop.GRPC.DeleteCategoryRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(CategoryServicesBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAllCategories, serviceImpl.GetAllCategories)
          .AddMethod(__Method_CreateCategory, serviceImpl.CreateCategory)
          .AddMethod(__Method_UpdateCategory, serviceImpl.UpdateCategory)
          .AddMethod(__Method_DeleteCategory, serviceImpl.DeleteCategory).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CategoryServicesBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAllCategories, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PetShop.GRPC.GetAllCategoriesRequest, global::PetShop.GRPC.GetAllCategoriesResponse>(serviceImpl.GetAllCategories));
      serviceBinder.AddMethod(__Method_CreateCategory, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PetShop.GRPC.CreateCategoryRequest, global::PetShop.GRPC.CategoryResponse>(serviceImpl.CreateCategory));
      serviceBinder.AddMethod(__Method_UpdateCategory, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PetShop.GRPC.UpdateCategoryRequest, global::PetShop.GRPC.CategoryResponse>(serviceImpl.UpdateCategory));
      serviceBinder.AddMethod(__Method_DeleteCategory, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PetShop.GRPC.DeleteCategoryRequest, global::PetShop.GRPC.CategoryResponse>(serviceImpl.DeleteCategory));
    }

  }
}
#endregion
