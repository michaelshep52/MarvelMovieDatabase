using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class MovieDataRepo
    {
        public MovieData Retrieve(int MovieId)
        {
            MovieData movieData = new MovieData(MovieId);
            if (MovieId == 1)
            {
                movieData.Title = "Thor love and thunder";
                movieData.Genre = "Fantasy, Action, Comedy";
                movieData.RunTime = "129";
                movieData.Year = "2022";
                movieData.Decription = "After his retirement is interrupted by Gorr the God Butcher, a galactic killer who seeks the extinction of the gods, Thor Odinson enlists the help of King Valkyrie, Korg, and ex-girlfriend Jane Foster, who now wields Mjolnir as the Mighty Thor. Together they embark upon a harrowing cosmic adventure to uncover the mystery of the God Butcher vengeance and stop him before it";
                movieData.Streaming = "Disney plus";
            }
            return movieData;
        }
        public bool save(MovieData movieData)
        {
            return true;
        }
    }
}