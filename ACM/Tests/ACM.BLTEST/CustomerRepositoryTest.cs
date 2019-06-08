﻿using System;
using System.Collections.Generic;
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

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            // Arrange
            var customerRepository = new CustomerRepository();

            var expected = new Customer(1)
            {
                Email = "rohitj559@gmail.com",
                LastName = "Jagannath",
                FirstName = "Rohit",
                AddressList = new List<Address>()
                                {
                                    new Address()
                                    {
                                        AddressType = 1,
                                        StreetLine1 = "Bag End",
                                        StreetLine2 = "Bagshot Row",
                                        City = "Hobbiton",
                                        State = "Shire",
                                        Country = "Middle Earth",
                                        PostalCode = "144"
                                    },
                                    new Address()
                                    {
                                        AddressType = 2,
                                        StreetLine1 = "Green Dragon",
                                        City = "ByWater",
                                        State = "Shire",
                                        Country = "Middle Earth",
                                        PostalCode = "146"
                                    }
                                }
            };

            // Act
            var actual = customerRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.Email, actual.Email);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.FirstName, actual.FirstName);

            for(int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }
    }
}
