using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Management_System.Models
{
     public class Pilot
        {
            public int PilotId { get; set; }  //system generated
        public string PilotName { get; set; }  //user input 
            public string PilotPhone { get; set; }  // user input
            public string LicenseNumber { get; set; }  //user input 
            public int FlightHours { get; set; }  // user input 
            public bool IsAvailable { get; set; }  //default value = true 
    }
    }
