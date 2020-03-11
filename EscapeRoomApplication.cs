using System;
//using Colorful;

namespace EscapeRoomApp
{
    class Program
    {

        static void Main(string[] args)
        //Beginning function.
        {
            Console.WriteLine("Welcome to the escape room application.");
            Start();
        }

        static void Start()
        // Gets called at the start of the program.
        {
            Console.WriteLine("What type of user are you?");
            Console.WriteLine("(1) Client");
            Console.WriteLine("(2) Admin");
            int UserType = int.Parse(Console.ReadLine());

            if (UserType == 1)
            {
                Console.WriteLine("Welcome Client.\n");
                ClientMenu();
            }
            else if (UserType == 2)
            {
                PasswordCheck();
            }
            else
            {
                Console.WriteLine("Invalid input!\n");
                Start();
            }
        }

        static void ClientMenu()
        // Gets called when the user chooses the 'client' option.
        {
            
        }

        static void PasswordCheck()
        // Gets called when the user chooses the 'admin' option.
        {
            string AdminPassword = "Admin";
            int Attempts = 0;
            while (Attempts < 3)
            {
                Console.WriteLine("\nPlease enter the password:");
                string PasswordInput = Console.ReadLine();
                if (PasswordInput == AdminPassword)
                {
                    Console.WriteLine("Welcome Addmin");
                    Attempts = 3;
                    AdminMenu();
                }
                else
                {
                    Console.WriteLine("\nInvalid password.");
                    Attempts++;
                    if (Attempts == 3)
                    {
                        Console.WriteLine("Failed to enter the correct password.");
                    }
                }
            }
        }

        static void AdminMenu()
        //Gets called when the user inputs the correct password.
        {
            Console.WriteLine("\nWhat do you wish to do?\n(1) Edit Escape Room information.\n(2) Check the reservations.");
            Console.ReadLine();
        }

    }
}
