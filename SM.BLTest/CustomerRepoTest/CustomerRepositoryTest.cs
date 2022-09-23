using NUnit.Framework;
using System;
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
            LastName = "Shepherd"
        };
        //--Act
        var actual = customerRepository.Retrieve(1);

        //-- Assert
        Assert.AreEqual(expected.CustomerId, actual.CustomerId);
        Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        Assert.AreEqual(expected.FirstName, actual.FirstName);
        Assert.AreEqual(expected.LastName, actual.LastName);
    }
}
}internal class TestMethodAttribute : Attribute
{
}

internal class TestClassAttribute : Attribute
{
}