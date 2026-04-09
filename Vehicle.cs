using System;

public class Vehicle
{
    // Properties (Attributes)
    public int VehicleId { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double RentalPricePerDay { get; set; }
    public bool IsAvailable { get; set; }

    // Constructor
    public Vehicle(int vehicleId, string brand, string model, int year, double rentalPricePerDay)
    {
        VehicleId = vehicleId;
        Brand = brand;
        Model = model;
        Year = year;
        RentalPricePerDay = rentalPricePerDay;
        IsAvailable = true; // default available
    }

    // Method to calculate rental cost
    public virtual double CalculateRentalCost(int numberOfDays)
    {
        return RentalPricePerDay * numberOfDays;
    }

    // Method to display vehicle info
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"ID: {VehicleId}");
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Price per Day: {RentalPricePerDay}");
        Console.WriteLine($"Available: {IsAvailable}");
    }
}