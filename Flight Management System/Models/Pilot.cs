using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Management_System.Models
{
     public class Pilot
        {
            public int pilotId { get; set; }
            public string pilotName { get; set; }
            public string pilotPhone { get; set; }
            public string licenseNumber { get; set; }
            public int flightHours { get; set; }
            public bool isAvailable { get; set; }
        }
    }
