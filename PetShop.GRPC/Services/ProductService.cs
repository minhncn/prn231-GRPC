using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using PetShop.BusinessObject.Models;
using PetShop.Repositories.Interfaces;
using PetShop.Services.Enums;

namespace PetShop.GRPC.Services
{
    public class ProductService : ProductServices.ProductServicesBase
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public override Task<ProductResponse> CreateProduct(CreateProductRequest request, ServerCallContext context)
        {
            if(request == null)
            {
                throw new RpcException(new Status(StatusCode.InvalidArgument, "Error request"));
            }
            var productItems = new Product{
                Id = Guid.NewGuid(),
                Name = request.Name,
                Price = request.Price,
                Status = request.Status,               
            };
            _productRepository.Create(productItems);
            return Task.FromResult(new ProductResponse
            {
                Id = productItems.Id.ToString(),
                Name = productItems.Name,
                Price = (int)productItems.Price,
                Status = productItems.Status,
            });
        }

        public override Task<GetAllProductsResponse> GetAllProducts(GetAllProductsRequest request, ServerCallContext context)
        {
            if(request == null)
            {
                throw new RpcException(new Status(StatusCode.InvalidArgument, "Error request"));
            }
            var response = new GetAllProductsResponse();
            var products = _productRepository.Get().Where(x => x.Status == ProductStatus.Available.ToString()).ToList();
            foreach (var product in products)
            {
                
            }
            return Task.FromResult(response);
        }
    }
}
