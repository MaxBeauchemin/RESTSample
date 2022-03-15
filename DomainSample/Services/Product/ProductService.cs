using DomainSample.DTOs.Product;
using DomainSample.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DomainSample.Services.Product
{
    public class ProductService : BaseService
    {
        private readonly LogArea _logArea = LogArea.Product;

        public ProductDto CreateProduct(CreateProductRequest request)
        {
            try
            {
                EntryLog(_logArea, request);

                if (request == null) throw new ArgumentException("Null Request");

                var model = new Models.Product
                {
                    Description = request.Description,
                    CurrentPrice = request.CurrentPrice
                };

                _context.Products.Add(model);
                _context.SaveChanges();

                return new ProductDto(model);
            }
            catch (Exception ex)
            {
                ErrorLog(_logArea, ex);
                throw ex;
            }
        }

        public ProductDto UpdateProduct(int id, UpdateProductRequest request)
        {
            throw new NotImplementedException();
        }

        public int DeleteProductById(int id)
        {
            try
            {
                EntryLog(_logArea, id);

                var model = _context.Products.Where(p => p.Id == id).FirstOrDefault();

                if (model == null) throw new ArgumentException("Product Not Found");

                _context.Products.Remove(model);

                _context.SaveChanges();

                return id;
            }
            catch (Exception ex)
            {
                ErrorLog(_logArea, ex);
                throw ex;
            }
        }

        public ProductDto GetProductById(int id)
        {
            try
            {
                var model = _context.Products.Where(p => p.Id == id).FirstOrDefault();

                if (model == null) throw new ArgumentException("Product Not Found");

                return new ProductDto(model);
            }
            catch (Exception ex)
            {
                ErrorLog(_logArea, ex);
                throw ex;
            }
        }

        public List<ProductDto> FindProducts(FindProductsRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
