using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace SM
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "MCUMovies.csv.rtf";

            /* List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            } */
            List<Movie> movies = new List<Movie>();

            List<string> lines = File.ReadAllLines(filePath).ToList();
          
            foreach (var line in lines)
            {
                string[] entries = line.Split(";");
         
                Movie newMovie = new Movie();

                newMovie.Title = entries[0];
                newMovie.Genre = entries[1];
                newMovie.RunTime = entries[2];
                newMovie.Year = entries[3];
                newMovie.Decription = entries[4];
                newMovie.Streaming = entries[5];

                movies.Add(newMovie);
            }
            foreach (var movie in movies)
            {
                Console.WriteLine($"{ movie.Title } { movie.Genre } { movie.RunTime } { movie.Year } { movie.Decription } { movie.Streaming }");
            }
            if (entries > 6)
            {
                throw new InvalidDataException("file path can only accept 6 entries");
            }
            console.Readline();
        }
    }
}