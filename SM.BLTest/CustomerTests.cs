using System;
using SM.BL;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace SM.BLTest;

[TestClass]
public class ProductTests
{
    [TestMethod]
    public void FullNameTestValid()
    {
        //--Arrange
        Customer customer = new Customer();     //can be written:
        customer.FirstName = "Michael";         //{
        customer.LastName = "Shepherd";         //  FirstName = "Michael",
                                                //  LastName = " Shepherd"
                                                //};

        string expected = "Shepherd, Michael";  

        //--Act
        String actual = customer.FullName;

        //-- Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestMethod]
    public void FullNameFirstNameEmpty()
    {
        //--Arrange
        Customer customer = new Customer();
        customer.LastName = "Shepherd";

        string expected = "Shepherd";

        //--Act
        String actual = customer.FullName;

        //-- Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestMethod]
    public void StaticTest()
    {
        var c1 = new Customer();
        c1.FirstName = "Michael";
        Customer.InstanceCount += 1;

        var c2 = new Customer();
        c2.FirstName = "Laelyn";
        Customer.InstanceCount += 1;

        var c3 = new Customer();
        c3.FirstName = "Lindsey";
        Customer.InstanceCount += 1;

        Assert.AreEqual(3, Customer.InstanceCount);
    }

    [TestMethod]
    public void ValidateValid()
    {
        var customer = new Customer
        {
            LastName = "Shepherd",
            EmailAddress = "mshepherd@got.you"
        };
        var expected = true;
        var actual = customer.Validate();
        Assert.AreEqual(expected, actual);  
    }

    [TestMethod]
    public void ValidateMissingLastName()
    {
        var customer = new Customer
        {
            EmailAddress = "mshepherd@got.you"
        };
        var expected = false;
        var actual = customer.Validate();
        Assert.AreEqual(expected, actual);
    }

    private class TestClassAttribute : Attribute
    {
    }

    private class TestMethodAttribute : Attribute
    {
    }
}
