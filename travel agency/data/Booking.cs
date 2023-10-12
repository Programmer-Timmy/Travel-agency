using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel_agency
{
    internal class Booking
    { 
        public Booking(int aId, string aFirstname, string aLastname, string aDestination, DateTime aBooking_date, int aCustomerId, int aTripId)
        {
            Id = aId;
            Firstname = aFirstname;
            Lastname = aLastname;
            Destination = aDestination;
            Booking_date = aBooking_date;
            CustomerId = aCustomerId;
            TripId = aTripId;
        }
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Destination { get; set; }
        public DateTime Booking_date { get; set; }
        public int CustomerId { get; set; }
        public int TripId { get; set; }
    }
}

