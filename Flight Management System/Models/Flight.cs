using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Management_System.Models
{
    
        public class Flight
        {
        public int flightId { get; set; } //system generated
        public string flightCode { get; set; }  // default value = "OA-" + flightId
        public int aircraftId { get; set; }  // user input choosen from List of aircraft
        public int pilotId { get; set; }   // user input choosen from List of pilot
        public string origin { get; set; } //user input 
        public string destination { get; set; } //user input 
        public string departureDate { get; set; }  //user input 
        public string departureTime { get; set; }  //user input 
        public int flightDuration { get; set; } //user input 
        public decimal ticketPrice { get; set; } //user input 
        public int availableSeats { get; set; }  //default value = aircraft.totalSeats from list of aircraft
        public string status { get; set; } // default value "Scheduled"
    }
    }
