using System;

public abstract class Transport
{
    public string Model { get; set; }
    public int Capacity { get; set; }
    public double FuelConsumption { get; set; }

    protected Transport() { }

    protected Transport(string model, int capacity, double fuelConsumption)
    {
        Model = model;
        Capacity = capacity;
        FuelConsumption = fuelConsumption;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Модель: {Model}, Місткість: {Capacity}, Споживання палива: {FuelConsumption}");
    }

    public abstract void Start();
}
