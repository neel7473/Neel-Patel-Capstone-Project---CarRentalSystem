using System;

public class Car : Vehicle
{
    // Additional property
    public int NumberOfDoors { get; set; }

    // Constructor
    public Car(int vehicleId, string brand, string model, int year, double rentalPricePerDay, int numberOfDoors)
        : base(vehicleId, brand, model, year, rentalPricePerDay)
    {
        NumberOfDoors = numberOfDoors;
    }

    // Override DisplayInfo
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Number of Doors: {NumberOfDoors}");
    }
}