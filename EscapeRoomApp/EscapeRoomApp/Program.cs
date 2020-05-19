using System;
using System.Collections.Generic;
using Colorful;
using System.Drawing;
using Newtonsoft.Json;
using System.IO;
using System.Globalization;

namespace EscapeRoomApp
{
    public class Program
    {
        public static int Attempts;
        public static List<ReservationClass> ReservationList = new List<ReservationClass>();
        public static string filePath = Environment.CurrentDirectory + @"\Reservations.json";
        public static string filePath2 = Environment.CurrentDirectory + @"\ChangePassword.json";

        public static void Main()
        //Beginning function.
        {
            if (File.Exists(filePath))
            {
                Deserialize();
            }
            else if (!File.Exists(filePath))
            {
                Save();
            }
            Start();
        }

        static void Start()
        // Gets called at the start of the program.
        {
            System.Console.Clear();
            Colorful.Console.WriteLine("Welcome to the Escape Room Application.\n", Color.LawnGreen);
            Colorful.Console.WriteLine("What would you look to do?", Color.White);
            System.Console.WriteLine("(1) View our Escape Rooms\n(2) Cancel a reservation\n(3) Log-in as Admin\n(4) Exit");

            string UserType = System.Console.ReadLine();

            if (UserType == "1")
            {
                System.Console.Clear();
                Colorful.Console.WriteLine("Below you will find a list of our Escape Rooms.\n", Color.White);
                EscapeRoomList();
            }
            else if (UserType == "2")
            {
                CancelReservationMenu();
            }
            else if (UserType == "3")
            {
                System.Console.Clear();
                PasswordCheck();
            }
            else if (UserType == "4")
            {
                System.Environment.Exit(0);
            }
            else
            {
                System.Console.Clear();
                Colorful.Console.WriteLine("Invalid input!\n", Color.Red);
                Start();
            }
        }


        /*static void ClientMenu()
        // Gets called when the user chooses the 'client' option.
        {
            System.Console.Clear();
            Colorful.Console.WriteLine("Welcome Client.\n", Color.LawnGreen);
            Colorful.Console.WriteLine("What would you like to do?", Color.White);
            System.Console.WriteLine("(1) Discover our Escape Rooms\n(2) Reserve an Escape Room\n(3) Cancel a reservation\n(4) Return to Start Menu");
            string ClientAction = System.Console.ReadLine();
        }*/


