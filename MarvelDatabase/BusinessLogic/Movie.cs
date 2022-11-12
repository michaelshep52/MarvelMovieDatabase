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
        public int Id;
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
           this.Id = Convert.ToInt32(data[0]);
           this.Title = data[1];
           this.Genre = data[2];
           this.RunTime = Convert.ToDouble(data[3]);
           this.Year = Convert.ToDouble(data[4]);
           this.Description = data[5];
           this.Streaming = data[6];
        }

        public override string ToString()
        {
            string mov = $"{Id}" +
                $"\n{Title} " +
                $"\nGenre: {Genre} " +
                $"\nLength: {RunTime} minutes" +
                $"\nRelease year: {Year} " +
                $"\nDetails: {Description} " +
                $"\nStream now: {Streaming}.";
            return mov;
        }
    }
}
