using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTEST
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            
            var expectedCustomer = new Customer(1)
            {
                Email = "rohitj559@gmail.com",
                LastName = "Jagannath",
                FirstName = "Rohit"
            };

            // Act
            Customer actualCustomer = customerRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expectedCustomer.Email, actualCustomer.Email);
            Assert.AreEqual(expectedCustomer.LastName, actualCustomer.LastName);
            Assert.AreEqual(expectedCustomer.FirstName, actualCustomer.FirstName);
        }
    }
}
