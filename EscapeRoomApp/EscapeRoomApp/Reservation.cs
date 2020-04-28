using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeRoomApp
{
    public class ReservationClass
    {
        string ReservationName { get; set; }
        string ReservationEscapeRoomName { get; set; }
        int ReservationPlayerAmount { get; set; }

        public ReservationClass(string rn, string rrn, int rpa)
        {
            ReservationName = rn;
            ReservationEscapeRoomName = rrn;
            ReservationPlayerAmount = rpa;
        }
        public override string ToString()
        {
            return ReservationName + " made a reservation for " + ReservationPlayerAmount + " players for " + ReservationEscapeRoomName;
        }
    }
}
