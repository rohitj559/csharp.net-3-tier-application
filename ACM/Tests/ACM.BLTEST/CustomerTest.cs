using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTEST
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Rohit",
                LastName = "Jagannath"
            };
            string expected = "Jagannath, Rohit";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            Customer customer = new Customer
            {
                LastName = "Jagannath"
            };
            string expected = "Jagannath";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Rohit"
            };
            string expected = "Rohit";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            // Arrange
            var c1 = new Customer();
            c1.FirstName = "Rohit";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c1.FirstName = "Arif";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c1.FirstName = "Tejas";
            Customer.InstanceCount += 1;

            int expected = 3;

            // Act
            int actual = Customer.InstanceCount;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
