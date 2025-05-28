using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    internal class Invoice
    {
        public Order Order { get; }
        public DateTime Date { get; }

        public Invoice(Order order)
        {
            Order = order;
            Date = DateTime.Now;
        }
    }
}
