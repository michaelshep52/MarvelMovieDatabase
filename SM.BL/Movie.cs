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
    public class Movie : EntityBase, ILoggable //This is how to inherit from base class. : EntityBase and interface ILoggable
    {
        public Movie()
        {

        }
        public Movie(int movieId)
        {
            MovieId = MovieId;
        }
 
        public string MovieDecription { get; set; }
        public string MovieLength { get; set; }
        public int MovieId { get; private set; }
        public string MovieGenre { get; set; }
        public string MovieStreaming { get; private set; }
        private string _movieName;
        public string MovieName
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

        public string Log() =>
             $"{MovieId}: {MovieName} Genre: {MovieGenre}  + Detail: {MovieDecription} Status: {EntityState.ToString()}";


        public override string ToString() => MovieName;
        
        //Validate product
        public override bool ValidateData()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(MovieName)) isValid = false;
            return isValid;
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}

