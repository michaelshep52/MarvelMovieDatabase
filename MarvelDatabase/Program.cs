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
                    
                    Console.WriteLine("Thank you for creating an account!");
                    

                    var jsonString = JsonSerializer.Serialize(userData);
                    var jsonDirectory =  Path.Combine(Directory.GetCurrentDirectory(), "data");
                    if (!Directory.Exists(jsonDirectory)) {
                        Directory.CreateDirectory(jsonDirectory);
                    }
                    File.WriteAllText(Path.Combine(jsonDirectory, "user.json"), jsonString);
                    Console.WriteLine(jsonString);
                    var jsonFilePath = Path.Combine(jsonDirectory, "user.json");

                    break;
                };
                if (UserStatus == 2) 
                {
                    var activeUser = new BusinessLogic.ActiveUser(); 

                    Console.WriteLine("");
                    Console.WriteLine("Please Login to Account.");
                    Console.WriteLine("");
                    Console.Write("Enter Username: ");
                    userData.Username = Console.ReadLine()!;

                    
                    Console.Write("Enter Password: ");
                    userData.Password = Console.ReadLine()!;
                    userData.CredentialCheck();

                   
                    var jsonDirectory =  Path.Combine(Directory.GetCurrentDirectory(), "data");
                    var jsonFilePath = Path.Combine(jsonDirectory, "user.json");
                    var contents = File.ReadAllText(jsonFilePath);
                    JsonSerializer.Deserialize<UserData>(contents);
                    activeUser.FindActiveUser();

                    if (userData.Username == userData.Username && userData.Password == userData.Password)
                    {
                        Console.WriteLine("You have successfully logged in!!");
                        break;
                    }
                    else if (userData.Username != userData.Username || userData.Password != userData.Password)
                    {
                        Console.WriteLine("Your username or password is incorect, try again !!!");
                        Console.ReadLine();
                        break;
                    }
                    
                    break;
                }
            }
            Console.Clear();
            origRow = Console.CursorTop;
            origCol = Console.CursorLeft;

            //MovieData();
            Console.Write("Here is a full list of our Marvel Universe Movies: ");
            Console.ReadLine();

            while (true)
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
                    Console.WriteLine("Please continue viewing!");
                    Console.ReadLine();
                }
                if (movieOption ==  "NO") 
                {
                    Console.WriteLine("");
                    Console.WriteLine("Thank you for using viewing our movies!");
                    break;
                }
            }
            Console.ReadLine();
        }
        
    }
}

