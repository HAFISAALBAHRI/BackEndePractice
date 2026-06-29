using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Management_System.Models
{
    
        public class Flight
        {
        public int FlightId { get; set; } //system generated
        public string FlightCode { get; set; }  // default value = "OA-" + flightId
        public int AircraftId { get; set; }  // user input choosen from List of aircraft
        public int PilotId { get; set; }   // user input choosen from List of pilot
        public string Origin { get; set; } //user input 
        public string Destination { get; set; } //user input 
        public string DepartureDate { get; set; }  //user input 
        public string DepartureTime { get; set; }  //user input 
        public int FlightDuration { get; set; } //user input 
        public decimal TicketPrice { get; set; } //user input 
        public int AvailableSeats { get; set; }  //default value = aircraft.totalSeats from list of aircraft
        public string Status { get; set; } // default value "Scheduled"
    }
    }
