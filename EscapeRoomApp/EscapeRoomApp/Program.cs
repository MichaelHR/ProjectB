using System;
using System.Collections.Generic;
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
                ReservationMenu();
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
            System.Console.WriteLine("(1) Clumsy Clowns\n(2) Hidden Evidence\n(3) \n(4) \n(5) \n(6) Back");
            string EscapeRoomNumber = System.Console.ReadLine();
            if (EscapeRoomNumber == "1")
            {
                System.Console.WriteLine("\nName: Clumsy Clowns\nDescription: The participants have accidentally been locked in a room by clumsy clowns.\n             The participants must escape within one hour in order to make it on time to the circus show.\nAge: Children\nTime: 60 minutes\nLocation: EscapeRoomBV\n");
                Colorful.Console.WriteLine("Press any key to continue.\n", Color.White);
                System.Console.ReadKey();
                EscapeRoomList();
            }
            else if (EscapeRoomNumber == "2")
            {
                System.Console.WriteLine("\nName: Hidden Evidence\nDescription: The participants have innocently been imprisioned by a corrupt police officer.\n             They must escape within an hour with the evidence the police officer is trying to hide.\nAge: All ages\nTime: 60 minutes\nLocation: EscapeRoomBV\n");
                Colorful.Console.WriteLine("Press any key to continue.\n", Color.White);
                System.Console.ReadKey();
                EscapeRoomList();
            }
            else if (EscapeRoomNumber == "6")
            {
                System.Console.WriteLine("");
                ClientMenu();
            }
            else
            {
                Colorful.Console.WriteLine("\nInvalid input!\n", Color.Red);
                EscapeRoomList();
            }
        }


        static void ReservationMenu()
        {
            Colorful.Console.WriteLine("\nPlease enter the name you wish to reserve with (first and last name).", Color.White);
            Colorful.Console.WriteLine("Note that you will need this name in order to cancel, make sure to save it.", Color.Yellow);
            string ReservationName = System.Console.ReadLine();
            Colorful.Console.WriteLine("\nPlease enter your age", Color.White);
            string ReservationAge = System.Console.ReadLine();
            Reservation reservation1 = new Reservation(ReservationName, ReservationAge);
            System.Console.WriteLine("");
            System.Console.WriteLine(reservation1.name);
            System.Console.WriteLine(reservation1.age);
            System.Console.ReadKey();
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


    public class Reservation
    {
        public string name;
        public string age;

        public Reservation(string aName, string aAge)
        {
            //List<Reservation>
            name = aName;
            age = aAge;
        }
    }
}
