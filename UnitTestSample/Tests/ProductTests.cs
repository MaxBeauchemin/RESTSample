using DomainSample.DTOs.Product;
using DomainSample.Services.Product;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestSample
{
    [TestClass]
    public class ProductTests
    {
        private readonly ProductService _productService;

        public ProductTests()
        {
            _productService = new ProductService();
        }

        [TestMethod]
        public void A_CreateProduct()
        {
            var product = _productService.CreateProduct(new CreateProductRequest
            {
                Description = "Stream Deck",
                CurrentPrice = 99.99m
            });

            var retrievedProduct = _productService.GetProductById(product.Id);

            Assert.IsNotNull(retrievedProduct);
            Assert.AreEqual(product.Id, retrievedProduct.Id);
            Assert.AreEqual(product.Description, retrievedProduct.Description);
            Assert.AreEqual(product.CurrentPrice, retrievedProduct.CurrentPrice);

            //Cleanup

            _productService.DeleteProductById(product.Id);
        }

        [TestMethod]
        public void B_UpdateProduct()
        {
            var product = _productService.CreateProduct(new CreateProductRequest
            {
                Description = "Sparkling Beverage",
                CurrentPrice = 7.49m
            });

            var updatedProduct = _productService.UpdateProduct(product.Id, new UpdateProductRequest
            {
                Description = "Sparkling Water",
                CurrentPrice = 7.99m
            });

            var retrievedProduct = _productService.GetProductById(product.Id);

            Assert.IsNotNull(retrievedProduct);
            Assert.AreEqual(updatedProduct.Id, retrievedProduct.Id);
            Assert.AreEqual(updatedProduct.Description, retrievedProduct.Description);
            Assert.AreEqual(updatedProduct.CurrentPrice, retrievedProduct.CurrentPrice);

            //Cleanup

            _productService.DeleteProductById(product.Id);
        }

        [TestMethod]
        public void C_FindProductsByKeyword()
        {
            var foundProducts = _productService.FindProducts(new FindProductsRequest
            {
                Keyword = "3",
                PageNumber = 0,
                PageSize = 1000
            });

            Assert.AreEqual(2, foundProducts.Count, "Expected to find 2 products");
        }

        [TestMethod]
        public void D_FindProductsByKeywordWithSmallPageSize()
        {
            var foundProducts = _productService.FindProducts(new FindProductsRequest
            {
                Keyword = "3",
                PageNumber = 0,
                PageSize = 1
            });

            Assert.AreEqual(1, foundProducts.Count, "Expected to find 2 products, but get 1 result due to page size");
        }

        [TestMethod]
        public void E_DeleteProduct()
        {
            var product = _productService.CreateProduct(new CreateProductRequest
            {
                Description = "Stream Deck",
                CurrentPrice = 99.99m
            });

            _productService.DeleteProductById(product.Id);

            try
            {
                //Should Fail
                _productService.GetProductById(product.Id);

                Assert.Fail("Should have thrown an error and skipped this");
            }
            catch { }
        }
    }
}
