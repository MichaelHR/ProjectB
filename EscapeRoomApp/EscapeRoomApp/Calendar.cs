using System;
using System.Globalization;

namespace Calendar
{
    class Program
    {
        static int year = new int();
        static int month = new int();
        static int[,] calendar = new int[6, 7];
        private static DateTime date;

        private static void Main(string[] args)
        {
            date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);//gives you a datetime object for the first day of the month
            DrawHeader();
            FillCalendar();
            MakeCalendar();
            Console.ReadLine();
        }

        static void DrawHeader()
        {
            Console.Write("\n\n");
            //gives you the month and year at the top of the calendar
            Console.WriteLine(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month) + " " + DateTime.Now.Year);
            Console.WriteLine("Ma Di Wo Do Vr Za Zo");
        }

        static void FillCalendar()
        {
            int days = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            int currentDay = 1;
            var dayOfWeek = (int)date.DayOfWeek;
            for (int i = 0; i < calendar.GetLength(0); i++)
            {
                for (int j = 0; j < calendar.GetLength(1) && currentDay - dayOfWeek + 1 <= days; j++)
                {
                    if (i == 0 && DateTime.Now.Month > j)
                    {
                        calendar[i, j] = 0;
                    }
                    else
                    {
                        calendar[i, j] = currentDay - dayOfWeek + 1;
                        currentDay++;
                    }
                }
            }
        }

        static void MakeCalendar()
        {
            for (int i = 0; i < calendar.GetLength(0); i++)
            {
                for (int j = 0; j < calendar.GetLength(1); j++)
                {
                    if (calendar[i, j] > 0)
                    {
                        if (calendar[i, j] < 10)
                        {
                            Console.Write(" " + calendar[i, j] + " ");
                        }
                        else
                        {
                            Console.Write(calendar[i, j] + " ");
                        }
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}