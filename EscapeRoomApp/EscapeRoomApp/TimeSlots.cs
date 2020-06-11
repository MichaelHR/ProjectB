using System.Collections.Generic;

namespace EscapeRoomApp
{

    public class EscapeRoomTime
    {
        public List<TimeSlot> TimeSlots1 = new List<TimeSlot>();
        public TimeSlot Time { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
        public int Duration { get; set; }
        public EscapeRoomTime(int s, int e, int d)
        {
            Start = s;
            End = e;
            Duration = d;
        }

    }

    public class TimeSlot
    {
        public int HourStart { get; set; }
        public int HourEnd { get; set; }
        public int MinStart { get; set; }
        public int MinEnd { get; set; }
        public bool Reserved { get; set; }

        public TimeSlot(int hs, int he, int ms, int me)
        {
            HourStart = hs;
            HourEnd = he;
            MinStart = ms;
            MinEnd = me;
            Reserved = false;
        }

        public override string ToString()
        {
            if (MinStart == 0)
            {
                return HourStart + ":00 - " + HourEnd + ":00";
            }
            if (MinEnd == 0)
            {
                return HourStart + ":00 - " + HourEnd + ":00";
            }
            return HourStart + ":" + MinStart + " - " + HourEnd + ":" + MinEnd;
        }
    }
}
