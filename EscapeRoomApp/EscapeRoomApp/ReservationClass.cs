﻿using System;
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
        public string ReservationTime { get; set; }
        public int ReservationPlayerAmount { get; set; }
        public DateTime ReservationDate { get; set; }

        public ReservationClass(string rn, string rrn, int rpa, DateTime rd, string rt)
        {
            ReservationName = rn;
            ReservationEscapeRoomName = rrn;
            ReservationPlayerAmount = rpa;
            ReservationDate = rd;
            ReservationTime = rt;
        }
        public override string ToString()
        {
            return ReservationName + " made a reservation for " + ReservationPlayerAmount + " players for " + ReservationEscapeRoomName + " for date of " + ReservationDate.ToShortDateString() + " at " + ReservationTime;
        }
    }
}
