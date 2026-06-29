using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Management_System.Models
{

   
        public class Booking
        {
        public int bookingId { get; set; } //system generated
        public int passengerId { get; set; }  // user input choosen from List of passenger 
        public int flightId { get; set; }  // user input choosen from List of flight
        public string seatNumber { get; set; }  // user input
        public string bookingDate { get; set; }  ////system calculated
        public decimal totalPrice { get; set; } ////system calculated
        public string status { get; set; }   //default value 
    }
    }
