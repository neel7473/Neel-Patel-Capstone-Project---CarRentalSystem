using System;

public class Truck : Vehicle
{
    // Additional property
    public double LoadCapacity { get; set; }

    // Constructor
    public Truck(int vehicleId, string brand, string model, int year, double rentalPricePerDay, double loadCapacity)
        : base(vehicleId, brand, model, year, rentalPricePerDay)
    {
        LoadCapacity = loadCapacity;
    }

    // Override DisplayInfo
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Load Capacity: {LoadCapacity} tons");
    }
}