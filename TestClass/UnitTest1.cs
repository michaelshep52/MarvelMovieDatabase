namespace TestClass;

public class CustomerTests
{
    [TestMethod]
    public void FullNameTestValid()
    {
        //--Arrange
        Customer customer = new Customer();
        customer.FirstName = "Michael";
        customer.LastName = "Shepherd";

        string expected = "Michael Shepherd";

        //--Act
        String actual = customer.FullName;

        //-- Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}