        static void EscapeRoomList()
        //Gets called when the user chooses the option to check out the escape rooms.
        {
            Colorful.Console.WriteLine("Which Escape Room would you like to check out?\n", Color.White);
            System.Console.WriteLine(
               "(1) " + Global.EscName1 + "\n" +
               "(2) " + Global.EscName2 + "\n" +
               "(3) " + Global.EscName3 + "\n" +
               "(4) " + Global.EscName4 + "\n" +
               "(5) " + Global.EscName5 + "\n" +
               "(6) Return to Menu");
            string EscapeRoomNumber = System.Console.ReadLine();
            System.Console.Clear();
            string Input = "";
            if (EscapeRoomNumber == "1")
            {
                System.Console.WriteLine(
                    "Name: " + Global.EscName1 + "\n" +
                    "Description: The participants have accidentally been locked in a room by clumsy clowns.\n" +
                    "             The participants must escape the room in order to make it to the circus show on time.\n" +
                    "Age: Children" + "\n" +
                    "Time: 60 minutes" + "\n" +
                    "Amount of players: " + Global.EscPlayers1min + "-" + Global.EscPlayers1max + "\n" +
                    "Open from: " + Global.Esc1_OpeningTime.ToString("HH:mm") + " - " + Global.Esc1_ClosingTime.ToString("HH:mm") + "\n" +
                    "Location: Wijnhaven 107, 3011 WN Rotterdam" + "\n" +
                    "\nContact information:\n" +
                    "Phone number: 010-1234567\nEmail: escape.room@hr.nl\n");
                Colorful.Console.WriteLine("\nWhat would you like to do?", Color.White);
                System.Console.WriteLine("(1) Place a reservation for this Escape Room \n(2) Return");
                Input = System.Console.ReadLine();
                if (Input == "1")
                {
                    Global.ReservationEscapeRoomNumber = EscapeRoomNumber;
                    ReservationMenu();
                }
                else
                {
                    System.Console.Clear();
                    EscapeRoomList();
                }
            }
            else if (EscapeRoomNumber == "2")
            {
                System.Console.WriteLine(
                    "Name: " + Global.EscName2 + "\n" +
                    "Description: The innocent participants have been imprisoned by a corrupt police officer." + "\n" +
                    "             They must escape with the evidence the police officer is trying to hide so that he can be arrested.\n" +
                    "Age: All ages \n" +
                    "Time: 60 minutes \n" +
                    "Amount of players: " + Global.EscPlayers2min + "-" + Global.EscPlayers2max + "\n" +
                    "Open from: " + Global.Esc2_OpeningTime.ToString("HH:mm") + " - " + Global.Esc2_ClosingTime.ToString("HH:mm") + "\n" +
                    "Location: Wijnhaven 107, 3011 WN Rotterdam\n" + "\n" +
                    "Contact information:\n" +
                    "Phone number: 010-1234567 \n" +
                    "Email: escape.room@hr.nl\n");
                Colorful.Console.WriteLine("\nWhat would you like to do?", Color.White);
                System.Console.WriteLine("(1) Place a reservation for this Escape Room \n(2) Return");
                Input = System.Console.ReadLine();
                if (Input == "1")
                {
                    Global.ReservationEscapeRoomNumber = EscapeRoomNumber;
                    ReservationMenu();
                }
                else
                {
                    System.Console.Clear();
                    EscapeRoomList();
                }
            }
            else if (EscapeRoomNumber == "3")
            {
                System.Console.WriteLine(
                    "Name: " + Global.EscName3 + "\n" +
                    "Description: The bank robbers have locked themselves in the bank vault at night.\n" +
                    "             They must get out of the vault with all of the money before they're discovered and arrested by the police.\n" +
                    "Age: All ages \n" +
                    "Time: 60 minutes \n" +
                    "Amount of players: " + Global.EscPlayers3min + "-" + Global.EscPlayers3max + "\n" +
                    "Open from: " + Global.Esc3_OpeningTime.ToString("HH:mm") + " - " + Global.Esc3_ClosingTime.ToString("HH:mm") + "\n" +
                    "Location: Wijnhaven 107, 3011 WN Rotterdam \n" + "\n" +
                    "Contact information:\n" +
                    "Phone number: 010-1234567 \n" +
                    "Email: escape.room@hr.nl\n");
                Colorful.Console.WriteLine("\nWhat would you like to do?", Color.White);
                System.Console.WriteLine("(1) Place a reservation for this Escape Room \n(2) Return");
                Input = System.Console.ReadLine();
                if (Input == "1")
                {
                    Global.ReservationEscapeRoomNumber = EscapeRoomNumber;
                    ReservationMenu();
                }
                else
                {
                    System.Console.Clear();
                    EscapeRoomList();
                }
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
                    "Amount of players: " + Global.EscPlayers4min + "-" + Global.EscPlayers4max + "\n" +
                    "Open from: " + Global.Esc4_OpeningTime.ToString("HH:mm") + " - " + Global.Esc4_ClosingTime.ToString("HH:mm") + "\n" +
                    "Location: Wijnhaven 107, 3011 WN Rotterdam \n" + "\n" +
                    "Contact information: \n" +
                    "Phone number: 010-1234567 \n" +
                    "Email: escape.room@hr.nl\n");
                Colorful.Console.WriteLine("\nWhat would you like to do?", Color.White);
                System.Console.WriteLine("(1) Place a reservation for this Escape Room \n(2) Return");
                Input = System.Console.ReadLine();
                if (Input == "1")
                {
                    Global.ReservationEscapeRoomNumber = EscapeRoomNumber;
                    ReservationMenu();
                }
                else
                {
                    System.Console.Clear();
                    EscapeRoomList();
                }
            }
            else if (EscapeRoomNumber == "5")
            {
                System.Console.WriteLine(
                    "Name: " + Global.EscName5 + "\n" +
                    "Description: The participants have been locked up by bloodthirsty clowns. \n" +
                    "             They must escape before the clowns return to finish the job. \n" +
                    "Age: 16+ \n" +
                    "Time: 60 minutes \n" +
                    "Amount of players: " + Global.EscPlayers5min + "-" + Global.EscPlayers5max + "\n" +
                    "Open from: " + Global.Esc5_OpeningTime.ToString("HH:mm") + " - " + Global.Esc5_ClosingTime.ToString("HH:mm") + "\n" +
                    "Location: Wijnhaven 107, 3011 WN Rotterdam \n" + "\n" +
                    "Contact information: \n" +
                    "Phone number: 010-1234567 \n" +
                    "Email: escape.room@hr.nl\n");
                Colorful.Console.WriteLine("\nWhat would you like to do?", Color.White);
                System.Console.WriteLine("(1) Place a reservation for this Escape Room \n(2) Return");
                Input = System.Console.ReadLine();
                if (Input == "1")
                {
                    Global.ReservationEscapeRoomNumber = EscapeRoomNumber;
                    ReservationMenu();
                }
                else
                {
                    System.Console.Clear();
                    EscapeRoomList();
                }
            }
            else if (EscapeRoomNumber == "6")
            {
                Start();
            }
            else
            {
                Colorful.Console.WriteLine("Invalid input!", Color.Red);
                EscapeRoomList();
            }
        }


