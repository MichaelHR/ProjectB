using System;
using System.Collections.Generic;
using Colorful;
using System.Drawing;

namespace EscapeRoomApp
{
    public static class Global
    {
        // Names for each Escape Room
        public static string EscName1 = "Clumsy Clowns";
        public static string EscName2 = "Hidden Evidence";
        public static string EscName3 = "Bank Job";
        public static string EscName4 = "Up for Adoption";
        public static string EscName5 = "Killer Clowns";

        // Maximum players for each Escape Room
        public static int EscPlayers1max = 8;
        public static int EscPlayers2max = 5;
        public static int EscPlayers3max = 6;
        public static int EscPlayers4max = 7;
        public static int EscPlayers5max = 5;

        // Minimum players for each Escape Room
        public static int EscPlayers1min = 3;
        public static int EscPlayers2min = 2;
        public static int EscPlayers3min = 3;
        public static int EscPlayers4min = 3;
        public static int EscPlayers5min = 2;

        // Reservation general info
        public static int ReservationPlayerAmount = 0;
        public static int ReservationEscapeRoomMaxCount = 0;
        public static int ReservationEscapeRoomMinCount = 0;

    }
    class Program
    {
        public static int Attempts;

        static void Main()
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
            System.Console.WriteLine(
               "(1) " + Global.EscName1 + "\n" +
               "(2) " + Global.EscName2 + "\n" +
               "(3) " + Global.EscName3 + "\n" +
               "(4) " + Global.EscName4 + "\n" +
               "(5) " + Global.EscName5 + "\n" +
               "(6) Return to Menu");
            string EscapeRoomNumber = System.Console.ReadLine();
            System.Console.Clear();
            if (EscapeRoomNumber == "1")
            {
                System.Console.WriteLine(
                    "Name: " + Global.EscName1 + "\n" + 
                    "Description: The participants have accidentally been locked in a room by clumsy clowns.\n" +
                    "             The participants must escape the room in order to make it to the circus show on time.\n" +
                    "Age: Children" + "\n" +
                    "Time: 60 minutes" + "\n" +
                    "Maximum amount of players: " + Global.EscPlayers1max + "\n" +
                    "Minimum amount of players: " + Global.EscPlayers1min + "\n" +
                    "Location: Wijnhaven 107, 3011 WN Rotterdam" + "\n" +
                    "\nContact information:\n" + 
                    "Phone number: 010-1234567\nEmail: escape.room@hr.nl\n");
                Colorful.Console.WriteLine("Press any key to continue.", Color.White);
                System.Console.ReadKey();
                System.Console.Clear();
                EscapeRoomList();
            }
            else if (EscapeRoomNumber == "2")
            {
                System.Console.WriteLine(
                    "Name: " + Global.EscName2 + "\n" +
                    "Description: The innocent participants have been imprisoned by a corrupt police officer." + "\n" +
                    "             They must escape with the evidence the police officer is trying to hide so that he can be arrested.\n" +
                    "Age: All ages \n" +
                    "Time: 60 minutes \n" +
                    "Maximum amount of players: " + Global.EscPlayers2max + "\n" +
                    "Minimum amount of players: " + Global.EscPlayers2min + "\n" +
                    "Location: Wijnhaven 107, 3011 WN Rotterdam\n" + "\n" +
                    "Contact information:\n" +
                    "Phone number: 010-1234567 \n" +
                    "Email: escape.room@hr.nl\n");
                Colorful.Console.WriteLine("Press any key to continue.", Color.White);
                System.Console.ReadKey();
                System.Console.Clear();
                EscapeRoomList();
            }
            else if (EscapeRoomNumber == "3")
            {
                System.Console.WriteLine(
                    "Name: " + Global.EscName3 + "\n" +
                    "Description: The bank robbers have locked themselves in the bank vault at night.\n" +
                    "             They must get out of the vault with all of the money before they're discovered and arrested by the police.\n" +
                    "Age: All ages \n" +
                    "Time: 60 minutes \n" +
                    "Maximum amount of players: " + Global.EscPlayers3max + "\n" +
                    "Minimum amount of players: " + Global.EscPlayers3min + "\n" +
                    "Location: Wijnhaven 107, 3011 WN Rotterdam \n" + "\n" + 
                    "Contact information:\n" +
                    "Phone number: 010-1234567 \n" +
                    "Email: escape.room@hr.nl\n");
                Colorful.Console.WriteLine("Press any key to continue.", Color.White);
                System.Console.ReadKey();
                System.Console.Clear();
                EscapeRoomList();
            }
            else if (EscapeRoomNumber == "4")
            {
                System.Console.WriteLine(
                    "Name: " + Global.EscName4 + "\n" +
                    "Description: The participants are investigating the disappearance of a young adopted girl, \n" +
                    "             they quickly find out that weird things are happening in her old room. \n" +
                    "             They must solve all of the puzzles and escape or they will be imprisoned in her room forever. \n" +
                    "Age: 16+ \n" +
                    "Time: 60 minutes \n" +
                    "Maximum amount of players: " + Global.EscPlayers4max + "\n" +
                    "Minimum amount of players: " + Global.EscPlayers4min + "\n" +
                    "Location: Wijnhaven 107, 3011 WN Rotterdam \n" + "\n" +
                    "Contact information: \n" +
                    "Phone number: 010-1234567 \n" +
                    "Email: escape.room@hr.nl\n");
                Colorful.Console.WriteLine("Press any key to continue.", Color.White);
                System.Console.ReadKey();
                System.Console.Clear();
                EscapeRoomList();
            }
            else if (EscapeRoomNumber == "5")
            {
                System.Console.WriteLine(
                    "Name: " + Global.EscName5 + "\n" +
                    "Description: The participants have been locked up by bloodthirsty clowns. \n" +
                    "             They must escape before the clowns return to finish the job. \n" +
                    "Age: 16+ \n" +
                    "Time: 60 minutes \n" +
                    "Maximum amount of players: " + Global.EscPlayers5max + "\n" +
                    "Minimum amount of players: " + Global.EscPlayers5min + "\n" +
                    "Location: Wijnhaven 107, 3011 WN Rotterdam \n" + "\n" + 
                    "Contact information: \n" +
                    "Phone number: 010-1234567 \n" +
                    "Email: escape.room@hr.nl\n");
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
                Global.ReservationEscapeRoomMinCount = Global.EscPlayers1min;
            }
            else if (ReservationEscapeRoomNumber == "2")
            {
                ReservationEscapeRoomName = Global.EscName2;
                Global.ReservationEscapeRoomMaxCount = Global.EscPlayers2max;
                Global.ReservationEscapeRoomMinCount = Global.EscPlayers2min;
            }
            else if (ReservationEscapeRoomNumber == "3")
            {
                ReservationEscapeRoomName = Global.EscName3;
                Global.ReservationEscapeRoomMaxCount = Global.EscPlayers3max;
                Global.ReservationEscapeRoomMinCount = Global.EscPlayers3min;
            }
            else if (ReservationEscapeRoomNumber == "4")
            {
                ReservationEscapeRoomName = Global.EscName4;
                Global.ReservationEscapeRoomMaxCount = Global.EscPlayers4max;
                Global.ReservationEscapeRoomMinCount = Global.EscPlayers4min;
            }
            else if (ReservationEscapeRoomNumber == "5")
            {
                ReservationEscapeRoomName = Global.EscName5;
                Global.ReservationEscapeRoomMaxCount = Global.EscPlayers5max;
                Global.ReservationEscapeRoomMinCount = Global.EscPlayers5min;
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
                System.Environment.Exit(1);
            }
            if (ChoiceNumber == "2")
            {
                Colorful.Console.WriteLine("\nReservation process cancelled\nTaking you back to Client Menu...", Color.Red);
                System.Console.ReadKey();
                System.Console.Clear();
                ClientMenu();
            }
            else 
            { 
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
                Colorful.Console.WriteLine("\nYour reservation exceeds the capacity of this room", Color.Red);
                Colorful.Console.WriteFormatted("The maximum allowed capacity for this room is: ", Color.Red);
                Colorful.Console.WriteLine(Global.ReservationEscapeRoomMaxCount + " players", Color.Orange);
                ReservationPlayerCheck();
            }
            if (Global.ReservationPlayerAmount < Global.ReservationEscapeRoomMinCount)
            {
                Colorful.Console.WriteLine("\nYour reservation does not meet the minimum player requirement", Color.Red);
                Colorful.Console.WriteFormatted("The minimum amount of players required is: ", Color.Red);
                Colorful.Console.WriteLine(Global.ReservationEscapeRoomMinCount + " players", Color.Orange);
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
            System.Console.WriteLine("" +
                "(1) Edit Escape Room information \n" +
                "(2) Check the reservations \n" +
                "(3) Log-out as Admin");

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
            System.Console.Clear();
            Colorful.Console.WriteLine("\nWhich escape room would you like to edit? \n", Color.White);
            System.Console.WriteLine("" +
                "(1) " + Global.EscName1 + "\n" +
                "(2) "+ Global.EscName2 + "\n" +
                "(3) " + Global.EscName3 + "\n" +
                "(4) " + Global.EscName4 + "\n" +
                "(5) "+ Global.EscName5 + "\n" +
                "(6) Return");
            string EscapeRoomNumber = System.Console.ReadLine();

            if (EscapeRoomNumber == "1")
            {
                System.Console.Clear();
                Colorful.Console.WriteLine("What would you like to edit? \n", Color.White);
                System.Console.WriteLine(
                    "(1) Escape Room Name \n" +
                    "(2) Maximum players allowed \n" +
                    "(3) Minimum players allowed");
                string EditNumber = System.Console.ReadLine();

                if (EditNumber == "1")
                {
                    System.Console.WriteLine("\nType the new name here: ");
                    string NewName = System.Console.ReadLine();
                    Global.EscName2 = NewName;
                    EditInfo();
                }
                if (EditNumber == "2" || EditNumber == "3")
                {
                    System.Console.WriteLine("\nEnter the new amount of players: ");
                    var readline = System.Console.ReadLine();
                    if (int.TryParse(readline, out int NewNumber))
                    {
                        if (EditNumber == "2")
                        {
                            Global.EscPlayers1max = NewNumber;
                        }
                        else if (EditNumber == "3")
                        {
                            Global.EscPlayers1min = NewNumber;
                        }
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
                System.Console.Clear();
                Colorful.Console.WriteLine("What would you like to edit? \n", Color.White);
                System.Console.WriteLine(
                    "(1) Escape Room Name \n" +
                    "(2) Maximum players allowed \n" +
                    "(3) Minimum players allowed");
                string EditNumber = System.Console.ReadLine();

                if (EditNumber == "1")
                {
                    System.Console.WriteLine("\nType the new name here: ");
                    string NewName = System.Console.ReadLine();
                    Global.EscName2 = NewName;
                    EditInfo();
                }
                if (EditNumber == "2" || EditNumber == "3")
                {
                    System.Console.WriteLine("\nEnter the new amount of players: ");
                    var readline = System.Console.ReadLine();
                    if (int.TryParse(readline, out int NewNumber))
                    {
                        if (EditNumber == "2")
                        {
                            Global.EscPlayers2max = NewNumber;
                        }
                        else if (EditNumber == "3")
                        {
                            Global.EscPlayers2min = NewNumber;
                        }
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
                System.Console.Clear();
                Colorful.Console.WriteLine("What would you like to edit? \n", Color.White);
                System.Console.WriteLine(
                    "(1) Escape Room Name \n" +
                    "(2) Maximum players allowed \n" +
                    "(3) Minimum players allowed");
                string EditNumber = System.Console.ReadLine();

                if (EditNumber == "1")
                {
                    System.Console.WriteLine("\nType the new name here: ");
                    string NewName = System.Console.ReadLine();
                    Global.EscName2 = NewName;
                    EditInfo();
                }
                if (EditNumber == "2" || EditNumber == "3")
                {
                    System.Console.WriteLine("\nEnter the new amount of players: ");
                    var readline = System.Console.ReadLine();
                    if (int.TryParse(readline, out int NewNumber))
                    {
                        if (EditNumber == "2")
                        {
                            Global.EscPlayers3max = NewNumber;
                        }
                        else if (EditNumber == "3")
                        {
                            Global.EscPlayers3min = NewNumber;
                        }
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
                System.Console.Clear();
                Colorful.Console.WriteLine("What would you like to edit? \n", Color.White);
                System.Console.WriteLine(
                    "(1) Escape Room Name \n" +
                    "(2) Maximum players allowed \n" +
                    "(3) Minimum players allowed");
                string EditNumber = System.Console.ReadLine();

                if (EditNumber == "1")
                {
                    System.Console.WriteLine("\nType the new name here: ");
                    string NewName = System.Console.ReadLine();
                    Global.EscName2 = NewName;
                    EditInfo();
                }
                if (EditNumber == "2" || EditNumber == "3")
                {
                    System.Console.WriteLine("\nEnter the new amount of players: ");
                    var readline = System.Console.ReadLine();
                    if (int.TryParse(readline, out int NewNumber))
                    {
                        if (EditNumber == "2")
                        {
                            Global.EscPlayers4max = NewNumber;
                        }
                        else if (EditNumber == "3")
                        {
                            Global.EscPlayers4min = NewNumber;
                        }
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
                System.Console.Clear();
                Colorful.Console.WriteLine("What would you like to edit? \n", Color.White);
                System.Console.WriteLine(
                    "(1) Escape Room Name \n" +
                    "(2) Maximum players allowed \n" +
                    "(3) Minimum players allowed");
                string EditNumber = System.Console.ReadLine();

                if (EditNumber == "1")
                {
                    System.Console.WriteLine("\nType the new name here: ");
                    string NewName = System.Console.ReadLine();
                    Global.EscName2 = NewName;
                    EditInfo();
                }
                if (EditNumber == "2" || EditNumber == "3")
                {
                    System.Console.WriteLine("\nEnter the new amount of players: ");
                    var readline = System.Console.ReadLine();
                    if (int.TryParse(readline, out int NewNumber))
                    {
                        if (EditNumber == "2")
                        {
                            Global.EscPlayers5max = NewNumber;
                        }
                        else if (EditNumber == "3")
                        {
                            Global.EscPlayers5min = NewNumber;
                        }
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
                System.Console.Clear();
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
