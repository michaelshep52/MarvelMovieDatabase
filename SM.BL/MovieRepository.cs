using System;

namespace SM.BL.cs
{
    public class MovieRepository  
    {
        public MovieRepository()
        {
            movieRepository = new MovieRepository();
        }
        private MovieRepository movieRepository { get; set; }

        //Retrieve

        public Movie Retrieve(int movieId)
        {
            //code that retrieves defined customer.
            Movie movie = new Movie(movieId);

            if (movieId == 2)
            {
                movie.MovieName = "Thor Love and Thunder";
                movie.MovieDecription = "Follows Thor as he attempts to find inner peace, but must return to action and recruit Valkyrie, Korg, and Foster to stop Gorr the God Butcher from eliminating all gods.";
                movie.MovieGenre = "Action";
                movie.MovieLength = "119";
                movie.MovieCurrentPrice = "19.99";

            }
            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Movie: {movie.ToString()}");
            return movie;
        }


        //Save
        public bool Save(Movie movie)
        {
            var success = true;

            if (movie.HasChanges)
            {
                if (movie.IsValid)
                {
                    if (movie.IsNew)
                    {
                        //Call and Insert Stored Procedure.
                    }
                    else
                    {
                        //Call an Update Stored Procedure.
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}

