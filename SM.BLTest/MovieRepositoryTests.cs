using System;
using SM.BL;
using SM.BL.cs;

namespace SM.BLTest
{
    [TestClass]
    public class MovieRepositoryTest
    {

            [TestMethod]
            public void SaveTestValid()
            {
                //--Arrange
                var movieRepository = new MovieRepository();
            var updatedMovie = new Movie(2)
            {
                CurrentPrice = 18M,
                MovieDecription = "A musical of sorts",
                MovieName = "Musical",
                HasChanges = true
            };
            
             //Act
            var actual = movieRepository.Save(updatedMovie);

                //Assert
                Assert.That(actual, Is.EqualTo(true)); //or Assert.AreEqual(true, actual);

        }
        [TestMethod]
        public void SaveTestMissingCurrentPrice()
        {
            //--Arrange
            var movieRepository = new MovieRepository();
            var updatedMovie = new Movie(2)
            {
                CurrentPrice = null,
                MovieDecription = "A musical of sorts",
                MovieName = "Musical",
                HasChanges = true
            };

            //Act
            var actual = movieRepository.Save(updatedMovie);

            //Assert
            Assert.That(actual, Is.EqualTo(false)); // or Assert.AreEqual(false, actual);
        }


            internal class TestMethodAttribute : Attribute { }


            internal class TestClassAttribute : Attribute { }
    }
}


