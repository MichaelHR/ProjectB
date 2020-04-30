using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace EscapeRoomApp
{
    [Serializable]
    public class ReservationClass
    {
        public string ReservationName { get; set; }
        public string ReservationEscapeRoomName { get; set; }
        public int ReservationPlayerAmount { get; set; }

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
