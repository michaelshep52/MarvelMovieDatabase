using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic
{
    public class Movie 
    {
        public string Title;
        public string Genre;
        public double RunTime;
        public double Year;
        public string Description;
        public string Streaming;
        public Movie(string rowData)
        {
           string[] data = rowData.Split(';');
           // Parse Data into properties
           this.Title = data[0];
           this.Genre = data[1];
           this.RunTime = Convert.ToDouble(data[2]);
           this.Year = Convert.ToDouble(data[3]);
           this.Description = data[4];
           this.Streaming = data[5];
        }

        public override string ToString()
        {
            string mov = $"{Title} " +
                $"\nGenre: {Genre} " +
                $"\nLength: {RunTime} " +
                $"\nRelease year: {Year} " +
                $"\nDetails: {Description} " +
                $"\nStream: {Streaming}.";
            return mov;
        }
    
        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true; 
            
            if(string.IsNullOrWhiteSpace(Title)) isValid = false;
            return isValid;
        }
    }
}