        public static void ReservationMenu()
        {
            string Input_ReservationEscapeRoomName = Global.ReservationEscapeRoomNumber;
            System.Console.Clear();
            if (Global.ReservationEscapeRoomNumber == "1")
            {
                Input_ReservationEscapeRoomName = Global.EscName1;
                Global.ReservationEscapeRoomMaxCount = Global.EscPlayers1max;
                Global.ReservationEscapeRoomMinCount = Global.EscPlayers1min;
            }
            else if (Global.ReservationEscapeRoomNumber == "2")
            {
                Input_ReservationEscapeRoomName = Global.EscName2;
                Global.ReservationEscapeRoomMaxCount = Global.EscPlayers2max;
                Global.ReservationEscapeRoomMinCount = Global.EscPlayers2min;
            }
            else if (Global.ReservationEscapeRoomNumber == "3")
            {
                Input_ReservationEscapeRoomName = Global.EscName3;
                Global.ReservationEscapeRoomMaxCount = Global.EscPlayers3max;
                Global.ReservationEscapeRoomMinCount = Global.EscPlayers3min;
            }
            else if (Global.ReservationEscapeRoomNumber == "4")
            {
                Input_ReservationEscapeRoomName = Global.EscName4;
                Global.ReservationEscapeRoomMaxCount = Global.EscPlayers4max;
                Global.ReservationEscapeRoomMinCount = Global.EscPlayers4min;
            }
            else if (Global.ReservationEscapeRoomNumber == "5")
            {
                Input_ReservationEscapeRoomName = Global.EscName5;
                Global.ReservationEscapeRoomMaxCount = Global.EscPlayers5max;
                Global.ReservationEscapeRoomMinCount = Global.EscPlayers5min;
            }
            else if (Global.ReservationEscapeRoomNumber == "6")
            {
                Start();
            }

            System.Console.Clear();
            Colorful.Console.WriteFormatted("Placing reservation for: ", Color.White);
            Colorful.Console.WriteLine(Input_ReservationEscapeRoomName, Color.Orange);


            Colorful.Console.WriteLine("\nPlease enter the name you wish to reserve with (first and last name).", Color.White);
            Colorful.Console.WriteLine("Note that you will need this name in order to cancel, make sure to save it.\n", Color.Yellow);
            string Input_ReservationName = System.Console.ReadLine();

            ReservationPlayerCheck();

            Colorful.Console.WriteLine("\nPlease enter the date for your reservation:", Color.White);
            Colorful.Console.WriteLine("Dates are entered as \"day-month-year\"\n", Color.Yellow);
            Colorful.Console.Write("Enter the day of the month: ");
            string Input_ReservationDate_Day = System.Console.ReadLine();
            Colorful.Console.Write("Enter the month (0-12): ");
            string Input_ReservationDate_Month = System.Console.ReadLine();
            Colorful.Console.Write("Enter the year: ");
            string Input_ReservationDate_Year = System.Console.ReadLine();
            string Input_ReservationDate = Input_ReservationDate_Day + "-" + Input_ReservationDate_Month + "-" + Input_ReservationDate_Year;

            System.Console.Clear();
            Colorful.Console.WriteFormatted("\nEscape Room: ", Color.White);
            Colorful.Console.WriteLine(Input_ReservationEscapeRoomName, Color.Yellow);
            Colorful.Console.WriteFormatted("Reservation name: ", Color.White);
            Colorful.Console.WriteLine(Input_ReservationName, Color.Yellow);
            Colorful.Console.WriteFormatted("Amount of people reserved for: ", Color.White);
            Colorful.Console.WriteLine(Global.ReservationPlayerAmount, Color.Yellow);
            Colorful.Console.WriteFormatted("Date reserved for: ", Color.White);
            Colorful.Console.WriteLine(Input_ReservationDate, Color.Yellow);
            if (Confirm())
            {
                ReservationClass Reservation = new ReservationClass
                    (Input_ReservationName, Input_ReservationEscapeRoomName, Global.ReservationPlayerAmount, Input_ReservationDate);
                ReservationList.Add(Reservation);

                Save();

                Colorful.Console.WriteLine("You have made a reservation for " + Global.ReservationPlayerAmount + " players for \"" + Input_ReservationEscapeRoomName +
                    "\"", Color.LawnGreen);
                System.Console.ReadKey();
            }
            Start();

        }
        static bool Confirm()
        {
            Colorful.Console.WriteLine("\nWould you like to confirm your reservation?\n(1) Confirm \n(2) Cancel");
            string ChoiceNumber = System.Console.ReadLine();
            if (ChoiceNumber == "1")
            {
                Colorful.Console.WriteLine("\nReservation confirmed!", Color.LawnGreen);
                return true;
            }
            if (ChoiceNumber == "2")
            {
                Colorful.Console.WriteLine("\nReservation process cancelled\nTaking you back to Client Menu...", Color.Red);
                System.Console.ReadKey();
                System.Console.Clear();
                return false;
            }
            else
            {
                System.Console.Clear();
                Colorful.Console.WriteLine("Invalid input!", Color.Red);
                System.Console.ReadKey();
                return Confirm();
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

        public static void CancelReservationMenu()
        {
            int count = 0;
            System.Console.Clear();
            Colorful.Console.WriteLine("Please enter the name you have placed your reservation under: ", Color.White);
            string CancellationName = System.Console.ReadLine();
            foreach (var n in ReservationList)
            {
                if (n.ReservationName == CancellationName)
                {
                    System.Console.Clear();
                    Colorful.Console.WriteFormatted("The following reservations have been made under the name ", Color.White);
                    Colorful.Console.WriteFormatted(CancellationName, Color.Yellow);
                    Colorful.Console.WriteLine(":", Color.White);
                    System.Console.WriteLine(n.ReservationName + " made a reservation for " + n.ReservationPlayerAmount + " players for " + n.ReservationEscapeRoomName + " for date of " + n.ReservationDate + "\n");
                    count++;
                }
            }
            if (count == 0)
            {
                System.Console.Clear();
                Colorful.Console.WriteFormatted("Sorry, no reservation has been found under the name ", Color.White);
                Colorful.Console.WriteLine(CancellationName, Color.Yellow);
                System.Console.ReadKey();
                Start();
            }
            else if (count > 0)
            {
                if (ConfirmCancellation())
                {
                    foreach (var n in ReservationList)
                    {
                        if (n.ReservationName == CancellationName)
                        {
                            n.ReservationName = null;
                            n.ReservationEscapeRoomName = null;
                            n.ReservationPlayerAmount = 0;
                            n.ReservationDate = null;
                            Save();
                            Start();
                        }
                    }
                }
            }
        }


        static bool ConfirmCancellation()
        {
            Colorful.Console.WriteLine("Are you sure you want to delete your reservation?", Color.White);
            System.Console.WriteLine("(1) Confirm\n(2) Cancel");
            string confirm = System.Console.ReadLine();
            if (confirm == "1")
            {
                System.Console.Clear();
                Colorful.Console.WriteLine("Reservation cancelled", Color.White);
                System.Console.ReadKey();
                return true;
            }
            else if (confirm == "2")
            {
                System.Console.Clear();
                Colorful.Console.WriteLine("Cancellation aborted, returning to home menu", Color.White);
                System.Console.ReadKey();
                return false;
            }
            else
            {
                Colorful.Console.WriteLine("Invalid input!", Color.Red);
                return ConfirmCancellation();
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
                    Attempts = 0;
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
            System.Console.Clear();
            Colorful.Console.WriteLine("Welcome Admin \n", Color.LawnGreen);
            Colorful.Console.WriteLine("What do you wish to do?\n", Color.White);
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
            if (AdminChoice == "2")
            {
                System.Console.Clear();
                Colorful.Console.WriteLine("The following reservations have been made: \n", Color.White);
                foreach (var n in ReservationList)
                {
                    if (n.ReservationName != null)
                    {
                        System.Console.WriteLine(n.ReservationName + " made a reservation for " + n.ReservationPlayerAmount + " players for " + n.ReservationEscapeRoomName + " for date of " + n.ReservationDate);
                    }
                }
                System.Console.ReadKey();
                AdminMenu();
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
                "(2) " + Global.EscName2 + "\n" +
                "(3) " + Global.EscName3 + "\n" +
                "(4) " + Global.EscName4 + "\n" +
                "(5) " + Global.EscName5 + "\n" +
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
                    Global.EscName1 = NewName;
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
                    Global.EscName3 = NewName;
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
                    "(3) Minimum players allowed \n" +
                    "(4) Change the admin password");
                string EditNumber = System.Console.ReadLine();

                if (EditNumber == "1")
                {
                    System.Console.WriteLine("\nType the new name here: ");
                    string NewName = System.Console.ReadLine();
                    Global.EscName4 = NewName;
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
                        else if (EditNumber == "4")
                        {
                            ChangePassword();
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
                    Global.EscName5 = NewName;
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


        static void ChangePassword()
        //Gets called when the admin chooses option 4 in AdminMenu
        {
            string jsonString = Global.AdminPassword;
            jsonString = JsonConvert.SerializeObject(jsonString);
            File.WriteAllText(filePath2, jsonString);
            Colorful.Console.WriteLine("Please enter the current password:", Color.White);
            string CurrentPasswordCheck = System.Console.ReadLine();
            if (CurrentPasswordCheck == Global.AdminPassword)
            {

            }
        }


        static void Save()
        {
            string jsonString;
            jsonString = JsonConvert.SerializeObject(ReservationList, Formatting.Indented);
            File.WriteAllText(filePath, jsonString);
        }
        public static void Deserialize()
        {
            ReservationList = JsonConvert.DeserializeObject<List<ReservationClass>>(File.ReadAllText(filePath));
        }
    }
}
