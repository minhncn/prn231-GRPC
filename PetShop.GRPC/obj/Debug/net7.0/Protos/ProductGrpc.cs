// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/product.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace PetShop.GRPC {
  public static partial class ProductServices
  {
    static readonly string __ServiceName = "product.ProductServices";

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
    static readonly grpc::Marshaller<global::PetShop.GRPC.GetAllProductsRequest> __Marshaller_product_GetAllProductsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PetShop.GRPC.GetAllProductsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PetShop.GRPC.GetAllProductsResponse> __Marshaller_product_GetAllProductsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PetShop.GRPC.GetAllProductsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PetShop.GRPC.CreateProductRequest> __Marshaller_product_CreateProductRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PetShop.GRPC.CreateProductRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PetShop.GRPC.ProductResponse> __Marshaller_product_ProductResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PetShop.GRPC.ProductResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PetShop.GRPC.UpdateProductRequest> __Marshaller_product_UpdateProductRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PetShop.GRPC.UpdateProductRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PetShop.GRPC.DeleteProductRequest> __Marshaller_product_DeleteProductRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PetShop.GRPC.DeleteProductRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PetShop.GRPC.GetAllProductsRequest, global::PetShop.GRPC.GetAllProductsResponse> __Method_GetAllProducts = new grpc::Method<global::PetShop.GRPC.GetAllProductsRequest, global::PetShop.GRPC.GetAllProductsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllProducts",
        __Marshaller_product_GetAllProductsRequest,
        __Marshaller_product_GetAllProductsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PetShop.GRPC.CreateProductRequest, global::PetShop.GRPC.ProductResponse> __Method_CreateProduct = new grpc::Method<global::PetShop.GRPC.CreateProductRequest, global::PetShop.GRPC.ProductResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateProduct",
        __Marshaller_product_CreateProductRequest,
        __Marshaller_product_ProductResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PetShop.GRPC.UpdateProductRequest, global::PetShop.GRPC.ProductResponse> __Method_UpdateProduct = new grpc::Method<global::PetShop.GRPC.UpdateProductRequest, global::PetShop.GRPC.ProductResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateProduct",
        __Marshaller_product_UpdateProductRequest,
        __Marshaller_product_ProductResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PetShop.GRPC.DeleteProductRequest, global::PetShop.GRPC.ProductResponse> __Method_DeleteProduct = new grpc::Method<global::PetShop.GRPC.DeleteProductRequest, global::PetShop.GRPC.ProductResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteProduct",
        __Marshaller_product_DeleteProductRequest,
        __Marshaller_product_ProductResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::PetShop.GRPC.ProductReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ProductServices</summary>
    [grpc::BindServiceMethod(typeof(ProductServices), "BindService")]
    public abstract partial class ProductServicesBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PetShop.GRPC.GetAllProductsResponse> GetAllProducts(global::PetShop.GRPC.GetAllProductsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PetShop.GRPC.ProductResponse> CreateProduct(global::PetShop.GRPC.CreateProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PetShop.GRPC.ProductResponse> UpdateProduct(global::PetShop.GRPC.UpdateProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PetShop.GRPC.ProductResponse> DeleteProduct(global::PetShop.GRPC.DeleteProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ProductServicesBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAllProducts, serviceImpl.GetAllProducts)
          .AddMethod(__Method_CreateProduct, serviceImpl.CreateProduct)
          .AddMethod(__Method_UpdateProduct, serviceImpl.UpdateProduct)
          .AddMethod(__Method_DeleteProduct, serviceImpl.DeleteProduct).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ProductServicesBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAllProducts, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PetShop.GRPC.GetAllProductsRequest, global::PetShop.GRPC.GetAllProductsResponse>(serviceImpl.GetAllProducts));
      serviceBinder.AddMethod(__Method_CreateProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PetShop.GRPC.CreateProductRequest, global::PetShop.GRPC.ProductResponse>(serviceImpl.CreateProduct));
      serviceBinder.AddMethod(__Method_UpdateProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PetShop.GRPC.UpdateProductRequest, global::PetShop.GRPC.ProductResponse>(serviceImpl.UpdateProduct));
      serviceBinder.AddMethod(__Method_DeleteProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PetShop.GRPC.DeleteProductRequest, global::PetShop.GRPC.ProductResponse>(serviceImpl.DeleteProduct));
    }

  }
}
#endregion