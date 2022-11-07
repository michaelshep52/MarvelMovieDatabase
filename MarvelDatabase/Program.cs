
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration.Attributes;
using System.Globalization;



namespace MarvelDatabase
{
    public class Program 
    {        
        public static void Main(string[] args)
        {
            List<UserData> users = new List<UserData>();

            Console.WriteLine("Welcome to the Marvel Movie Database!");
            Console.WriteLine("Please choose from the following options to get started:");
            Console.WriteLine("1. New User");
            Console.WriteLine("2. Existing User");
            Console.WriteLine("3. Exit");
            int UserStatus = Convert.ToInt32(Console.ReadLine());

            if (UserStatus == 1) 
            {
                var userData = new UserData();
                //UserData();
                Console.WriteLine("Please create a Account.");
                Console.Write("Enter First name: ");
                string FirstName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(FirstName)) throw new ArgumentNullException("First name is required.");

                Console.Write("Enter Last name: ");
                string LastName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(LastName)) throw new ArgumentNullException("Last name is required.");

                Console.Write("Enter EmailAddress: ");
                string EmailAddress = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(EmailAddress)) throw new ArgumentNullException("EmailAddress is required.");

                Console.Write("Create a vaild Username: ");
                string Username = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(Username)) throw new ArgumentNullException("Username is required.");

                Console.Write("Create a vaild Password: ");
                string Password = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(Password)) throw new ArgumentNullException("Password is required.");
                users.Add(userData);
                Console.WriteLine("Thank you for creating an account!");
            };
            if (UserStatus == 2) 
            {
                Console.WriteLine("Please Login to Account.");
                Console.Write("Enter Username: ");
                string Username = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(Username)) throw new ArgumentNullException("Username is required.");
                const int MinUsernameLength = 5; if (Username.Length < MinUsernameLength) throw new ArgumentNullException("Username must contain at least 5 letters!");
                const int MaxUsernameLength = 20; if (Username.Length > MaxUsernameLength) throw new ArgumentNullException("Username can't contain over 20 letters!");
                Console.Write("Enter Password: ");
                string Password = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(Password)) throw new ArgumentNullException("Password is required.");
                const int MinPasswordLength = 6; if (Password.Length < MinPasswordLength) throw new ArgumentNullException("Password must contain at least 6 letters!");
                const int MaxPasswordLength = 25; if (Password.Length > MaxPasswordLength) throw new ArgumentNullException("Password can't contain over 25 letters!");
                Console.WriteLine("Thank you for Loging into your Account.");
            }
            //MovieData();
            Console.WriteLine("");
            Console.Write("How many movies would you like to view: ");
            var numberOfMovies = int.Parse(Console.ReadLine()!);

            for (int n = 0; n < numberOfMovies; n++)
            {
                Console.Write("Enter a Movie: ");
                var FindTitle = Console.ReadLine()!; 

                string[] csvLines = System.IO.File.ReadAllLines(@"MCUMovies.csv");

                //Movies
                var movies = new List<Movie>();

                //Split each row into column of data
                for (int i = 1; i < csvLines.Length; i++)
                {
                    Movie mov = new Movie(csvLines[i]);
                    movies.Add(mov);
                }
                //returns Elements in the list
                for (int i = 0; i < movies.Count; i++)
                {
                    var result = movies.Where(m => m.Title == FindTitle).FirstOrDefault();
                    Console.WriteLine(result.ToString());
                }
            }
            
            Console.ReadLine();
        }
    }
}