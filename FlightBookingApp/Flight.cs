using System;
using System.Collections.Generic;

public class Flight : IComparable<Flight>
{
    public string FlightNumber { get; set; }
    public Airplane Airplane { get; set; }
    public string Departure { get; set; }
    public string Arrival { get; set; }
    public List<string> Stopovers { get; set; }
    public string DepartureTime { get; set; }
    public string ArrivalTime { get; set; }
    public List<DayOfWeek> FlightDays { get; set; }
    public int AvailableSeats { get; set; }
    public double TicketPrice { get; set; }

    public Flight() { }

    public Flight(string flightNumber, Airplane airplane, string departure, string arrival, List<string> stopovers, string departureTime, string arrivalTime, List<DayOfWeek> flightDays, int availableSeats, double ticketPrice)
    {
        FlightNumber = flightNumber;
        Airplane = airplane;
        Departure = departure;
        Arrival = arrival;
        Stopovers = stopovers;
        DepartureTime = departureTime;
        ArrivalTime = arrivalTime;
        FlightDays = flightDays;
        AvailableSeats = availableSeats;
        TicketPrice = ticketPrice;
    }

    public int CompareTo(Flight other)
    {
        return DepartureTime.CompareTo(other.DepartureTime);
    }

    public bool IsFlyingOn(DayOfWeek day)
    {
        return FlightDays.Contains(day);
    }

    public bool HasAvailableSeats()
    {
        return AvailableSeats > 0;
    }

    public void BookTickets(int numberOfTickets)
    {
        if (numberOfTickets <= AvailableSeats)
        {
            AvailableSeats -= numberOfTickets;
        }
        else
        {
            throw new InvalidOperationException("Недостатньо вільних місць.");
        }
    }
}

