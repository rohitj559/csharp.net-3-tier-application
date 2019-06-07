using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTEST
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            var orderRepository = new OrderRepository();

            var expectedOrder = new Order(1)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                                                     new TimeSpan(7, 0, 0))
            };

            // Act
            Order actualOrder = orderRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expectedOrder.OrderDate, actualOrder.OrderDate);
        }
    }
}
