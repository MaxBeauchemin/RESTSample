using DomainSample.DTOs.Product;
using DomainSample.Enums;
using System;
using System.Collections.Generic;

namespace DomainSample.Services.Product
{
    public class ProductService : BaseService
    {
        private readonly LogArea _logArea = LogArea.Product;

        public ProductDto CreateProduct(CreateProductRequest request)
        {
            throw new NotImplementedException();
        }

        public ProductDto UpdateProduct(int id, UpdateProductRequest request)
        {
            throw new NotImplementedException();
        }

        public int DeleteProductById(int id)
        {
            throw new NotImplementedException();
        }

        public ProductDto GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductDto> FindProducts(FindProductsRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
