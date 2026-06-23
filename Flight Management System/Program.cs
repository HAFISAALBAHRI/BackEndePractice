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

        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                bool exit = false;

                while (exit == false)
                {
                    Console.WriteLine("\n========================================");
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
                        //case 1: RegisterPassenger(); break;
                        //case 2: AddAircraft(); break;
                        //case 3: RegisterPilot(); break;
                        //case 4: ViewAllFlights(); break;
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
}
