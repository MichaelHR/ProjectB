using System;
using Colorful;
using System.Drawing;

namespace EscapeRoomApp
{
    class Program
    {


        static void Main(string[] args)
        //Beginning function.
        {
            Colorful.Console.WriteLine("Welcome to the escape room application.\n", Color.White);
            Start();
        }


        static void Start()
        // Gets called at the start of the program.
        {
            Colorful.Console.WriteLine("What type of user are you?", Color.White);
            System.Console.WriteLine("(1) Client");
            System.Console.WriteLine("(2) Admin");
            string UserType = System.Console.ReadLine();

            if (UserType == "1")
            {
                Colorful.Console.WriteLine("\nWelcome Client.\n", Color.LawnGreen);
                ClientMenu();
            }
            else if (UserType == "2")
            {
                PasswordCheck();
            }
            else
            {
                Colorful.Console.WriteLine("\nInvalid input!\n", Color.Red);
                Start();
            }
        }


        static void ClientMenu()
        // Gets called when the user chooses the 'client' option.
        {
            Colorful.Console.WriteLine("What would you like to do?", Color.White);
            System.Console.WriteLine("(1) Discover our Escape Rooms\n(2) Reserve an Escape Room\n(3) Cancel a reservation");
            string ClientAction = System.Console.ReadLine();
            if (ClientAction == "1")
            {
                Colorful.Console.WriteLine("\nBelow you will find a list of our Escape Rooms.\n", Color.White);
                EscapeRoomList();
            }
            else if (ClientAction == "2")
            {
                System.Console.WriteLine("Cancel System");
            }
            else if (ClientAction == "3")
            {
                System.Console.WriteLine("Via JSON");
            }
            else
            {
                Colorful.Console.WriteLine("Invalid input!", Color.Red);
            }
        }


        static void EscapeRoomList()
        //Gets called when the user chooses the option to check out the escape rooms.
        {
            Colorful.Console.WriteLine("Which Escape Room would you like to check out?", Color.White);
            System.Console.WriteLine("(1) \n(2) \n(3) \n(4) \n(5) ");
            string EscapeRoomNumber = System.Console.ReadLine();
            if (EscapeRoomNumber == "1")
            {

            }
        }


        static void PasswordCheck()
        // Gets called when the user chooses the 'admin' option.
        {
            string AdminPassword = "Admin";
            int Attempts = 0;
            while (Attempts < 3)
            {
                Colorful.Console.WriteLine("\nPlease enter the password:", Color.White);
                string PasswordInput = System.Console.ReadLine();
                if (PasswordInput == AdminPassword)
                {
                    Colorful.Console.WriteLine("\nWelcome Admin.", Color.LawnGreen);
                    Attempts = 3;
                    AdminMenu();
                }
                else
                {
                    Colorful.Console.WriteLine("\nInvalid password.", Color.Red);
                    Attempts++;
                    if (Attempts == 3)
                    {
                        Colorful.Console.WriteLine("Failed to enter the correct password.", Color.Red);
                        System.Console.ReadLine();
                    }
                }
            }
        }


        static void AdminMenu()
        //Gets called when the user inputs the correct password.
        {
            Colorful.Console.WriteLine("\nWhat do you wish to do?\n(1) Edit Escape Room information\n(2) Check the reservations", Color.White);
            string AdminChoice = System.Console.ReadLine();
        }

    }
}
