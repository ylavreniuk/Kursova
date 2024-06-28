using System;

public class Airplane : Transport
{
    public string Airline { get; set; }

    public Airplane() : base() { }

    public Airplane(string model, int capacity, double fuelConsumption, string airline)
        : base(model, capacity, fuelConsumption)
    {
        Airline = airline;
    }

    public override void Start()
    {
        Console.WriteLine("Літак запускається.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Авіакомпанія: {Airline}");
    }
}
