using Flight_Management_System.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Flight_Management_System
{
    public class Program
    {
        public static FlightContext context = new FlightContext
        {
            Passengers = new List<Passenger>() {
            new Passenger
            {
                passengerId = 1,
                passengerName = "Ahmed Ali",
                passengerPhone = "91234567",
                passengerEmail = "ahmed@gmail.com",
                passportNumber = "P123456",
                nationality = "Omani"
            }
            },
            Pilots = new List<Pilot>()
            {
    new Pilot
    {
        pilotId = 1,
        pilotName = "Ahmed Ali",
        pilotPhone = "91234567",
        licenseNumber = "LIC-001",
        flightHours = 10,
        isAvailable = true
    },

    new Pilot
    {
        pilotId = 2,
        pilotName = "Sara Said",
        pilotPhone = "92345678",
        licenseNumber = "LIC-002",
        flightHours = 20,
        isAvailable = true
    }
},
            Aircrafts = new List<Aircraft>()
            {
    new Aircraft
    {
        aircraftId = 1,
        model = "Boeing 737",
        totalSeats = 150,
        isOperational = true
    },

    new Aircraft
    {
        aircraftId = 2,
        model = "Airbus A320",
        totalSeats = 150,
        isOperational = true
    }
},
            Flights = new List<Flight>()
            {
    new Flight
    {
        flightId = 1,
        flightCode = "OA-1",
        aircraftId = 1,
        pilotId = 1,
        origin = "Muscat",
        destination = "Dubai",
        departureDate = "25/06/2026",
        departureTime = "10:00",
        flightDuration = 1,
        ticketPrice = 50,
        availableSeats = 150,
        status = "Scheduled"
    },
     new Flight
    {
        flightId = 2,
        flightCode = "OA-2",
        aircraftId = 2,
        pilotId = 2,
        origin = "Muscat",
        destination = "Dubai",
        departureDate = "27/05/2026",
        departureTime = "10:00",
        flightDuration = 3,
        ticketPrice = 50,
        availableSeats = 150,
        status = "Scheduled"
    }
},
            Bookings = new List<Booking>()
        };
        // case 1  - Register Passenger
        public static void RegisterPassenger()
        {
            Console.WriteLine("=== Register New Passenger ===");

            Console.Write("Enter passenger name: ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name) || name.Split(' ').Length != 2)
            {
                Console.WriteLine("Please enter first name and family name.");
                return;
            }

            Console.Write("Enter passenger email: ");
            string email = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(email) ||
                !email.Contains("@") ||
                !email.Contains("."))
            {
                Console.WriteLine("Invalid email.");
                return;
            }

            Console.Write("Enter passenger phone: ");
            string phone = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(phone) ||
                phone.Length != 8 ||
                (phone[0] != '9' && phone[0] != '7') || !phone.All(char.IsDigit))// it accept only int
            {
                Console.WriteLine("Invalid phone number.");
                return;
            }

            Console.Write("Enter passport number: ");
            string passportNumber = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(passportNumber))
            {
                Console.WriteLine("Passport number cannot be empty.");
                return;
            }

            Console.Write("Enter nationality: ");
            string nationality = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nationality))
            {
                Console.WriteLine("Nationality cannot be empty.");
                return;
            }

            int passengerId = context.Passengers.Count + 1;

            context.Passengers.Add(new Passenger
            {
                passengerId = passengerId,
                passengerName = name,
                passengerEmail = email,
                passengerPhone = phone,
                passportNumber = passportNumber,
                nationality = nationality
            });

            Console.WriteLine($"Passenger registered successfully. Assigned ID: {passengerId}");
        }
        // case 2  - Add Aircraft 
        public static void AddAircraft()
        {
            Console.WriteLine("=== Add New Aircraft ===");

            Console.Write("Enter aircraft model: ");
            string model = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(model))
            {
                Console.WriteLine("Aircraft model needed.");
                return;
            }
            int totalSeats;
            Console.Write("Enter total seats: ");

            if (!int.TryParse(Console.ReadLine(), out totalSeats) || totalSeats < 50)
            {
                Console.WriteLine("Invalid number. Seats must be 50 or more.");
                return;
            }
            int aircraftId = context.Aircrafts.Count + 1;

            context.Aircrafts.Add(new Aircraft
            {
                aircraftId = aircraftId,
                model = model,
                totalSeats = totalSeats,
                isOperational = true
            });

            Console.WriteLine($"Aircraft added successfully. Assigned ID: {aircraftId}");
        }

        // case 3  - Register Pilot
        public static void RegisterPilot()
        {
            Console.WriteLine("=== Register New Pilot ===");

            Console.Write("Enter pilot name: ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Pilot name is needed.");
                return;
            }

            Console.Write("Enter pilot phone: ");
            string phone = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(phone) ||
                phone.Length != 8 ||
                (phone[0] != '9' && phone[0] != '7') || !phone.All(char.IsDigit))
            {
                Console.WriteLine("Invalid phone number.");
                return;
            }

            Console.Write("Enter license number: ");
            string number = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(number) || !number.All(char.IsDigit))
            {
                Console.WriteLine("License number is needed and must contain digits only.");
                return;
            }

            string licenseNumber = "LIC-" + number;

            int pilotId = context.Pilots.Count + 1;

            context.Pilots.Add(new Pilot
            {
                pilotId = pilotId,
                pilotName = name,
                pilotPhone = phone,
                licenseNumber = licenseNumber,
                flightHours = 0,
                isAvailable = true
            });

            Console.WriteLine($"Pilot registered successfully. Assigned ID: {pilotId}");
        }
        //case 4  - View All Flights
        public static void ViewAllFlights()
        {
            Console.WriteLine("=== All Flights ===");

            foreach (Flight f in context.Flights)
            {
                Console.WriteLine($"Flight Code: {f.flightCode}" +
                                  $" | Origin: {f.origin}" +
                                  $" | Destination: {f.destination}" +
                                  $" | Date: {f.departureDate}" +
                                  $" | Time: {f.departureTime}" +
                                  $" | Duration: {f.flightDuration}" +
                                  $" | Available Seats: {f.availableSeats}" +
                                  $" | Ticket Price: {f.ticketPrice}" +
                                  $" | Status: {f.status}");
            }
        }

        // case 5  - Schedule Flight
        /*
        in case 5 Automatically generated values
        flightId = context.Flights.Count + 1;
        flightCode = "OA-" + flightId;
        availableSeats = aircraft.totalSeats;
        status = "Scheduled";
        pilot.isAvailable = false;
        */
        public static void ScheduleFlight()
        {
            Console.WriteLine("\n=== Schedule Flight ===");

            foreach (Aircraft a in context.Aircrafts)
            {
                Console.WriteLine($"ID: {a.aircraftId} | Model: {a.model} | Seats: {a.totalSeats}");
            }
            Console.Write("Enter Aircraft ID: ");

            if (!int.TryParse(Console.ReadLine(), out int aircraftId))
            {
                Console.WriteLine("Aircraft ID is needed.");
                return;
            }
            //Console.Write("Enter Aircraft ID: ");
            //int aircraftId = int.Parse(Console.ReadLine());
            //if (aircraftId == null)
            //{
            //    Console.WriteLine("Pilot not found.");
            //    return;
            //}


            Aircraft aircraft = context.Aircrafts
                .FirstOrDefault(a => a.aircraftId == aircraftId);

            if (aircraft == null || !aircraft.isOperational)
            {
                Console.WriteLine("Aircraft not found.");
                return;
            }

            foreach (Pilot p in context.Pilots)
            {
                Console.WriteLine($"ID: {p.pilotId} | Name: {p.pilotName}");
            }

            Console.Write("Enter Pilot ID: ");

            if (!int.TryParse(Console.ReadLine(), out int pilotId))
            {
                Console.WriteLine("Pilot ID is needed.");
                return;
            }

            Pilot pilot = context.Pilots
                .FirstOrDefault(p => p.pilotId == pilotId);

            if (pilot == null)
            {
                Console.WriteLine("Pilot not found.");
                return;
            }

            Console.Write("Enter Origin: ");
            string origin = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(origin))
            {
                Console.WriteLine("Origin is needed.");
                return;
            }

            Console.Write("Enter Destination: ");
            string destination = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(destination))
            {
                Console.WriteLine("Destination is needed.");
                return;
            }

            Console.Write("Enter Departure Date (dd/MM/yyyy): ");

            if (!DateTime.TryParse(Console.ReadLine(), out DateTime d))
            {
                Console.WriteLine("Invalid Date.");
                return;
            }

            string departureDate = d.ToString("dd/MM/yyyy");
            Console.Write("Enter Departure Time (HH:mm): ");

            if (!DateTime.TryParse(Console.ReadLine(), out DateTime t))
            {
                Console.WriteLine("Invalid Time.");
                return;
            }

            string departureTime = t.ToString("HH:mm");

            Console.Write("Enter Flight Duration (hours): ");
            //int flightDuration = int.Parse(Console.ReadLine());
            if (!int.TryParse(Console.ReadLine(), out int flightDuration) || flightDuration <= 0)
            {
                Console.WriteLine("Flight Duration must be greater than 0.");
                return;
            }
            //If the user enters letters, the program crashes. 
            //if (flightDuration <= 0)
            //{
            //    Console.WriteLine("Flight Duration must be greater than 0.");
            //    return;
            //}

            Console.Write("Enter Ticket Price: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal price) || price <= 0)
            {
                Console.WriteLine("Ticket Price must be greater than 0.");
                return;
            }
            //decimal price = decimal.Parse(Console.ReadLine());

            //if (price <= 0)
            //{
            //    Console.WriteLine("Ticket Price must be greater than 0.");
            //    return;
            //}

            int flightId = context.Flights.Count + 1;

            context.Flights.Add(new Flight
            {
                flightId = flightId,
                flightCode = "OA-" + flightId,
                aircraftId = aircraftId,
                pilotId = pilotId,
                origin = origin,
                destination = destination,
                departureDate = departureDate,
                departureTime = departureTime,
                flightDuration = flightDuration,
                ticketPrice = price,
                availableSeats = aircraft.totalSeats,
                status = "Scheduled"
            });

            pilot.isAvailable = false;

            Console.WriteLine($"Flight scheduled successfully. Flight Code: OA-{flightId}");
        }

        // case 6  - Book Flight
        public static void BookFlight()
        {
            Console.WriteLine("\n=== Book Flight ===");

            Console.Write("Enter Passenger ID: ");

            if (!int.TryParse(Console.ReadLine(), out int passengerId))
            {
                Console.WriteLine("Passenger ID is needed.");
                return;
            }

            Passenger passenger = context.Passengers
                .FirstOrDefault(p => p.passengerId == passengerId);

            if (passenger == null)
            {
                Console.WriteLine("Passenger not found.");
                return;
            }

            Console.WriteLine("\nAvailable Flights:");

            var availableFlights = context.Flights
                .Where(f => f.status == "Scheduled" && f.availableSeats > 0);

            if (!availableFlights.Any())
            {
                Console.WriteLine("No available flights.");
                return;
            }

            foreach (Flight f in availableFlights)
            {
                Console.WriteLine($"ID: {f.flightId} | Code: {f.flightCode} | " +
                                  $"From: {f.origin} | To: {f.destination} | " +
                                  $"Seats: {f.availableSeats} | Price: {f.ticketPrice}");
            }

            Console.Write("Enter Flight ID: ");

            if (!int.TryParse(Console.ReadLine(), out int flightId))
            {
                Console.WriteLine("Flight ID is needed.");
                return;
            }

            Flight flight = context.Flights
                .FirstOrDefault(f => f.flightId == flightId &&
                                     f.status == "Scheduled" &&
                                     f.availableSeats > 0);

            if (flight == null)
            {
                Console.WriteLine("Flight not found or no seats available.");
                return;
            }

            Console.Write("Enter Seat Number: ");
            string seatNumber = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(seatNumber))
            {
                Console.WriteLine("Seat Number is needed.");
                return;
            }

            int bookingId = context.Bookings.Count + 1;

            context.Bookings.Add(new Booking
            {
                bookingId = bookingId,
                passengerId = passengerId,
                flightId = flightId,
                seatNumber = seatNumber,
                bookingDate = DateTime.Now.ToString("dd/MM/yyyy"),
                totalPrice = flight.ticketPrice,
                status = "Confirmed"
            });

            flight.availableSeats--;

            Console.WriteLine($"Booking successful. Booking ID: {bookingId}");
        }

        // case 7  - Cancel Booking
        public static void CancelBooking()
        {
            Console.WriteLine("\n=== Cancel Booking ===");

            Console.Write("Enter Booking ID: ");

            if (!int.TryParse(Console.ReadLine(), out int bookingId))
            {
                Console.WriteLine("Booking ID is needed.");
                return;
            }

            Booking booking = context.Bookings
                .FirstOrDefault(b => b.bookingId == bookingId);

            if (booking == null)
            {
                Console.WriteLine("Booking not found.");
                return;
            }

            if (booking.status == "Cancelled")
            {
                Console.WriteLine("Booking is already cancelled.");
                return;
            }

            Flight flight = context.Flights
                .FirstOrDefault(f => f.flightId == booking.flightId);

            if (flight == null)
            {
                Console.WriteLine("Flight not found.");
                return;
            }

            if (flight.status == "Departed")
            {
                Console.WriteLine("Cannot cancel booking. Flight already departed.");
                return;
            }

            booking.status = "Cancelled";
            flight.availableSeats++;

            Console.WriteLine($"Booking {bookingId} has been cancelled.");
        }

        // case 8  - Depart Flight
        public static void DepartFlight()
        {
            Console.WriteLine("\n=== Depart Flight ===");

            Console.Write("Enter Flight ID: ");

            if (!int.TryParse(Console.ReadLine(), out int flightId))
            {
                Console.WriteLine("Flight ID is needed.");
                return;
            }

            Flight flight = context.Flights
            .FirstOrDefault(f => f.flightId == flightId);

            if (flight == null)
            {
                Console.WriteLine("Flight not found.");
                return;
            }
            Pilot pilot = context.Pilots
            .FirstOrDefault(p => p.pilotId == flight.pilotId);
            if (pilot == null)
            {
                Console.WriteLine("pilot not found.");
                return ;
            }


            flight.status = "Departed";
            pilot.flightHours += flight.flightDuration;

            // pilot.flightHours++;

            pilot.isAvailable = true;

            Console.WriteLine($"Flight {flight.flightCode} has departed successfully.");
        }

        // case 9  - Cancel Flight
        public static void CancelFlight()
        {
            Console.WriteLine("\n=== Cancel Flight ===");

            Console.Write("Enter Flight ID: ");

            if (!int.TryParse(Console.ReadLine(), out int flightId))
            {
                Console.WriteLine("Flight ID is needed.");
                return;
            }

            Flight flight = context.Flights
                .FirstOrDefault(f => f.flightId == flightId);

            if (flight == null)
            {
                Console.WriteLine("Flight not found.");
                return;
            }

            if (flight.status == "Departed")
            {
                Console.WriteLine("Cannot cancel a departed flight.");
                return;
            }

            Pilot pilot = context.Pilots
                .FirstOrDefault(p => p.pilotId == flight.pilotId);

            flight.status = "Cancelled";

            if (pilot != null)
            {
                pilot.isAvailable = true;
            }

            foreach (Booking booking in context.Bookings
                .Where(b => b.flightId == flightId &&
                            b.status == "Confirmed"))
            {
                booking.status = "Cancelled";
            }

            Console.WriteLine($"Flight {flight.flightCode} has been cancelled.");
        }
        // case 10 - Passenger Booking History
        public static void PassengerBookingHistory()
        {
            Console.WriteLine("\n=== Passenger Booking History ===");

            Console.Write("Enter Passenger ID: ");

            if (!int.TryParse(Console.ReadLine(), out int passengerId))
            {
                Console.WriteLine("Passenger ID is needed.");
                return;
            }

            Passenger passenger = context.Passengers
                .FirstOrDefault(p => p.passengerId == passengerId);

            if (passenger == null)
            {
                Console.WriteLine("Passenger not found.");
                return;
            }

            decimal totalSpent = 0;
            if (!context.Bookings.Any(b => b.passengerId == passengerId))
            {
                Console.WriteLine("No bookings found.");
                return;
            }

            foreach (Booking b in context.Bookings
                .Where(b => b.passengerId == passengerId))
            {
                Flight flight = context.Flights
                    .FirstOrDefault(f => f.flightId == b.flightId);

                Console.WriteLine($"Booking ID: {b.bookingId}");
                Console.WriteLine($"Flight Code: {flight.flightCode}");
                Console.WriteLine($"From: {flight.origin}");
                Console.WriteLine($"To: {flight.destination}");
                Console.WriteLine($"Departure Date: {flight.departureDate}");
                Console.WriteLine($"Seat Number: {b.seatNumber}");
                Console.WriteLine($"Price Paid: {b.totalPrice}");
                Console.WriteLine($"Status: {b.status}");
                Console.WriteLine("--------------------------------");

                if (b.status == "Confirmed")
                {
                    totalSpent += b.totalPrice;
                }
            }

            Console.WriteLine($"Total Amount Spent: {totalSpent}");
        }

        //case 11 - Flight Revenue Report
        public static void FlightRevenueReport()
        {
            Console.WriteLine("\n=== Flight Revenue & Load Factor Report ===");

            foreach (Flight flight in context.Flights)
            {
                Aircraft aircraft = context.Aircrafts
                .FirstOrDefault(a => a.aircraftId == flight.aircraftId);

                int bookingsCount = context.Bookings
                .Count(b => b.flightId == flight.flightId &&
                b.status == "Confirmed");

                decimal revenue = bookingsCount * flight.ticketPrice;
                if (aircraft == null)
                {
                    continue;
                }

                double loadFactor = ((double)bookingsCount / aircraft.totalSeats) * 100;

                Console.WriteLine($"Flight Code: {flight.flightCode}");
                Console.WriteLine($"Bookings: {bookingsCount}");
                Console.WriteLine($"Revenue: {revenue} OMR");
                Console.WriteLine($"Load Factor: {loadFactor:F2}%");
                Console.WriteLine("--------------------------------");
            }
        }
        static void Main(string[] args)
            {
                bool exit = false;

                while (exit == false)
                {
                    Console.WriteLine("========================================");
                    Console.WriteLine("      Flight Management System");
                    Console.WriteLine("========================================");
                    Console.WriteLine(" 1  - Register Passenger");
                    Console.WriteLine(" 2  - Add Aircraft");
                    Console.WriteLine(" 3  - Register Pilot");
                    Console.WriteLine(" 4  - View All Flights");
                    Console.WriteLine(" 5  - Schedule Flight");
                    Console.WriteLine(" 6  - Book Flight");
                    Console.WriteLine(" 7  - Cancel Booking");
                    Console.WriteLine(" 8  - Depart Flight");
                    Console.WriteLine(" 9  - Cancel Flight");
                    Console.WriteLine(" 10 - Passenger Booking History");
                    Console.WriteLine(" 11 - Flight Revenue Report");
                    Console.WriteLine(" 0  - Exit");
                    Console.WriteLine("========================================");
                    Console.Write("Select option: ");

                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1: RegisterPassenger(); break;
                        case 2: AddAircraft(); break;
                        case 3: RegisterPilot(); break;
                        case 4: ViewAllFlights(); break;
                        case 5: ScheduleFlight(); break;
                        case 6: BookFlight(); break;
                        case 7: CancelBooking(); break;
                        case 8: DepartFlight(); break;
                        case 9: CancelFlight(); break;
                        case 10: PassengerBookingHistory(); break;
                        case 11: FlightRevenueReport(); break;
                        case 0: exit = true; break;
                        default: Console.WriteLine("Invalid option. Please try again."); break;
                    }

                    if (!exit)
                    {
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

                Console.WriteLine("Goodbye!");
            }
        }
    }

