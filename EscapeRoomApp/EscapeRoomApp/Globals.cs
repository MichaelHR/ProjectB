using System;

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

        // Opening times for each Escape Room
        public static DateTime Ecs1_OpeningTime = new DateTime(2019, 5, 19, 12, 0, 0);
        public static DateTime Esc1_ClosingTime = new DateTime(2019, 5, 19, 21, 0, 0);
        public static DateTime Esc2_OpeningTime = new DateTime(2019, 5, 19, 12, 0, 0);
        public static DateTime Esc2_ClosingTime = new DateTime(2019, 5, 19, 21, 0, 0);
        public static DateTime Esc3_OpeningTime = new DateTime(2019, 5, 19, 17, 0, 0);
        public static DateTime Esc3_ClosingTime = new DateTime(2019, 5, 19, 0, 0, 0);
        public static DateTime Esc4_OpeningTime = new DateTime(2019, 5, 19, 17, 0, 0);
        public static DateTime Esc4_ClosingTime = new DateTime(2019, 5, 19, 0, 0, 0);
        public static DateTime Esc5_OpeningTime = new DateTime(2019, 5, 19, 17, 0, 0);
        public static DateTime Esc5_ClosingTime = new DateTime(2019, 5, 19, 0, 0, 0);

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
        public static string ReservationEscapeRoomNumber;
        public static int ReservationPlayerAmount = 0;
        public static int ReservationEscapeRoomMaxCount = 0;
        public static int ReservationEscapeRoomMinCount = 0;
    }
}
