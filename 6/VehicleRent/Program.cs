using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
    // no need for using interface in my opinion
    public enum PaymentType
    {
        PayPal,
        Cash,
        CreditCard
    }
    
    
    internal class Program
    {

        // renting car function
        public static void RentCar(List<Car> cars, Customer customer, int carIndex, int rentalDays)
        {
            if (carIndex < 0 || carIndex >= cars.Count || cars[carIndex].IsTaken)
            {
                Console.WriteLine("Invalid car selection or car is already rented.");
                return;
            }
            Car selectedCar = cars[carIndex];
            double totalCost = customer.CalculateTotalCost(selectedCar, rentalDays);
            Console.WriteLine($"Total cost is {totalCost}");
            selectedCar.Rent();
            RevenueService.AddRevenue(totalCost);
            Console.WriteLine("Done");
        }
        // renting bike function
        public static void RentBike(List<Bike> bikes, Customer customer, int bikeIndex, int rentalDays)
        {
            if (bikeIndex < 0 || bikeIndex >= bikes.Count || bikes[bikeIndex].IsTaken)
            {
                Console.WriteLine("Invalid bike selection or bike is already rented.");
                return;
            }
            Bike selectedBike = bikes[bikeIndex];
            double totalCost = customer.CalculateTotalCost(selectedBike, rentalDays);
            Console.WriteLine($"Total cost is {totalCost}");
            selectedBike.Rent();
            RevenueService.AddRevenue(totalCost);
            Console.WriteLine("Done");
        }
        static void Main(string[] args)
        {
            // Adding 4 cars 
            Car car1 = new Car("Toyota", "A", 50, true);
            Car car2 = new Car("Honda", "X", 45, false);
            Car car3 = new Car("Ford", "L", 40, true);
            Car car4 = new Car("Chevrolet", "D", 55, false);

            List<Car> Cars = new List<Car> { car1, car2, car3, car4 };


            // Adding 4 bikes
            Bike bike1 = new Bike("Yamaha", "123", 20, true);
            Bike bike2 = new Bike("Kawasaki", "456", 25, false);
            Bike bike3 = new Bike("Ducati", "789", 30, true);
            Bike bike4 = new Bike("KTM", "012", 22, false);

            List<Bike> Bikes = new List<Bike> { bike1, bike2, bike3, bike4 };

            while (true)
            {
                List<Car> availableCars = Cars.Where(c => !c.IsTaken).ToList();
                List<Bike> availableBikes = Bikes.Where(b => !b.IsTaken).ToList();
                Console.WriteLine("To rent a car press 1");
                Console.WriteLine("To rent a bike press 2");
                Console.WriteLine("To view total revenue press 3");
                Console.WriteLine("To view rental cars press 4");
                Console.WriteLine("To view rental bikes press 5");
                Console.WriteLine("To exit press 0");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0)
                    break;
                else if (choice == 1)
                {
                     Console.WriteLine("Enter your name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter your email");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter your phone number");
                    string phone = Console.ReadLine();
                    Console.WriteLine("Enter your address");
                    string address = Console.ReadLine();
                    // in the constructor I will validate the email
                    Customer customer = new Customer(name, phone, email, address);
                    Console.WriteLine("Available Cars:");
                    foreach (var car in availableCars)
                        Console.WriteLine($"{car.Model}");
                    Console.WriteLine("Enter the number of the car");
                    int carChoice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the number of days you want to rent the car for");
                    int rentalDays = Convert.ToInt32(Console.ReadLine());
                    RentCar(Cars, customer, carChoice, rentalDays);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter your name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter your email");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter your phone number");
                    string phone = Console.ReadLine();
                    Console.WriteLine("Enter your address");
                    string address = Console.ReadLine();
                    // in the constructor I will validate the email
                    Customer customer = new Customer(name, phone, email, address);
                    Console.WriteLine("Available Bikes:");
                    foreach (var bike in availableBikes)
                        Console.WriteLine($"{bike.Model}");
                    Console.WriteLine("Enter the number of the bike");
                    int bikeChoice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the number of days you want to rent the bike for");
                    int rentalDays = Convert.ToInt32(Console.ReadLine());
                    RentBike(Bikes, customer, bikeChoice, rentalDays);
                }
                else if (choice == 3)
                {
                    RevenueService.DisplayRevenue();
                }
                else if (choice == 4)
                {
                    foreach (var car in Cars)
                        if (car.IsTaken)
                        {
                            Console.WriteLine($"{car.Model} - {car.License} - Rented");
                        }
                }
                else if (choice == 5)
                {
                    foreach (var bike in Bikes)
                        if (bike.IsTaken)
                        {
                            Console.WriteLine($"{bike.Model} - {bike.License} - Rented");
                        }

                }
                //Console.Clear();
            }
        }
    }
}
