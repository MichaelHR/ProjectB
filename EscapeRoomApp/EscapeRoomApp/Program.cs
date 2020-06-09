using System;
using System.Collections.Generic;
using System.Drawing;
using Newtonsoft.Json;
using System.IO;
using System.Linq;

namespace EscapeRoomApp
{
    public class Program
    {
        //Sets up the opening & closing hours for the five escape rooms
        public static EscapeRoom EscapeRoom1 = new EscapeRoom(1200, 2100, 100);
        public static EscapeRoom EscapeRoom2 = new EscapeRoom(1200, 2100, 100);
        public static EscapeRoom EscapeRoom3 = new EscapeRoom(1700, 2400, 100);
        public static EscapeRoom EscapeRoom4 = new EscapeRoom(1700, 2400, 100);
        public static EscapeRoom EscapeRoom5 = new EscapeRoom(1700, 2400, 100);

        //Counter for login attempts into admin menu
        public static int Attempts;

        //Sets up ReservationList and filePaths for serialization later down in the program
        public static List<ReservationClass> ReservationList = new List<ReservationClass>();
        public static string filePath = Environment.CurrentDirectory + @"\Reservations.json";
        public static string filePath2 = Environment.CurrentDirectory + @"\Password.json";

        public static void Main()
        //Beginning function.
        {
            //Loads the timeslots for the EscapeRooms
            AddTimes(EscapeRoom1);
            AddTimes(EscapeRoom2);
            AddTimes(EscapeRoom3);
            AddTimes(EscapeRoom4);
            AddTimes(EscapeRoom5);

            //If a Reservation.json file exists, it will read it and deserialize (if not: create empty file)
            if (File.Exists(filePath))
            {
                Deserialize();
            }
            else if (!File.Exists(filePath))
            {
                Save();
            }

            if (!File.Exists(filePath2))
            {
                var jsonString = System.Text.Json.JsonSerializer.Serialize("Admin");
                File.WriteAllText(filePath2, jsonString);
            }

            Start();
        }

        static void Start()
        // Gets called at the start of the program. Main interface
        {
            Console.Clear();
            Colorful.Console.WriteLine("Welcome to the Escape Room Application.\n", Color.LawnGreen);
            Colorful.Console.WriteLine("What would you look to do?", Color.White);
            Console.WriteLine("(1) View our Escape Rooms\n(2) Cancel a reservation\n(3) Log-in as Admin\n(4) Exit");

            string UserType = Console.ReadLine();

            if (UserType == "1")
            {
                Console.Clear();
                Colorful.Console.WriteLine("Below you will find a list of our Escape Rooms.\n", Color.White);
                EscapeRoomList();
            }
            else if (UserType == "2")
            {
                CancelReservationMenu();
            }
            else if (UserType == "3")
            {
                Console.Clear();
                PasswordCheck();
            }
            else if (UserType == "4")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Colorful.Console.WriteLine("Invalid input!\n", Color.Red);
                Start();
            }
        }

