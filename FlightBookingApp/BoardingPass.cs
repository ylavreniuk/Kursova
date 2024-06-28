using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingApp
{
    public class BoardingPass
    {
        public string FlightNumber { get; set; }
        public string PassengerName { get; set; }
        public string PassportNumber { get; set; }
        public int SeatNumber { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public double TicketPrice { get; set; }
        public DateTime BookingDate { get; set; }

        public BoardingPass() { }

        public BoardingPass(string flightNumber, string passengerName, string passportNumber, int seatNumber, string departure, string arrival, string departureTime, string arrivalTime, double ticketPrice, DateTime bookingDate)
        {
            FlightNumber = flightNumber;
            PassengerName = passengerName;
            PassportNumber = passportNumber;
            SeatNumber = seatNumber;
            Departure = departure;
            Arrival = arrival;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            TicketPrice = ticketPrice;
            BookingDate = bookingDate;
        }
    }
}
