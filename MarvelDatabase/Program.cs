using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;


namespace MarvelDatabase
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Marvel Movie Database!");
            Console.WriteLine("Please choose from the following options to get started:");
            Console.WriteLine("1. New User");
            Console.WriteLine("2. Existing User");
            Console.WriteLine("3. Exit");
            int UserStatus = Convert.ToInt32(Console.ReadLine());
            if (UserStatus == 1)
            {
                createUserAccount();
            }
            if (UserStatus == 2)
            {
                loginToAccount();
            }
            
            static void searchDatabase(MovieData newMovieSearch)
            {
                Console.WriteLine("Please enter a movie title of Movie: ");
                string? Title = Console.ReadLine();
            }

            Console.ReadKey();
        }
        public static void loginToAccount()
        {
            Console.WriteLine("Please Login to Account.");
            Console.Write("Enter Username: ");
            string? Username = Console.ReadLine();
            Console.Write("Enter Password: ");
            string? Password = Console.ReadLine();
            Console.WriteLine("Thank you for Loging into your Account.");
        }
        public static void createUserAccount()
        {
            Console.WriteLine("Please create a Account.");
            Console.Write("Enter First name: ");
            string? FirstName = Console.ReadLine();
            Console.Write("Enter Last name: ");
            string? LastName = Console.ReadLine();
            Console.Write("Enter EmailAddress: ");
            string? EmailAddress = Console.ReadLine();
            Console.Write("Create a vaild Username: ");
            string? Username = Console.ReadLine();
            Console.Write("Create a vaild Password: ");
            string? Password = Console.ReadLine();
        }

       
    }
}