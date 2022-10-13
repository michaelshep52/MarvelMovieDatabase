using System;
using System.Reflection.Metadata;
using Microsoft.VisualStudio.TestPlatform;
using SM.COM.cs;
using SM.Common.cs;
using SM.BL;

namespace SM.COMTest;

public class ILoggableServiceTest
{
    [TestMethod]
    public void WriteToFileTest()
    {
        // Arrange
        var changedItems = new List<ILoggable>();

        var customer = new Customer(1)
        {
            EmailAddress = "mshepherd@got.you",
            FirstName = "Michael",
            LastName = "Shepherd",
            AddressList = null
        };
        changedItems.Add(customer);

        var movie = new Movie(2)
        {
            MovieName = "Striker",
            MovieGenre = "Action",
            MovieDecription = "The bee on a mission",
            CurrentPrice = 18
        };
        changedItems.Add(movie);

        //var Handler = new StringHandler();

        //Act
        LoggingService.WriteToFile(changedItems);

        // Assert
        //nothing to assert at this time
    }
}

