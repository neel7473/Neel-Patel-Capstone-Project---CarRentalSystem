using System;
using System.Collections.Generic;

public class RentalSystem
{
    private List<Vehicle> vehicles = new List<Vehicle>();
    private List<Customer> customers = new List<Customer>();
    private List<Rental> rentals = new List<Rental>();

    // Add Vehicle
    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
        Console.WriteLine("Vehicle added successfully.");
    }

    // Add Customer
    public void AddCustomer(Customer customer)
    {
        customers.Add(customer);
        Console.WriteLine("Customer added successfully.");
    }

    // Show Available Vehicles
    public void DisplayAvailableVehicles()
    {
        Console.WriteLine("\nAvailable Vehicles:");
        foreach (var vehicle in vehicles)
        {
            if (vehicle.IsAvailable)
            {
                vehicle.DisplayInfo();
                Console.WriteLine("-------------------");
            }
        }
    }

    // Rent Vehicle
    public void RentVehicle(int rentalId, int customerId, int vehicleId, int numberOfDays)
    {
        Customer customer = customers.Find(c => c.CustomerId == customerId);
        Vehicle vehicle = vehicles.Find(v => v.VehicleId == vehicleId);

        if (customer != null && vehicle != null && vehicle.IsAvailable)
        {
            Rental rental = new Rental(rentalId, customer, vehicle, numberOfDays);
            rentals.Add(rental);
            vehicle.IsAvailable = false;
            Console.WriteLine("Vehicle rented successfully!");
        }
        else
        {
            Console.WriteLine("Rental failed. Check IDs or availability.");
        }
    }

    // Return Vehicle
    public void ReturnVehicle(int vehicleId)
    {
        Vehicle vehicle = vehicles.Find(v => v.VehicleId == vehicleId);

        if (vehicle != null)
        {
            vehicle.IsAvailable = true;
            Console.WriteLine("Vehicle returned successfully!");
        }
        else
        {
            Console.WriteLine("Vehicle not found.");
        }
    }
}