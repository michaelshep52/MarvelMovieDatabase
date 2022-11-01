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
        public static void loginToAccount(UserData currentUser)
        {
            Console.WriteLine("Please Login to Account.");
            Console.WriteLine("Enter Username: ");
            string Username = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string Password = Console.ReadLine();
            Console.WriteLine("Thank you for Loging into your Account.");

        }

        public static void createUserAccount(UserData newUser)
        {
            Console.WriteLine("Please create a Account to precede");
            Console.WriteLine("Enter First name: ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last name: ");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter EmailAddress: ");
            string EmailAddress = Console.ReadLine();
            Console.WriteLine("Create a vaild Username: ");
            string Username = Console.ReadLine();
            Console.WriteLine("Create a vaild Password: ");
            string Password = Console.ReadLine();
        }
        static bool Main(string[] args)
        {
            Console.WriteLine("Welcome to the Marvel Movie Database!");

            static void displayMainMenu()
            {
                string UserStatus;
                Console.WriteLine("Please choose from the following options to get started:");
                Console.WriteLine("1. New User");
                Console.WriteLine("2. Existing User");
                Console.WriteLine("3. Exit");

                UserStatus = Console.ReadLine();
                if (UserStatus == "1")
                {
                    return createUserAccount(UserData newUser);
                }
                if (UserStatus == "2")
                {
                    return loginToAccount(UserData currentUser);
                }
            }
            static void searchDatabase(MovieData newMovieSearch)
            {
                Console.WriteLine("Please enter a movie title of Movie: ");
                string Title = Console.ReadLine();
            }

            Console.ReadKey();
        }
       
    }
}