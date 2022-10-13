using System;
using SM.BL;
using SM.BL.cs;

namespace SM.BLTest
{
    public class OrderRepositoryTest
    {
        public void RetrieveOrderDisplayTest()
        {
            // Arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0)),
            };

            // Act
            var actual = orderRepository.Retrieve(10);

            //Assert
            Assert.That(actual.OrderDate, Is.EqualTo(expected.OrderDate)); // or   Assert.AreEqual(expected.OrderDate, actual.OrderDate);

        }
    }
}

