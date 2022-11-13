using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.ComTypes;
using System.ComponentModel.DataAnnotations;
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
using System.Text.Json;

namespace MarvelDatabase
{
    public class Program 
    {        
        
        protected static int origRow;
        protected static int origCol;

        protected static void WriteAt(string s, int x, int y)
        {
        try
            {
            Console.SetCursorPosition(origCol+x, origRow+y);
            Console.Write(s);
            }
        catch (ArgumentOutOfRangeException e)
            {
            Console.Clear();
            Console.WriteLine(e.Message);
            }
        }
        public static void Main(string[] args)
        {
            Console.Clear();
            origRow = Console.CursorTop;
            origCol = Console.CursorLeft;   

            Console.WriteLine("Welcome to the Marvel Movie Database!");
            Console.WriteLine("");

            Console.WriteLine("Please choose from the following options to get started:");
            Console.WriteLine("1. New User");
            Console.WriteLine("2. Existing User");
            Console.WriteLine("3. Exit");
            Console.Write("Enter: ");
            int UserStatus = Convert.ToInt32(Console.ReadLine());            

            for (int u = 0; u < UserStatus; u++)
            {
                var userData = new UserData();
                string path = @"User.csv";
                string delimiter = ",";

                if (UserStatus == 1) 
                {
                    Console.WriteLine("Please create a Account.");
                    Console.WriteLine("");
                    Console.Write("Enter First name: ");
                    userData.FirstName = Console.ReadLine()!;
                    Console.WriteLine("");
                    
                    Console.Write("Enter Last name: ");
                    userData.LastName = Console.ReadLine()!;
                    Console.WriteLine("");

                    Console.Write("Enter EmailAddress: ");
                    userData.EmailAddress = Console.ReadLine()!;
                    Console.WriteLine("");

                    Console.Write("Create a vaild Username: ");
                    userData.Username = Console.ReadLine()!;
                    Console.WriteLine("");

                    Console.Write("Create a vaild Password: ");
                    userData.Password = Console.ReadLine()!;
                    Console.WriteLine("");
                    userData.Validate();

                    string appendText = $"{userData.FirstName}{delimiter}{userData.LastName}{delimiter}{userData.EmailAddress}{delimiter}" + 
                                        $"{userData.Username}{delimiter}{userData.Password}{Environment.NewLine}";
                    File.AppendAllText(path, appendText);

                    Console.WriteLine("Thank you for creating an account!");
                    break;
                };
                if (UserStatus == 2) 
                {
                    string readText = File.ReadAllText(path);
                    Console.WriteLine("");
                    Console.WriteLine("Please Login to Account.");
                    Console.WriteLine("");
                    Console.Write("Enter Username: ");
                    userData.Username = Console.ReadLine()!;
                    if (!Regex.Match(userData.Username, path).Success)
                    {
                        Console.WriteLine("Invaild Username");
                        return;
                    }
                    Console.Write("Enter Password: ");
                    userData.Password = Console.ReadLine()!;
                    if (!Regex.Match(userData.Password, path).Success)
                    {
                        Console.WriteLine("Invalid Password");
                        return;
                    }
                    userData.CredentialCheck();
                    Console.WriteLine("You have successfully logged in!!");       
                }
            }      
            Console.ReadLine();
        
            Console.Clear();
            origRow = Console.CursorTop;
            origCol = Console.CursorLeft;

            //MovieData();
            Console.Write("Here is a full list of our Marvel Universe Movies: ");
            Console.ReadLine();
            
            string input = "";
            do
            {    
                Console.WriteLine("");
                Console.WriteLine("Please select from the following movies:");
                string[] csvLines = System.IO.File.ReadAllLines(@"MCUMovies.csv");

                var movieTitles = new List<string>();
                var movieId = new List<string>();
                
                for (int i = 0; i < csvLines.Length; i++)
                {
                    string[] rowData = csvLines[i].Split(";");
                    movieId.Add(rowData[0]);
                    movieTitles.Add(rowData[1]);
                }

                Console.WriteLine("Titles: ");
                for (int i = 1; i < movieTitles.Count; i++)
                {
                    Console.WriteLine($"{movieId[i]}:  {movieTitles[i]}");
                }
                Console.ReadLine();

                Console.Write("Enter a Movie Id: ");
                var FindId = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine("");
                if (FindId >= 31)
                {
                    Console.WriteLine("Enter a valid number!");
                    break;
                }
                Console.WriteLine("");

                //Movies
                var movies = new List<Movie>();

                //Split each row into column of data
                for (int i = 1; i < csvLines.Length; i++)
                {
                    Movie mov = new Movie(csvLines[i]);
                    movies.Add(mov);
                }
                //returns Elements in the list
                for (int i = 1; i < movies.Count;)
                {
                    var result = movies.Where(m => m.Id == FindId).FirstOrDefault();
                    Console.WriteLine(result.ToString());
                    break;
                }
                Console.WriteLine("");
                Console.Write("View another movie? Yes or No:  ");
                var movieOption = Console.ReadLine().ToUpper();

                if (movieOption == "YES") 
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please continue viewing!");
                    Console.ReadLine();
                }
            }
            while (!input.ToUpper().Equals("NO"));
            Console.WriteLine("Thank yous for viewing our App have an amazing day!");
            Console.ReadLine();
        }

    }
    
}

