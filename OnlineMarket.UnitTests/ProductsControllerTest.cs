using System;
using Moq;
using OnlineMarket.Models;
using OnlineMarket.Controllers;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace OnlineMarket.UnitTests
{
    public class ProductsControllerTest
    {
        [Fact]
        public void GetProducts_DBPopulated_RetunsALlistOfProducts()
        {
            var data = new List<Product>
            {
                new Product {Name = "a", Description="a", Guid=Guid.NewGuid(), Price=1, Uri="a"},
                new Product {Name = "b", Description="b", Guid=Guid.NewGuid(), Price=2, Uri="b"}
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Product>>();
            mockSet.As<IQueryable<Product>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Product>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Product>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Product>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<IIdentityModel>();
            mockContext.Setup(c => c.Products).Returns(mockSet.Object);

            var productsController = new ProductsController(mockContext.Object);
            var products = productsController.GetProducts();

            Assert.Equal(2, products.Count());
            Assert.Equal(products, data);
        }
    }
}
