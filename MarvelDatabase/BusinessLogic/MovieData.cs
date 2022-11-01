using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic
{
    public class MovieData 
    {
        private int movieId;

        public MovieData(int MovieId)
        {
            MovieId = movieId;
        }
        public int MovieId { get; private set; }
        public string? Genre { get; set; }
        public string? RunTime { get; set; }
        public string? Year {get; set; }
        public string? Decription { get; set; }
        public string? Streaming { get; set; }
        public string? Title {get; set; }

   /* public MovieData(string Title, string Genre, int RunTime, int Year, string Decription, string Streaming)
    {
            this.Title = Title;
            this.Genre = Genre;
            this.RunTime = RunTime.ToString();
            this.Year = Year.ToString();
            this.Decription = Decription;
            this.Streaming = Streaming;

    }*/

        //public string Log() =>
         //    $"{MovieId}: {MovieName} Genre: {MovieGenre}  + Detail: {MovieDecription} Status: {EntityState.ToString()}";


        //public override string ToString() => MovieName;
        
        //Validate product
        /*public override bool ValidateData()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(MovieTitle)) isValid = false;
            return isValid;
        } */

        
    }
}
