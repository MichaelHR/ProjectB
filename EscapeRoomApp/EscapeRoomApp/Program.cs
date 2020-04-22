using System;
using System.Collections.Generic;
using Colorful;
using System.Drawing;

namespace EscapeRoomApp
{
    public static class Global
    {
        //escape room names
        public static string EscName1 = "Clumsy Clowns";
        public static string EscName2 = "Hidden Evidence";
        public static string EscName3 = "Bank Job";
        public static string EscName4 = "Up for Adoption";
        public static string EscName5 = "Killer Clowns";
        //escape room general info
        public static int EscPlayers1max = 8;
        public static int EscPlayers2max = 5;
        public static int EscPlayers3max = 6;
        public static int EscPlayers4max = 7;
        public static int EscPlayers5max = 5;

        // Reservation general info
        public static int ReservationPlayerAmount = 0;
        public static int ReservationEscapeRoomMaxCount = 0;
    }
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
            System.Console.Clear();
            Colorful.Console.WriteLine("Welcome Client.\n", Color.LawnGreen);
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
            System.Console.WriteLine("(1) " + Global.EscName1 + "\n(2) " + Global.EscName2 + "\n(3) " + Global.EscName3 + "\n(4) " + Global.EscName4 + "\n(5) " + Global.EscName5 + "\n(6) Return to Menu");
            string EscapeRoomNumber = System.Console.ReadLine();
            System.Console.Clear();
            if (EscapeRoomNumber == "1")
            {
                System.Console.WriteLine("Name: " + Global.EscName1 + "\nDescription: The participants have accidentally been locked in a room by clumsy clowns.\n             The participants must escape the room in order to make it to the circus show on time.\nAge: Children\nTime: 60 minutes\nMaximum amount of players: " + Global.EscPlayers1max + "\nLocation: Wijnhaven 107, 3011 WN Rotterdam\n\nContact information:\nPhone number: 010-1234567\nEmail: escape.room@hr.nl\n");
                Colorful.Console.WriteLine("Press any key to continue.", Color.White);
                System.Console.ReadKey();
                System.Console.Clear();
                EscapeRoomList();
            }
            else if (EscapeRoomNumber == "2")
            {
                System.Console.WriteLine("Name: " + Global.EscName2 + "\nDescription: The innocent participants have been imprisoned by a corrupt police officer.\n             They must escape with the evidence the police officer is trying to hide so that he can be arrested.\nAge: All ages\nTime: 60 minutes\nMaximum amount of players: " + Global.EscPlayers2max + "\nLocation: Wijnhaven 107, 3011 WN Rotterdam\n\nContact information:\nPhone number: 010-1234567\nEmail: escape.room@hr.nl\n");
                Colorful.Console.WriteLine("Press any key to continue.", Color.White);
                System.Console.ReadKey();
                System.Console.Clear();
                EscapeRoomList();
            }
            else if (EscapeRoomNumber == "3")
            {
                System.Console.WriteLine("Name: " + Global.EscName3 + "\nDescription: The bank robbers have locked themselves in the bank vault at night.\n             They must get out of the vault with all of the money before they're discovered and arrested by the police.\nAge: All ages\nTime: 60 minutes\nMaximum amount of players: " + Global.EscPlayers3max + "\nLocation: Wijnhaven 107, 3011 WN Rotterdam\n\nContact information:\nPhone number: 010-1234567\nEmail: escape.room@hr.nl\n");
                Colorful.Console.WriteLine("Press any key to continue.", Color.White);
                System.Console.ReadKey();
                System.Console.Clear();
                EscapeRoomList();
            }
            else if (EscapeRoomNumber == "4")
            {
                System.Console.WriteLine("Name: " + Global.EscName4 + "\nDescription: The participants are investigating the disappearance of a young adopted girl,\n             they quickly find out that weird things are happening in her old room.\n             They must solve all of the puzzles and escape or they will be imprisoned in her room forever.\nAge: 16+ \nTime: 60 minutes\nMaximum amount of players: " + Global.EscPlayers4max + "\nLocation: Wijnhaven 107, 3011 WN Rotterdam\n\nContact information:\nPhone number: 010-1234567\nEmail: escape.room@hr.nl\n");
                Colorful.Console.WriteLine("Press any key to continue.", Color.White);
                System.Console.ReadKey();
                System.Console.Clear();
                EscapeRoomList();
            }
            else if (EscapeRoomNumber == "5")
            {
                System.Console.WriteLine("Name: " + Global.EscName5 + "\nDescription: The participants have been locked up by bloodthirsty clowns.\n             They must escape before the clowns return to finish the job.\nAge: 16+\nTime: 60 minutes\nMaximum amount of players: " + Global.EscPlayers5max + "\nLocation: Wijnhaven 107, 3011 WN Rotterdam\n\nContact information:\nPhone number: 010-1234567\nEmail: escape.room@hr.nl\n");
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
            string ReservationEscapeRoomName = "";
            System.Console.Clear();
            Colorful.Console.WriteLine("\nWhat Escape Room would you like to make a reservation for?", Color.White);
            System.Console.WriteLine("(1) " + Global.EscName1 + "\n(2) " + Global.EscName2 + "\n(3) " + Global.EscName3 + "\n(4) " + Global.EscName4 + "\n(5) " + Global.EscName5 + "\n(6) Return to Menu");
            string ReservationEscapeRoomNumber = System.Console.ReadLine();
            if (ReservationEscapeRoomNumber == "1")
            {
                ReservationEscapeRoomName = Global.EscName1;
                Global.ReservationEscapeRoomMaxCount = Global.EscPlayers1max;
            }
            else if (ReservationEscapeRoomNumber == "2")
            {
                ReservationEscapeRoomName = Global.EscName2;
                Global.ReservationEscapeRoomMaxCount = Global.EscPlayers2max;
            }
            else if (ReservationEscapeRoomNumber == "3")
            {
                ReservationEscapeRoomName = Global.EscName3;
                Global.ReservationEscapeRoomMaxCount = Global.EscPlayers3max;
            }
            else if (ReservationEscapeRoomNumber == "4")
            {
                ReservationEscapeRoomName = Global.EscName4;
                Global.ReservationEscapeRoomMaxCount = Global.EscPlayers4max;
            }
            else if (ReservationEscapeRoomNumber == "5")
            {
                ReservationEscapeRoomName = Global.EscName5;
                Global.ReservationEscapeRoomMaxCount = Global.EscPlayers5max;
            }
            else if (ReservationEscapeRoomNumber == "6")
            {
                ClientMenu();
            }
            else
            {
                System.Console.Clear();
                Colorful.Console.WriteLine("Invalid input!", Color.Red);
                System.Console.ReadKey();
                ReservationMenu();

            }

            System.Console.Clear();
            Colorful.Console.WriteFormatted("Placing reservation for: ", Color.White);
            Colorful.Console.WriteLine(ReservationEscapeRoomName, Color.Orange);


            Colorful.Console.WriteLine("\nPlease enter the name you wish to reserve with (first and last name).", Color.White);
            Colorful.Console.WriteLine("Note that you will need this name in order to cancel, make sure to save it.\n", Color.Yellow);
            string ReservationName = System.Console.ReadLine();

            ReservationPlayerCheck();

            System.Console.Clear();
            Colorful.Console.WriteFormatted("\nEscape Room: ", Color.White);
            Colorful.Console.WriteLine(ReservationEscapeRoomName, Color.Yellow);
            Colorful.Console.WriteFormatted("Reservation name: ", Color.White);
            Colorful.Console.WriteLine(ReservationName, Color.Yellow);
            Colorful.Console.WriteFormatted("Amount of people reserved for: ", Color.White);
            Colorful.Console.WriteLine(Global.ReservationPlayerAmount, Color.Yellow);
            Confirm();
        }
        static void Confirm()
        {
            Colorful.Console.WriteLine("\nWould you like to confirm your reservation?\n(1) Confirm \n(2) Cancel");
            string ChoiceNumber = System.Console.ReadLine();
            if (ChoiceNumber == "1")
            {
                Colorful.Console.WriteLine("\nReservation confirmed!", Color.LawnGreen);
                System.Console.ReadKey();
            }
            if (ChoiceNumber == "2")
            {
                Colorful.Console.WriteLine("\nReservation process cancelled\nTaking you back to Menu...", Color.Red);
                System.Console.ReadKey();
                System.Console.Clear();
                ClientMenu();
            }
            else 
            { 5
            System.Console.Clear();
            Colorful.Console.WriteLine("Invalid input!", Color.Red);
            System.Console.ReadKey();
            Confirm();
            }
        }
        

