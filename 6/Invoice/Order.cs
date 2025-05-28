using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    internal class Order
    {
        public Dictionary<Product, int> ProductQuantities { get; }
        public string CustomerName { get; }

        public double Total
        {
            get
            {
                // (pq => pq.Key.Price * pq.Value) it is like foreach loop but in one line
                return (double)ProductQuantities.Sum(pq => pq.Key.Price * pq.Value);
            }
        }

        public Order(string customerName)
        {
            CustomerName = customerName;
            ProductQuantities = new Dictionary<Product, int>();
        }

        public void AddProduct(Product product, int quantity)
        {
            if (quantity <= 0)
                throw new ArgumentException("quantity no negative or zero");

            if (ProductQuantities.ContainsKey(product))
                ProductQuantities[product] += quantity;
            else
                ProductQuantities[product] = quantity;
        }

    }
}
