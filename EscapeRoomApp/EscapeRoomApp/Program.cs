using System;
using System.Collections.Generic;
using Colorful;
using System.Drawing;

namespace EscapeRoomApp
{
    class Program
    {
        public static int Attempts;

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
                System.Console.Clear();
                Colorful.Console.WriteLine("Welcome Client.\n", Color.LawnGreen);
                ClientMenu();
            }
            else if (UserType == "2")
            {
                System.Console.Clear();
                PasswordCheck();
            }
            else
            {
                System.Console.Clear();
                Colorful.Console.WriteLine("Invalid input!\n", Color.Red);
                Start();
            }
        }


        static void ClientMenu()
        // Gets called when the user chooses the 'client' option.
        {
            Colorful.Console.WriteLine("What would you like to do?", Color.White);
            System.Console.WriteLine("(1) Discover our Escape Rooms\n(2) Reserve an Escape Room\n(3) Cancel a reservation\n(4) Return to Start Menu");
            string ClientAction = System.Console.ReadLine();
            if (ClientAction == "1")
            {
                System.Console.Clear();
                Colorful.Console.WriteLine("Below you will find a list of our Escape Rooms.\n", Color.White);
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
            else if (ClientAction == "4")
            {
                System.Console.Clear();
                Start();
            }
            else
            {
                System.Console.Clear();
                Colorful.Console.WriteLine("Invalid input!\n", Color.Red);
                ClientMenu();
            }
        }


        static void EscapeRoomList()
        //Gets called when the user chooses the option to check out the escape rooms.
        {
            Colorful.Console.WriteLine("Which Escape Room would you like to check out?", Color.White);
            System.Console.WriteLine("(1) Clumsy Clowns\n(2) Hidden Evidence\n(3) Bank Job \n(4) Up for Adoption \n(5) Killer Clowns \n(6) Return to Menu");
            string EscapeRoomNumber = System.Console.ReadLine();
            System.Console.Clear();
            if (EscapeRoomNumber == "1")
            {
                System.Console.WriteLine("Name: Clumsy Clowns\nDescription: The participants have accidentally been locked in a room by clumsy clowns.\n             The participants must escape the room in order to make it to the circus show on time.\nAge: Children\nTime: 60 minutes\nLocation: Wijnhaven 107, 3011 WN Rotterdam\n\nContact information:\nPhone number: 010-1234567\nEmail: escape.room@hr.nl\n");
                Colorful.Console.WriteLine("Press any key to continue.", Color.White);
                System.Console.ReadKey();
                System.Console.Clear();
                EscapeRoomList();
            }
            else if (EscapeRoomNumber == "2")
            {
                System.Console.WriteLine("Name: Hidden Evidence\nDescription: The innocent participants have been imprisoned by a corrupt police officer.\n             They must escape with the evidence the police officer is trying to hide so that he can be arrested.\nAge: All ages\nTime: 60 minutes\nLocation: Wijnhaven 107, 3011 WN Rotterdam\n\nContact information:\nPhone number: 010-1234567\nEmail: escape.room@hr.nl\n");
                Colorful.Console.WriteLine("Press any key to continue.", Color.White);
                System.Console.ReadKey();
                System.Console.Clear();
                EscapeRoomList();
            }
            else if (EscapeRoomNumber == "3")
            {
                System.Console.WriteLine("Name: Bank Job \nDescription: The bank robbers have locked themselves in the bank vault at night.\n             They must get out of the vault with all of the money before they're discovered and arrested by the police.\nAge: All ages\nTime: 60 minutes\nLocation: Wijnhaven 107, 3011 WN Rotterdam\n\nContact information:\nPhone number: 010-1234567\nEmail: escape.room@hr.nl\n");
                Colorful.Console.WriteLine("Press any key to continue.", Color.White);
                System.Console.ReadKey();
                System.Console.Clear();
                EscapeRoomList();
            }
            else if (EscapeRoomNumber == "4")
            {
                System.Console.WriteLine("Name: Up for Adoption \nDescription: The participants are investigating the disappearance of a young adopted girl,\n             they quickly find out that weird things are happening in her old room.\n             They must solve all of the puzzles and escape or they will be imprisoned in her room forever.\nAge: 16+ \nTime: 60 minutes\nLocation: Wijnhaven 107, 3011 WN Rotterdam\n\nContact information:\nPhone number: 010-1234567\nEmail: escape.room@hr.nl\n");
                Colorful.Console.WriteLine("Press any key to continue.", Color.White);
                System.Console.ReadKey();
                System.Console.Clear();
                EscapeRoomList();
            }
            else if (EscapeRoomNumber == "5")
            {
                System.Console.WriteLine("Name: Killer Clowns\nDescription: The participants have been locked up by bloodthirsty clowns.\n             They must escape before the clowns return to finish the job.\nAge: 16+\nTime: 60 minutes\nLocation: Wijnhaven 107, 3011 WN Rotterdam\n\nContact information:\nPhone number: 010-1234567\nEmail: escape.room@hr.nl\n");
                Colorful.Console.WriteLine("Press any key to continue.", Color.White);
                System.Console.ReadKey();
                System.Console.Clear();
                EscapeRoomList();
            }
            else if (EscapeRoomNumber == "6")
            {
                ClientMenu();
            }
            else
            {
                Colorful.Console.WriteLine("Invalid input!\n", Color.Red);
                EscapeRoomList();
            }
        }


        static void ReservationMenu()
        {
            Colorful.Console.WriteLine("\nPlease enter the name you wish to reserve with (first and last name).", Color.White);
            Colorful.Console.WriteLine("Note that you will need this name in order to cancel, make sure to save it.", Color.Yellow);
            string ReservationName = System.Console.ReadLine();
            Reservation reservation1 = new Reservation(ReservationName);
            System.Console.WriteLine("");
            System.Console.WriteLine(reservation1.name);
            System.Console.ReadKey();
        }


        static void PasswordCheck()
        // Gets called when the user chooses the 'admin' option.
        {
            string AdminPassword = "Admin";
            while (Attempts < 3)
            {
                Colorful.Console.WriteLine("Please enter the password:", Color.White);
                string PasswordInput = System.Console.ReadLine();
                if (PasswordInput == AdminPassword)
                {
                    System.Console.Clear();
                    Colorful.Console.WriteLine("Welcome Admin.", Color.LawnGreen);
                    Attempts = 3;
                    AdminMenu();
                }
                else
                {
                    Attempts++;
                    if (Attempts == 3)
                    {
                        System.Console.Clear();
                        Colorful.Console.WriteLine("Failed to enter the correct password. \nProgram terminating...", Color.Red);
                        System.Console.ReadLine();
                        break;
                    }
                    System.Console.Clear();
                    Colorful.Console.WriteLine("Invalid password.", Color.Red);
                    Colorful.Console.WriteLine("What would you like to do? \n(1) Enter password again \n(2) Return to Start Menu", Color.White);
                    string TryAgain = System.Console.ReadLine();
                    if (TryAgain == "1")
                    {
                        System.Console.Clear();
                        continue;
                    }
                    else if (TryAgain == "2")
                    {
                        Colorful.Console.Clear();
                        Start();
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }


        static void AdminMenu()
        //Gets called when the user inputs the correct password.
        {
            Colorful.Console.WriteLine("\nWhat do you wish to do?\n", Color.White);
            System.Console.WriteLine("(1) Edit Escape Room information\n(2) Check the reservations \n(3) Log-out as Admin");
            string AdminChoice = System.Console.ReadLine();
            if (AdminChoice == "1")
            {
                Colorful.Console.WriteLine("\n", Color.White);
                EditInfo();
            }
            if (AdminChoice == "3")
            {
                Attempts = 0;
                Colorful.Console.WriteLine("\n", Color.White);
                Start();
            }
        }

        static void EditInfo()
        {
            Colorful.Console.WriteLine("Which escape room would you like to edit?\n", Color.White);
            System.Console.WriteLine("1. //name of room 1\n2. //name of room 2\n3. //name of room 3\n4. //name of room 4\n5. //name of room 5");
        }

    }


    public class Reservation
    {
        public string name;

        public Reservation(string aName)
        {
            //List<Reservation>
            name = aName;
        }
    }
}
