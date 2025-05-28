using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{

    internal class Program
    {
        static void Buy(Product product1, Product product2, Product product3, int choice, Order order)
        {
            Console.WriteLine("Enter number of the items");
            int quantity = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    order.AddProduct(product1, quantity);
                    break;
                case 2:
                    order.AddProduct(product2, quantity);
                    break;
                case 3:
                    order.AddProduct(product3, quantity);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program(); // Create an instance of Program  
            Product product1 = new Product("Iphone", 120);
            Product product2 = new Product("Mouse", 20);
            Product product3 = new Product("Keyboard", 30);
            Order order = new Order("Karim"); // Declare order outside the loop  

            while (true)
            {
                Console.WriteLine("Which product do you want to buy?");
                Console.WriteLine("1. Iphone");
                Console.WriteLine("2. Mouse");
                Console.WriteLine("3. Keyboard");
                Console.WriteLine("4. Exit");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 4)
                    break;
                else
                    Buy(product1, product2, product3, choice, order);
            }

            Invoice invoice = new Invoice(order);
            ConsoleExport consoleExport = new ConsoleExport();
            consoleExport.Export(invoice);
        }
    }
}
