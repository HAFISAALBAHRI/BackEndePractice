namespace Flight_Management_System.Models
{
    public class Passenger
    {
        public int PassengerId { get; set; }   //system generated
        public string PassengerName { get; set; }  //user input
        public string PassengerEmail { get; set; }  //user input
        public string PassengerPhone { get; set; }  //user input
        public string PassportNumber { get; set; }  //user input
        public string Nationality { get; set; }  //user input
    }
}