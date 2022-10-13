using System;
using System.Reflection.Metadata;
using Microsoft.VisualStudio.TestPlatform;
using SM.Common.cs;

namespace SM.COMTest;

public class StringHandlerTest
{
    [TestMethod]
    public void InsertSpaceTestValid()
    {
        // Arrange
        var source = "BillyMadison";
        var expected = "Billy Madison";
        //var Handler = new StringHandler();

        //Act
        var actual = source.InsertSpaces();

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void InsertSpacesTestWithExistingSpace()
    {
        // Arrange
        var source = "Billy Madison";
        var expected = "Billy Madison";
        //var handler = new StringHandler();

        //Act
        var actual = source.InsertSpaces();

        //Assert

        Assert.AreEqual(expected, actual);
    }
}

internal class TestMethodAttribute : Attribute
{
}