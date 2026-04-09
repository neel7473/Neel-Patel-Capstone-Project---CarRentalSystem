using System;

public class Rental
{
    public int RentalId { get; set; }
    public Customer Customer { get; set; }
    public Vehicle Vehicle { get; set; }
    public int NumberOfDays { get; set; }
    public double TotalCost { get; set; }

    public Rental(int rentalId, Customer customer, Vehicle vehicle, int numberOfDays)
    {
        RentalId = rentalId;
        Customer = customer;
        Vehicle = vehicle;
        NumberOfDays = numberOfDays;
        TotalCost = CalculateTotalCost();
    }

    public double CalculateTotalCost()
    {
        return Vehicle.CalculateRentalCost(NumberOfDays);
    }

    public void DisplayRentalInfo()
    {
        Console.WriteLine($"Rental ID: {RentalId}");
        Customer.DisplayCustomerInfo();
        Vehicle.DisplayInfo();
        Console.WriteLine($"Days: {NumberOfDays}");
        Console.WriteLine($"Total Cost: {TotalCost}");
    }
}