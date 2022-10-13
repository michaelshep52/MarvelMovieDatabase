using NUnit.Framework;
using System;
using System.Collections.Generic;
using SM.BL;


namespace CustomerRepoTest;

[TestClass]
public class CustomerRepositoryTest
{

    [TestMethod]
    public void RetrieveValid()
    {
        //--Arrange
        var customerRepository = new CustomerRepository();
        var expected = new Customer(1)
        {
            //customerId = 1, move into ()^
            EmailAddress = "mshepherd@got.you",
            FirstName = "Michael",
            LastName = "Shepherd",
            AddressList = new List<Address>()
            {
                new Address()
                {
                    AddressType = 1,
                    Street1 = "Panda Lane",
                    Street2 = "Parker row",
                    City = "Hazard",
                    State = "Kentucky",
                    Country = "USA",
                    PostalCode = "105"
                },
                 new Address(2)
                {
                AddressType = 2,
                Street1 = "Park corn",
                Street2 = "Prey ley",
                City = "Core",
                State = "Texas",
                Country = "USA",
                PostalCode = "18"
                 }
            }
        };
        //Act
        var actual = customerRepository.Retrieve(1);

        //Assert
        Assert.AreEqual(expected.CustomerId, actual.CustomerId);
        Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        Assert.AreEqual(expected.FirstName, actual.FirstName);
        Assert.AreEqual(expected.LastName, actual.LastName);

        for (int i = 0; i < 1; i++)
        {
            Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
            Assert.AreEqual(expected.AddressList[i].Street1, actual.AddressList[i].Street1);
            Assert.AreEqual(expected.AddressList[i].Street2, actual.AddressList[i].Street2);
            Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
            Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
            Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
            Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
        }
    }


    internal class TestMethodAttribute : Attribute { }


    internal class TestClassAttribute : Attribute { }
}