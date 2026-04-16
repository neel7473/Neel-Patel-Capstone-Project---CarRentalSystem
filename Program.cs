using System;

class Program
{
    static void Main(string[] args)
    {
        RentalSystem system = new RentalSystem();

        while (true)
        {
            Console.WriteLine("\n===== Car Rental System =====");
            Console.WriteLine("1. Add Car");
            Console.WriteLine("2. Add Truck");
            Console.WriteLine("3. Add Customer");
            Console.WriteLine("4. Rent Vehicle");
            Console.WriteLine("5. Return Vehicle");
            Console.WriteLine("6. Show Available Vehicles");
            Console.WriteLine("7. Exit");
            Console.WriteLine("=============================");

            Console.Write("Choose an option: ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Try again.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Car ID: ");
                    int carId = int.Parse(Console.ReadLine());

                    Console.Write("Brand: ");
                    string brand = Console.ReadLine();

                    Console.Write("Model: ");
                    string model = Console.ReadLine();

                    Console.Write("Year: ");
                    int year = int.Parse(Console.ReadLine());

                    Console.Write("Price per day: ");
                    double price = double.Parse(Console.ReadLine());

                    Console.Write("Number of doors: ");
                    int doors = int.Parse(Console.ReadLine());

                    system.AddVehicle(new Car(carId, brand, model, year, price, doors));
                    break;

                case 2:
                    Console.Write("Enter Truck ID: ");
                    int truckId = int.Parse(Console.ReadLine());

                    Console.Write("Brand: ");
                    string tBrand = Console.ReadLine();

                    Console.Write("Model: ");
                    string tModel = Console.ReadLine();

                    Console.Write("Year: ");
                    int tYear = int.Parse(Console.ReadLine());

                    Console.Write("Price per day: ");
                    double tPrice = double.Parse(Console.ReadLine());

                    Console.Write("Load capacity: ");
                    double capacity = double.Parse(Console.ReadLine());

                    system.AddVehicle(new Truck(truckId, tBrand, tModel, tYear, tPrice, capacity));
                    break;

                case 3:
                    Console.Write("Enter Customer ID: ");
                    int custId = int.Parse(Console.ReadLine());

                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Phone: ");
                    string phone = Console.ReadLine();

                    system.AddCustomer(new Customer(custId, name, phone));
                    break;

                case 4:
                    system.DisplayAvailableVehicles();
                    Console.Write("Rental ID: ");
                    int rentalId = int.Parse(Console.ReadLine());

                    Console.Write("Customer ID: ");
                    int customerId = int.Parse(Console.ReadLine());

                    Console.Write("Vehicle ID: ");
                    int vehicleId = int.Parse(Console.ReadLine());

                    Console.Write("Number of days: ");
                    int days = int.Parse(Console.ReadLine());

                    system.RentVehicle(rentalId, customerId, vehicleId, days);
                    break;

                case 5:
                    Console.Write("Enter Vehicle ID to return: ");
                    int returnId = int.Parse(Console.ReadLine());

                    system.ReturnVehicle(returnId);
                    break;

                case 6:
                    system.DisplayAvailableVehicles();
                    break;

                case 7:
                    Console.WriteLine("Exiting program...");
                    return;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}