        static void EscapeRoomList()
        //Gets called when the user chooses the option to check out the escape rooms.
        //This function allows you to view the escape rooms and choose to make a reservation
        {
            Colorful.Console.WriteLine("Which Escape Room would you like to check out?\n", Color.White);
            Console.WriteLine(
               "(1) " + Global.EscName1 + "\n" +
               "(2) " + Global.EscName2 + "\n" +
               "(3) " + Global.EscName3 + "\n" +
               "(4) " + Global.EscName4 + "\n" +
               "(5) " + Global.EscName5 + "\n" +
               "(6) Return to Menu");
            string EscapeRoomNumber = Console.ReadLine();
            Console.Clear();
            string Input = "";

            if (EscapeRoomNumber == "1")
            {
                Console.WriteLine(
                    "Name: " + Global.EscName1 + "\n" +
                    "Description: The participants have accidentally been locked in a room by clumsy clowns.\n" +
                    "             The participants must escape the room in order to make it to the circus show on time.\n" +
                    "Age: Children" + "\n" +
                    "Time: 60 minutes" + "\n" +
                    "Amount of players: " + Global.EscPlayers1min + "-" + Global.EscPlayers1max + "\n" +
                    "Open from: " + Global.Ecs1_OpeningTime.ToString("HH:mm") + " - " + Global.Esc1_ClosingTime.ToString("HH:mm") + "\n" +
                    "Location: Wijnhaven 107, 3011 WN Rotterdam" + "\n" +
                    "\nContact information:\n" +
                    "Phone number: 010-1234567\nEmail: escape.room@hr.nl\n");
                Colorful.Console.WriteLine("\nWhat would you like to do?", Color.White);
                Console.WriteLine("(1) Place a reservation for this Escape Room \n(2) Return");
                Input = Console.ReadLine();
                if (Input == "1")
                {
                    Global.ReservationEscapeRoomNumber = EscapeRoomNumber;
                    ReservationMenu();
                }
                else
                {
                    Console.Clear();
                    EscapeRoomList();
                }
            }
            else if (EscapeRoomNumber == "2")
            {
                Console.WriteLine(
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
                Console.WriteLine("(1) Place a reservation for this Escape Room \n(2) Return");
                Input = Console.ReadLine();
                if (Input == "1")
                {
                    Global.ReservationEscapeRoomNumber = EscapeRoomNumber;
                    ReservationMenu();
                }
                else
                {
                    Console.Clear();
                    EscapeRoomList();
                }
            }
            else if (EscapeRoomNumber == "3")
            {
                Console.WriteLine(
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
                Console.WriteLine("(1) Place a reservation for this Escape Room \n(2) Return");
                Input = Console.ReadLine();
                if (Input == "1")
                {
                    Global.ReservationEscapeRoomNumber = EscapeRoomNumber;
                    ReservationMenu();
                }
                else
                {
                    Console.Clear();
                    EscapeRoomList();
                }
            }
            else if (EscapeRoomNumber == "4")
            {
                Console.WriteLine(
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
                Console.WriteLine("(1) Place a reservation for this Escape Room \n(2) Return");
                Input = Console.ReadLine();
                if (Input == "1")
                {
                    Global.ReservationEscapeRoomNumber = EscapeRoomNumber;
                    ReservationMenu();
                }
                else
                {
                    Console.Clear();
                    EscapeRoomList();
                }
            }
            else if (EscapeRoomNumber == "5")
            {
                Console.WriteLine(
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
                Console.WriteLine("(1) Place a reservation for this Escape Room \n(2) Return");
                Input = Console.ReadLine();
                if (Input == "1")
                {
                    Global.ReservationEscapeRoomNumber = EscapeRoomNumber;
                    ReservationMenu();
                }
                else
                {
                    Console.Clear();
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


        public static void AddTimes(EscapeRoom er)
        {
            int temp = er.Start;
            while (temp + er.Duration <= er.End)
            {
                int i = temp / 100;
                int ii = temp % 100;
                int ii_end = (temp + er.Duration) % 100;
                ii_end = ii_end switch
                {
                    25 => 15,
                    50 => 30,
                    75 => 45,
                    _ => 0
                };
                ii = ii switch
                {
                    25 => 15,
                    50 => 30,
                    75 => 45,
                    _ => 0,
                };
                temp += er.Duration;
                er.TimeSlots1.Add(new TimeSlot(i, temp / 100, ii, ii_end));
            }

        }

        public static void ReservationMenu()
        {
            string Input_ReservationEscapeRoomName = Global.ReservationEscapeRoomNumber;
            Console.Clear();
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

            Console.Clear();
            Colorful.Console.WriteFormatted("Placing reservation for: ", Color.White);
            Colorful.Console.WriteLine(Input_ReservationEscapeRoomName, Color.Orange);


            Colorful.Console.WriteLine("\nPlease enter the name you wish to reserve with (first and last name).", Color.White);
            Colorful.Console.WriteLine("Note that you will need this name in order to cancel, make sure to save it.\n", Color.Yellow);
            string Input_ReservationName = Console.ReadLine();

            ReservationPlayerCheck();
            DateTime Input_ReservationDate = DateParse();

            Console.Clear();
            string Input_TimeSlot = TimeSlotSelect(Global.ReservationEscapeRoomNumber);

            bool Reserved = CheckIfAvailable(Input_ReservationEscapeRoomName, Input_ReservationDate, Input_TimeSlot);
            while (Reserved == true)
            {
                Console.Clear();
                Console.WriteLine($"The time slot you wanted to reserve ({Input_TimeSlot}) is already occupied");
                Input_TimeSlot = TimeSlotSelect(Global.ReservationEscapeRoomNumber);
                Reserved = CheckIfAvailable(Input_ReservationEscapeRoomName, Input_ReservationDate, Input_TimeSlot);
            }

            Console.Clear();
            Colorful.Console.WriteFormatted("\nEscape Room: ", Color.White);
            Colorful.Console.WriteLine(Input_ReservationEscapeRoomName, Color.Yellow);
            Colorful.Console.WriteFormatted("Reservation name: ", Color.White);
            Colorful.Console.WriteLine(Input_ReservationName, Color.Yellow);
            Colorful.Console.WriteFormatted("Amount of people reserved for: ", Color.White);
            Colorful.Console.WriteLine(Global.ReservationPlayerAmount, Color.Yellow);
            Colorful.Console.WriteFormatted("Date reserved for: ", Color.White);
            Colorful.Console.WriteLine(Input_ReservationDate.ToString("dd/MM/yyyy"), Color.Yellow);
            Colorful.Console.WriteFormatted("Time reserved for: ", Color.White);
            Colorful.Console.WriteLine(Input_TimeSlot, Color.Yellow);
            if (Confirm())
            {
                ReservationClass Reservation = new ReservationClass
                    (Input_ReservationName, Input_ReservationEscapeRoomName, Global.ReservationPlayerAmount, Input_ReservationDate, Input_TimeSlot);
                ReservationList.Add(Reservation);

                Save();

                Colorful.Console.WriteLine("You have made a reservation for " + Global.ReservationPlayerAmount + " players for \"" + Input_ReservationEscapeRoomName +
                    "\"", Color.LawnGreen);
                Console.ReadKey();
            }
            Start();

        }

        public static bool CheckIfAvailable(string ername, DateTime i_rd, string i_ts)
        {
            bool available = ReservationList.Any(x => x.ReservationEscapeRoomName == ername && x.ReservationDate == i_rd && x.ReservationTime == i_ts);
            Console.WriteLine("Reserved? " + available);
            return available;
        }


        // Function that displays time slots for the user and allows them to select one for their reservation
        // Includes parsing to prevent incorrect inputs
        public static string TimeSlotSelect(string ername)
        {
            Colorful.Console.WriteLine("\nPlease choose one of the following available times: ");
            int i = 0;
            string choice;

            // Since each Escape Room has it's own time slots, they need their own desplay
            // Display & select for Escape Room 1:
            if (Global.ReservationEscapeRoomNumber == "1")
            {
                foreach (TimeSlot t in EscapeRoom1.TimeSlots1)
                {
                    i++;
                    System.Console.WriteLine($"({i}) " + t);
                }
                choice = System.Console.ReadLine();
                if (int.TryParse(choice, out int NewChoice))
                {
                    NewChoice = NewChoice - 1;
                    if (NewChoice > -1 && NewChoice < EscapeRoom1.TimeSlots1.Count)
                    {
                        return $"{EscapeRoom1.TimeSlots1[NewChoice]}";
                    }
                    else
                    {
                        Colorful.Console.WriteLine("Input is not a valid time slot", Color.Red);
                        return TimeSlotSelect(Global.ReservationEscapeRoomNumber);
                    }
                }
                else
                {
                    Colorful.Console.WriteLine("Input is not a valid number", Color.Red);
                    return TimeSlotSelect(Global.ReservationEscapeRoomNumber);
                }
            }

            // The code above repeated, but for Escape Room 2:
            if (Global.ReservationEscapeRoomNumber == "2")
            {
                foreach (TimeSlot t in EscapeRoom2.TimeSlots1)
                {
                    i++;
                    System.Console.WriteLine($"({i}) " + t);
                }
                choice = System.Console.ReadLine();
                if (int.TryParse(choice, out int NewChoice))
                {
                    NewChoice = NewChoice - 1;
                    if (NewChoice > -1 && NewChoice < EscapeRoom2.TimeSlots1.Count)
                    {
                        return $"{EscapeRoom2.TimeSlots1[NewChoice]}";
                    }
                    else
                    {
                        Colorful.Console.WriteLine("Input is not a valid time slot", Color.Red);
                        return TimeSlotSelect(Global.ReservationEscapeRoomNumber);
                    }
                }
                else
                {
                    Colorful.Console.WriteLine("Input is not a valid number", Color.Red);
                    return TimeSlotSelect(Global.ReservationEscapeRoomNumber);
                }
            }

            // For Escape Room 3:
            if (Global.ReservationEscapeRoomNumber == "3")
            {
                foreach (TimeSlot t in EscapeRoom3.TimeSlots1)
                {
                    i++;
                    System.Console.WriteLine($"({i}) " + t);
                }
                choice = System.Console.ReadLine();
                if (int.TryParse(choice, out int NewChoice))
                {
                    NewChoice = NewChoice - 1;
                    if (NewChoice > -1 && NewChoice < EscapeRoom3.TimeSlots1.Count)
                    {
                        return $"{EscapeRoom3.TimeSlots1[NewChoice]}";
                    }
                    else
                    {
                        Colorful.Console.WriteLine("Input is not a valid time slot", Color.Red);
                        return TimeSlotSelect(Global.ReservationEscapeRoomNumber);
                    }
                }
                else
                {
                    Colorful.Console.WriteLine("Input is not a valid number", Color.Red);
                    return TimeSlotSelect(Global.ReservationEscapeRoomNumber);
                }
            }

            //For Escape Room 4:
            if (Global.ReservationEscapeRoomNumber == "4")
            {
                foreach (TimeSlot t in EscapeRoom4.TimeSlots1)
                {
                    i++;
                    System.Console.WriteLine($"({i}) " + t);
                }
                choice = System.Console.ReadLine();
                if (int.TryParse(choice, out int NewChoice))
                {
                    NewChoice = NewChoice - 1;
                    if (NewChoice > -1 && NewChoice < EscapeRoom4.TimeSlots1.Count)
                    {
                        return $"{EscapeRoom4.TimeSlots1[NewChoice]}";
                    }
                    else
                    {
                        Colorful.Console.WriteLine("Input is not a valid time slot", Color.Red);
                        return TimeSlotSelect(Global.ReservationEscapeRoomNumber);
                    }
                }
                else
                {
                    Colorful.Console.WriteLine("Input is not a valid number", Color.Red);
                    return TimeSlotSelect(Global.ReservationEscapeRoomNumber);
                }
            }

            // For Escape Room 5:
            if (Global.ReservationEscapeRoomNumber == "5")
            {
                foreach (TimeSlot t in EscapeRoom5.TimeSlots1)
                {
                    i++;
                    System.Console.WriteLine($"({i}) " + t);
                }
                choice = System.Console.ReadLine();
                if (int.TryParse(choice, out int NewChoice))
                {
                    NewChoice = NewChoice - 1;
                    if (NewChoice > -1 && NewChoice < EscapeRoom5.TimeSlots1.Count)
                    {
                        return $"{EscapeRoom5.TimeSlots1[NewChoice]}";
                    }
                    else
                    {
                        Colorful.Console.WriteLine("Input is not a valid time slot", Color.Red);
                        return TimeSlotSelect(Global.ReservationEscapeRoomNumber);
                    }
                }
                else
                {
                    Colorful.Console.WriteLine("Input is not a valid number", Color.Red);
                    return TimeSlotSelect(Global.ReservationEscapeRoomNumber);
                }
            }

            // All paths need a return statement:
            else
            {
                Colorful.Console.WriteLine("Input is not an escape room", Color.Red);
                return TimeSlotSelect(Global.ReservationEscapeRoomNumber);
            }
        }

        public static DateTime DateParse()
        // Parse for date selection, ensures that the format is followed
        // and that reservations cannot be made in the past
        {
            Colorful.Console.WriteLine("\nPlease enter the date for your reservation:", Color.White);
            Colorful.Console.WriteLine("Dates are entered as \"day-month-year\nFor example: 01/02/2021 is the first of february, 2021", Color.Yellow);
            DateTime Input_ReservationDate;
            if (DateTime.TryParse(Console.ReadLine(), out Input_ReservationDate))
            {
                DateTime CurrentDate = DateTime.Now;
                if (Input_ReservationDate < CurrentDate)
                {
                    Console.WriteLine("You cannot make a reservation in the past", Color.Red);
                    Console.WriteLine("Todays date is: " + CurrentDate.ToString("MMMM dd, yyyy"));
                    return DateParse();
                }
                else return Input_ReservationDate;
            }
            else
            {
                Console.WriteLine("You have entered an incorrect value, use the date format specified.");
                return DateParse();
            }

        }

        static bool Confirm()
        // Confirm your reservation or cancel the process
        {
            Colorful.Console.WriteLine("\nWould you like to confirm your reservation?\n(1) Confirm \n(2) Cancel");
            string ChoiceNumber = Console.ReadLine();
            if (ChoiceNumber == "1")
            {
                Colorful.Console.WriteLine("\nReservation confirmed!", Color.LawnGreen);
                return true;
            }
            if (ChoiceNumber == "2")
            {
                Colorful.Console.WriteLine("\nReservation process cancelled\nTaking you back to Client Menu...", Color.Red);
                Console.ReadKey();
                Console.Clear();
                return false;
            }
            else
            {
                Console.Clear();
                Colorful.Console.WriteLine("Invalid input!", Color.Red);
                Console.ReadKey();
                return Confirm();
            }
        }


        static void ReservationPlayerCheck()
        // Gets called to handle the input for the amount of players on a reservation
        {
            Colorful.Console.WriteLine("\nPlease enter the amount of people you would like to reserve this room for: ", Color.White);
            var PlayerAmount = Console.ReadLine();
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
            Console.Clear();
            Colorful.Console.WriteLine("Please enter the name you have placed your reservation under: ", Color.White);
            string CancellationName = Console.ReadLine();
            foreach (var n in ReservationList)
            {
                if (n.ReservationName == CancellationName)
                {
                    Console.Clear();
                    Colorful.Console.WriteFormatted("The following reservations have been made under the name ", Color.White);
                    Colorful.Console.WriteFormatted(CancellationName, Color.Yellow);
                    Colorful.Console.WriteLine(":", Color.White);
                    Console.WriteLine(n.ReservationName + " made a reservation for " + n.ReservationPlayerAmount + " players for " + n.ReservationEscapeRoomName + " for date of " + n.ReservationDate + "\n");
                    count++;
                }
            }
            if (count == 0)
            {
                Console.Clear();
                Colorful.Console.WriteFormatted("Sorry, no reservation has been found under the name ", Color.White);
                Colorful.Console.WriteLine(CancellationName, Color.Yellow);
                Console.ReadKey();
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
            Console.WriteLine("(1) Confirm\n(2) Cancel");
            string confirm = Console.ReadLine();
            if (confirm == "1")
            {
                Console.Clear();
                Colorful.Console.WriteLine("Reservation cancelled", Color.White);
                Console.ReadKey();
                return true;
            }
            else if (confirm == "2")
            {
                Console.Clear();
                Colorful.Console.WriteLine("Cancellation aborted, returning to home menu", Color.White);
                Console.ReadKey();
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
            string jPass = File.ReadAllText(filePath2);
            if (Attempts < 3)
            {
                Colorful.Console.WriteLine("Please enter the password:", Color.White);
                string PasswordInput = '"' + Console.ReadLine() + '"';
                if (PasswordInput == File.ReadAllText(filePath2))
                {
                    Console.Clear();
                    Attempts = 0;
                    AdminMenu();
                }
                else
                {
                    Attempts++;
                    if (Attempts == 3)
                    {
                        Console.Clear();
                        Colorful.Console.WriteLine("Failed to enter the correct password. \nProgram terminating...", Color.Red);
                        Environment.Exit(1);
                    }
                    Console.Clear();
                    Colorful.Console.WriteLine("Invalid password.", Color.Red);
                    Colorful.Console.WriteLine("What would you like to do? \n(1) Enter password again \n(2) Return to Start Menu", Color.White);
                    string TryAgain = Console.ReadLine();
                    if (TryAgain == "1")
                    {
                        Console.Clear();
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
            Console.Clear();
            Colorful.Console.WriteLine("Welcome Admin \n", Color.LawnGreen);
            Colorful.Console.WriteLine("What do you wish to do?\n", Color.White);
            Console.WriteLine("" +
                "(1) Edit Escape Room information \n" +
                "(2) Check the reservations \n" +
                "(3) Change password \n" +
                "(4) Log-out as Admin");

            string AdminChoice = Console.ReadLine();
            if (AdminChoice == "1")
            {
                Colorful.Console.WriteLine("\n", Color.White);
                EditInfo();
            }
            if (AdminChoice == "2")
            {
                Console.Clear();
                Colorful.Console.WriteLine("The following reservations have been made: \n", Color.White);
                foreach (var n in ReservationList)
                {
                    if (n.ReservationName != null)
                    {
                        System.Console.WriteLine(n.ReservationName + " made a reservation for " + n.ReservationPlayerAmount + " players for " + n.ReservationEscapeRoomName + " for date of " + n.ReservationDate.Date.ToShortDateString() + " at " + n.ReservationTime );
                    }
                }
                Console.ReadKey();
                AdminMenu();
            }
            if (AdminChoice == "3")
            {
                Console.Clear();
                ChangePassword();
            }
            if (AdminChoice == "4")
            {
                Attempts = 0;
                Console.Clear();
                Start();
            }
            else
            {
                Console.Clear();
                Colorful.Console.WriteLine("Invalid input!", Color.Red);
                AdminMenu();
            }
        }

        static void EditInfo()
        {
            Console.Clear();
            Colorful.Console.WriteLine("\nWhich escape room would you like to edit? \n", Color.White);
            Console.WriteLine("" +
                "(1) " + Global.EscName1 + "\n" +
                "(2) " + Global.EscName2 + "\n" +
                "(3) " + Global.EscName3 + "\n" +
                "(4) " + Global.EscName4 + "\n" +
                "(5) " + Global.EscName5 + "\n" +
                "(6) Return");
            string EscapeRoomNumber = Console.ReadLine();

            if (EscapeRoomNumber == "1")
            {
                Console.Clear();
                Colorful.Console.WriteLine("What would you like to edit? \n", Color.White);
                Console.WriteLine(
                    "(1) Escape Room Name \n" +
                    "(2) Maximum players allowed \n" +
                    "(3) Minimum players allowed \n" +
                    "(4) Opening time \n" +
                    "(5) Closing time");
                string EditNumber = Console.ReadLine();

                if (EditNumber == "1")
                {
                    Console.WriteLine("\nType the new name here: ");
                    string NewName = Console.ReadLine();
                    Global.EscName1 = NewName;
                    EditInfo();
                }
                if (EditNumber == "2" || EditNumber == "3")
                {
                    Console.WriteLine("\nEnter the new amount of players: ");
                    var readline = Console.ReadLine();
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
                if (EditNumber == "4" || EditNumber == "5")
                {
                    Console.WriteLine("Enter the new time:");
                    var readline = Console.ReadLine();
                }
            }
            if (EscapeRoomNumber == "2")
            {
                Console.Clear();
                Colorful.Console.WriteLine("What would you like to edit? \n", Color.White);
                Console.WriteLine(
                    "(1) Escape Room Name \n" +
                    "(2) Maximum players allowed \n" +
                    "(3) Minimum players allowed \n" +
                    "(4) Opening time \n" +
                    "(5) Closing time");
                string EditNumber = Console.ReadLine();

                if (EditNumber == "1")
                {
                    Console.WriteLine("\nType the new name here: ");
                    string NewName = Console.ReadLine();
                    Global.EscName2 = NewName;
                    EditInfo();
                }
                if (EditNumber == "2" || EditNumber == "3")
                {
                    Console.WriteLine("\nEnter the new amount of players: ");
                    var readline = Console.ReadLine();
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
                    if (EditNumber == "4" || EditNumber == "5")
                    {
                        Console.WriteLine("Enter the new time:");
                        var readline2 = Console.ReadLine();
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
                Console.Clear();
                Colorful.Console.WriteLine("What would you like to edit? \n", Color.White);
                Console.WriteLine(
                    "(1) Escape Room Name \n" +
                    "(2) Maximum players allowed \n" +
                    "(3) Minimum players allowed \n" +
                    "(4) Opening time\n" +
                    "(5) Closing time");
                string EditNumber = Console.ReadLine();

                if (EditNumber == "1")
                {
                    Console.WriteLine("\nType the new name here: ");
                    string NewName = Console.ReadLine();
                    Global.EscName3 = NewName;
                    EditInfo();
                }
                if (EditNumber == "2" || EditNumber == "3")
                {
                    Console.WriteLine("\nEnter the new amount of players: ");
                    var readline = Console.ReadLine();
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
                    if (EditNumber == "4" || EditNumber == "5")
                    {
                        Console.WriteLine("Enter the new time:");
                        var readline3 = Console.ReadLine();
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
                Console.Clear();
                Colorful.Console.WriteLine("What would you like to edit? \n", Color.White);
                Console.WriteLine(
                    "(1) Escape Room Name \n" +
                    "(2) Maximum players allowed \n" +
                    "(3) Minimum players allowed \n" +
                    "(4) Opening time \n" +
                    "(5) Closing time");
                string EditNumber = Console.ReadLine();

                if (EditNumber == "1")
                {
                    Console.WriteLine("\nType the new name here: ");
                    string NewName = Console.ReadLine();
                    Global.EscName4 = NewName;
                    EditInfo();
                }
                if (EditNumber == "2" || EditNumber == "3")
                {
                    Console.WriteLine("\nEnter the new amount of players: ");
                    var readline = Console.ReadLine();
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
                    if (EditNumber == "4" || EditNumber == "5")
                    {
                        Console.WriteLine("Enter the new time:");
                        var readline4 = Console.ReadLine();
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
                Console.Clear();
                Colorful.Console.WriteLine("What would you like to edit? \n", Color.White);
                Console.WriteLine(
                    "(1) Escape Room Name \n" +
                    "(2) Maximum players allowed \n" +
                    "(3) Minimum players allowed \n" +
                    "(4) Opening time \n" +
                    "(5) Closing time");
                string EditNumber = Console.ReadLine();

                if (EditNumber == "1")
                {
                    Console.WriteLine("\nType the new name here: ");
                    string NewName = Console.ReadLine();
                    Global.EscName5 = NewName;
                    EditInfo();
                }
                if (EditNumber == "2" || EditNumber == "3")
                {
                    Console.WriteLine("\nEnter the new amount of players: ");
                    var readline = Console.ReadLine();
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
                    if (EditNumber == "4" || EditNumber == "5")
                    {
                        Console.WriteLine("Enter the new time:");
                        var readline5 = Console.ReadLine();
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
                Console.Clear();
                AdminMenu();
            }
        }


        static void ChangePassword()
        // Gets called when the admin chooses option 4 in AdminMenu
        {                
            Colorful.Console.WriteLine("Please enter the new password below:", Color.White);
            var jsonString = System.Text.Json.JsonSerializer.Serialize(Console.ReadLine());
            File.WriteAllText(filePath2, jsonString);
        }

        // Serializes and saves the Reservation List
        static void Save()
        {
            string jsonString;
            jsonString = JsonConvert.SerializeObject(ReservationList, Formatting.Indented);
            File.WriteAllText(filePath, jsonString);
        }

        // Reads Reservation.Json and converts it into a list
        public static void Deserialize()
        {
            ReservationList = JsonConvert.DeserializeObject<List<ReservationClass>>(File.ReadAllText(filePath));
        }
    }
}
