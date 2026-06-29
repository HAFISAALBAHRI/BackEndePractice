using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Management_System.Models
{

   
        public class Booking
        {
        public int BookingId { get; set; } //system generated
        public int PassengerId { get; set; }  // user input choosen from List of passenger 
        public int FlightId { get; set; }  // user input choosen from List of flight
        public string SeatNumber { get; set; }  // user input
        public string BookingDate { get; set; }  ////system calculated
        public decimal TotalPrice { get; set; } ////system calculated
        public string Status { get; set; }   //default value 
    }
    }
