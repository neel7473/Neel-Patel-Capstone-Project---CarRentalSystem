using System;

public class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }

    public Customer(int customerId, string name, string phoneNumber)
    {
        CustomerId = customerId;
        Name = name;
        PhoneNumber = phoneNumber;
    }

    public void DisplayCustomerInfo()
    {
        Console.WriteLine($"Customer ID: {CustomerId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Phone: {PhoneNumber}");
    }
}