        static void ReservationPlayerCheck()
        // Gets called to handle input for the amount of players on a reservation
        {
            Colorful.Console.WriteLine("\nPlease enter the amount of people you would like to reserve this room for: ", Color.White);
            var PlayerAmount = System.Console.ReadLine();
            if (int.TryParse(PlayerAmount, out int NewNumber))
            {
                Global.ReservationPlayerAmount = NewNumber;
            }
            else
            {
                Colorful.Console.WriteLine("Input is not a valid number", Color.Red);
                ReservationPlayerCheck();
            }
            if (Global.ReservationPlayerAmount > Global.ReservationEscapeRoomMaxCount)
            {
                Colorful.Console.WriteLine("Your reservation exceeds the capacity of this room", Color.Red);
                Colorful.Console.WriteFormatted("The Maximum allowed amount of players is: ", Color.Red);
                Colorful.Console.WriteLine(Global.ReservationEscapeRoomMaxCount, Color.Orange);
                ReservationPlayerCheck();
            }

        }

        static void PasswordCheck()
        // Gets called when the user chooses the 'admin' option.
        {
            string AdminPassword = "Admin";
            if (Attempts < 3)
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
                        System.Environment.Exit(1);
                    }
                    System.Console.Clear();
                    Colorful.Console.WriteLine("Invalid password.", Color.Red);
                    Colorful.Console.WriteLine("What would you like to do? \n(1) Enter password again \n(2) Return to Start Menu", Color.White);
                    string TryAgain = System.Console.ReadLine();
                    if (TryAgain == "1")
                    {
                        System.Console.Clear();
                        PasswordCheck();
                    }
                    else if (TryAgain == "2")
                    {
                        Colorful.Console.Clear();
                        Start();
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
                System.Console.Clear();
                Start();
            }
            else
            {
                System.Console.Clear();
                Colorful.Console.WriteLine("Invalid input!", Color.Red);
                AdminMenu();
            }
        }

        static void EditInfo()
        {
            Colorful.Console.WriteLine("Which escape room would you like to edit? \n", Color.White);
            System.Console.WriteLine("(1) " + Global.EscName1 + "\n(2) "+ Global.EscName2 + "\n(3) " + Global.EscName3 + "\n(4) " + Global.EscName4 + "\n(5) "+ Global.EscName5 + "\n(6) Return");
            string EscapeRoomNumber = System.Console.ReadLine();

            if (EscapeRoomNumber == "1")
            {
                Colorful.Console.WriteLine("What would you like to edit? \n", Color.White);
                System.Console.WriteLine("(1) Name\n(2) Maximum player amount allowed");
                string EditNumber = System.Console.ReadLine();
                if (EditNumber == "1")
                {
                    System.Console.WriteLine("Enter the new name: ");
                    string NewName = System.Console.ReadLine();
                    Global.EscName1 = NewName;
                    EditInfo();
                }
                if (EditNumber == "2")
                {
                    System.Console.WriteLine("Enter the new amount of players: ");
                    var readline = System.Console.ReadLine();
                    if (int.TryParse(readline, out int NewNumber))
                    {
                        Global.EscPlayers1max = NewNumber;
                    }
                    else
                    {
                        Colorful.Console.WriteLine("Input is not a valid number", Color.Red);
                    }
                    EditInfo();
                }
            }
            if (EscapeRoomNumber == "2")
            {
                Colorful.Console.WriteLine("What would you like to edit? \n", Color.White);
                System.Console.WriteLine("(1) Name\n(2) Maximum player amount allowed");
                string EditNumber = System.Console.ReadLine();
                if (EditNumber == "1")
                {
                    System.Console.WriteLine("Type the new name here: ");
                    string NewName = System.Console.ReadLine();
                    Global.EscName2 = NewName;
                    EditInfo();
                }
                if (EditNumber == "2")
                {
                    System.Console.WriteLine("Enter the new amount of players: ");
                    var readline = System.Console.ReadLine();
                    if (int.TryParse(readline, out int NewNumber))
                    {
                        Global.EscPlayers1max = NewNumber;
                    }
                    else
                    {
                        Colorful.Console.WriteLine("Input is not a valid number", Color.Red);
                    }
                    EditInfo();
                }
            }
            if (EscapeRoomNumber == "3")
            {
                Colorful.Console.WriteLine("What would you like to edit? \n", Color.White);
                System.Console.WriteLine("(1) Name\n(2) Maximum player amount allowed");
                string EditNumber = System.Console.ReadLine();
                if (EditNumber == "1")
                {
                    System.Console.WriteLine("Type the new name here: ");
                    string NewName = System.Console.ReadLine();
                    Global.EscName3 = NewName;
                    EditInfo();
                }
                if (EditNumber == "2")
                {
                    System.Console.WriteLine("Enter the new amount of players: ");
                    var readline = System.Console.ReadLine();
                    if (int.TryParse(readline, out int NewNumber))
                    {
                        Global.EscPlayers1max = NewNumber;
                    }
                    else
                    {
                        Colorful.Console.WriteLine("Input is not a valid number", Color.Red);
                    }
                    EditInfo();
                }
            }
            if (EscapeRoomNumber == "4")
            {
                Colorful.Console.WriteLine("What would you like to edit?\n", Color.White);
                System.Console.WriteLine("(1) Name\n(2) Maximum player amount allowed");
                string EditNumber = System.Console.ReadLine();
                if (EditNumber == "1")
                {
                    System.Console.WriteLine("Type the new name here: ");
                    string NewName = System.Console.ReadLine();
                    Global.EscName4 = NewName;
                    EditInfo();
                }
                if (EditNumber == "2")
                {
                    System.Console.WriteLine("Enter the new amount of players: ");
                    var readline = System.Console.ReadLine();
                    if (int.TryParse(readline, out int NewNumber))
                    {
                        Global.EscPlayers1max = NewNumber;
                    }
                    else
                    {
                        Colorful.Console.WriteLine("Input is not a valid number", Color.Red);
                    }
                    EditInfo();
                }
            }
            if (EscapeRoomNumber == "5")
            {
                Colorful.Console.WriteLine("What would you like to edit? \n", Color.White);
                System.Console.WriteLine("(1) Name\n(2) Maximum player amount allowed");
                string EditNumber = System.Console.ReadLine();
                if (EditNumber == "1")
                {
                    System.Console.WriteLine("Type the new name here: ");
                    string NewName = System.Console.ReadLine();
                    Global.EscName5 = NewName;
                    EditInfo();
                }
                if (EditNumber == "2")
                {
                    System.Console.WriteLine("Enter the new amount of players: ");
                    var readline = System.Console.ReadLine();
                    if (int.TryParse(readline, out int NewNumber))
                    {
                        Global.EscPlayers1max = NewNumber;
                    }
                    else
                    {
                        Colorful.Console.WriteLine("Input is not a valid number", Color.Red);
                    }
                    EditInfo();
                }
            }
            if (EscapeRoomNumber == "6")
            {
                AdminMenu();
            }
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
