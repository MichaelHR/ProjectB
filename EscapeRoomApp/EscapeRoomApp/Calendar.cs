// DIT IS DE FUNCTIE DIE EEN KALENDER MAAKTE DIE OP HET EINDE IS KOMEN TE VERVALLEN.
// De kans is aanwezig dat het nu niet meer goed werkt omdat het normaal in de rest van de applicatie stond
using System;
using System.Globalization;
using System.Drawing;


namespace Calendar
{
    class Program
    {
        static int[,] calendar = new int[6, 7];
        private static DateTime date;

        static void Main(string[] arg)
        {

            date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1); //geeft een datetime object voor de 1e dag van de maand
            DrawHeader();
            FillCalendar();
            MakeCalendar();
        }

        // onderstaande functie zorgt dat de dagen en maand boven de kalender staat
        static void DrawHeader()
        {
            Console.WriteLine(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month) + " " + DateTime.Now.Year);
            Console.WriteLine("Ma Di Wo Do Vr Za Zo");
        }

        // onderstaande functie vult de kalender in
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