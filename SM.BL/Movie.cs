using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using SM.BL.cs;
using SM.COM.cs;
using SM.Common.cs;

namespace SM.BL
{
    public class Movie 
    {
        public Movie(int movieId)
        {
            MovieId = MovieId;
        }
 
        public int MovieId { get; private set; }
        private string _movieName;
        public string Genre { get; set; }
        public string RunTime { get; set; }
        public string Year {get; set; }
        public string Decription { get; set; }
        public string Streaming { get; private set; }
        public string Name
        {
            get
            {
                //var stringHandler = new StringHandler(); //Adding StringHandler and all its code.
                return _movieName.InsertSpaces();// changed from return _movieName;
            }
            set
            {
                _movieName = value;
            }
        }
        public Movie(string Name, string Genre, int RunTime, int Year, string Decription, string Streaming)
        {
            this.Name = Name;
            this.Genre = Genre;
            this.RunTime = RunTime.ToString();
            this.Year = Year.ToString();
            this.Decription = Decription;
            this.Streaming = Streaming;

        }

        //public string Log() =>
         //    $"{MovieId}: {MovieName} Genre: {MovieGenre}  + Detail: {MovieDecription} Status: {EntityState.ToString()}";


        //public override string ToString() => MovieName;
        
        //Validate product
       /* public override bool ValidateData()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(MovieName)) isValid = false;
            return isValid;
        } */

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}

