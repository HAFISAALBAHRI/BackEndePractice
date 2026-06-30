using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Management_System.Models
{
       public class Aircraft
        {
            public int AircraftId { get; set; }  //system generated
            public string Model { get; set; }  //user input
            public int TotalSeats { get; set; }  //user input
            public bool IsOperational { get; set; }  //default value = true
    }
    }

