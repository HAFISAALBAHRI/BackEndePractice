using Flight_Management_System.Models;

namespace Flight_Management_System
{
    public class Program
    {
        public static FlightContext context = new FlightContext
        {
            Passengers = new List<Passenger>(),
            Pilots = new List<Pilot>(),
            Aircrafts = new List<Aircraft>(),
            Flights = new List<Flight>(),
            Bookings = new List<Booking>()
        };

        public static void RegisterPassenger()
        {
            Console.WriteLine("=== Register New Passenger ===");

            Console.Write("Enter passenger name:  ");
            string name = Console.ReadLine();
            if (name.Split(' ').Length != 2)
            {
                Console.WriteLine("Please enter first name and family name.");
                return;
            }

            Console.Write("Enter passenger email: ");
            string email = Console.ReadLine();
            if (!email.Contains("@") || !email.Contains("."))
            {
                Console.WriteLine("Invalid email. Try again.");
                return;
            }


            Console.Write("Enter passenger phone: ");
            string phone = Console.ReadLine();
            if (phone.Length != 8 || (phone[0] != '9' && phone[0] != '7'))
            {
                Console.WriteLine("Invalid phone number.");
                return;
            }


            Console.Write("Enter passport number: ");
            string passportNumber = Console.ReadLine();

            Console.Write("Enter nationality: ");
            string nationality = Console.ReadLine();

            int passengerId = context.Passengers.Count + 1;

            context.Passengers.Add(
                new Passenger
                {
                    passengerId = passengerId,
                    passengerName = name,
                    passengerEmail = email,
                    passengerPhone = phone,
                    passportNumber = passportNumber,
                    nationality = nationality
                }
            );

            Console.WriteLine($"Passenger registered successfully. Assigned ID: {passengerId}");
        }

        public static void AddAircraft()
        {
            Console.WriteLine("=== Add New Aircraft ===");

            Console.Write("Enter aircraft model: ");
            string model = Console.ReadLine();

            int totalSeats;
            Console.Write("Enter total seats: ");

            if (!int.TryParse(Console.ReadLine(), out totalSeats) || totalSeats < 50)
            {
                Console.Write("Invalid number. Seats must be 50 or more: ");
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

        public static void RegisterPilot()
        {
            Console.WriteLine("=== Register New Pilot ===");

            Console.Write("Enter pilot name: ");
            string name = Console.ReadLine();

            Console.Write("Enter pilot phone: ");
            string phone = Console.ReadLine();
            if (phone.Length != 8 || (phone[0] != '9' && phone[0] != '7'))
            {
                Console.WriteLine("Invalid phone number.");
                return;
            }

            Console.Write("Enter license number: ");
            string licenseNumber = Console.ReadLine();

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
                                  $" | Available Seats: {f.availableSeats}" +
                                  $" | Ticket Price: {f.ticketPrice}" +
                                  $" | Status: {f.status}");
            }
        }

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

            foreach (Aircraft a in context.Aircrafts) //Show All Aircrafts
            {
                Console.WriteLine($"ID: {a.aircraftId} | Model: {a.model} | Seats: {a.totalSeats}");
            }

            Console.Write("Enter Aircraft ID: ");
            int aircraftId = int.Parse(Console.ReadLine());

            Aircraft aircraft = context.Aircrafts  //Find Selected Aircraft
                                .FirstOrDefault(a => a.aircraftId == aircraftId);

            if (aircraft == null) //Check If Aircraft Exists
            {
                Console.WriteLine("Aircraft not found.");
                return;
            }

            foreach (Pilot p in context.Pilots) //Show All Pilots
            {
                Console.WriteLine($"ID: {p.pilotId} | Name: {p.pilotName}");
            }

            Console.Write("Enter Pilot ID: ");
            int pilotId = int.Parse(Console.ReadLine());

            Pilot pilot = context.Pilots //Find Selected Pilot
                          .FirstOrDefault(p => p.pilotId == pilotId);

            if (pilot == null) //Check If Pilot Exists
            {
                Console.WriteLine("Pilot not found.");
                return;
            }

            Console.Write("Enter Origin: ");
            string origin = Console.ReadLine();

            Console.Write("Enter Destination: ");
            string destination = Console.ReadLine();

            Console.Write("Enter Departure Date: ");
            string date = Console.ReadLine();

            Console.Write("Enter Departure Time: ");
            string time = Console.ReadLine();

            Console.Write("Enter Ticket Price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            int flightId = context.Flights.Count + 1;

            context.Flights.Add(new Flight
            {
                flightId = flightId,
                flightCode = "OA-" + flightId, //Creates flight code automatically.
                aircraftId = aircraftId,
                pilotId = pilotId,
                origin = origin,
                destination = destination,
                departureDate = date,
                departureTime = time,
                ticketPrice = price,
                availableSeats = aircraft.totalSeats,
                status = "Scheduled"
            });

            pilot.isAvailable = false;

            Console.WriteLine($"Flight scheduled successfully. Flight Code: OA-{flightId}");
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
                    //case 5: ScheduleFlight(); break;
                    //case 6: BookFlight(); break;
                    //case 7: CancelBooking(); break;
                    //case 8: DepartFlight(); break;
                    //case 9: CancelFlight(); break;
                    //case 10: PassengerBookingHistory(); break;
                    //case 11: FlightRevenueReport(); break;
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

