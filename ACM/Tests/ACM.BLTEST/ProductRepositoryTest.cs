using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTEST
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            var productRepository = new ProductRepository();

            var expectedProduct = new Product(1)
            {
                ProductName = "SomeProduct",
                ProductDescription = "SomeDescription",
                CurrentPrice = 12
            };            

            // Act
            Product actualProduct = productRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expectedProduct.ProductName, actualProduct.ProductName);
            Assert.AreEqual(expectedProduct.ProductDescription, actualProduct.ProductDescription);
            Assert.AreEqual(expectedProduct.CurrentPrice, actualProduct.CurrentPrice);
        }
    }
}
