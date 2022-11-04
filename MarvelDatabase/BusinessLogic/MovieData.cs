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
       public MovieData()
       {
        
       }
        public MovieData(int movieId)
        {
            MovieId = movieId;
        }
        public int MovieId { get; private set; }
        public string Genre { get; }
        public string RunTime { get; }
        public string Year {get; }
        public string Description { get; }
        public string Streaming { get; }
        public string Title {get; }

        public MovieData(string Title, string Genre, int RunTime, int Year, string Description, string Streaming)
        {
            this.Title = Title;
            this.Genre = Genre;
            this.RunTime = RunTime.ToString();
            this.Year = Year.ToString();
            this.Description = Description;
            this.Streaming = Streaming;

        }
        public override string ToString() => 
            $"{Title} Genre: {Genre}, Length: {RunTime}, Release year: {Year}, Details: {Description}, Streaming: {Streaming}";
        public MovieData Retrieve(int VehicleId) //get a specific vehicle
        {
            return new MovieData();
        }
        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true; 
            
            if(string.IsNullOrWhiteSpace(Title)) isValid = false;
            if(string.IsNullOrWhiteSpace(Genre)) isValid = false;
            if(string.IsNullOrWhiteSpace(RunTime)) isValid = false;
            if(string.IsNullOrWhiteSpace(Year)) isValid = false;
            if(string.IsNullOrWhiteSpace(Description)) isValid = false;
            if(string.IsNullOrWhiteSpace(Streaming)) isValid = false;
            return isValid;
        }
    }
}
