using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    interface Exports
    {
        void Export(Invoice invoice);
    }

    class ConsoleExport : Exports
    {
        public void Export(Invoice invoice)
        {
            List<Product> products = invoice.Order.ProductQuantities.Keys.ToList();
            Console.WriteLine($"{invoice.Date}");
            Console.WriteLine("number  item  price  total");
            
            foreach (var product in products)
            {
                int quantity = invoice.Order.ProductQuantities[product];
                string total = $"{product.Price * quantity}$";
                Console.WriteLine($" {quantity}      {product.Name}  {product.Price}    {total}");
            }
            Console.WriteLine($"Total: {invoice.Order.Total}");
        }
    }

    class PDFExport : Exports
    {
        public void Export(Invoice invoice)
        {
            // Logic PDF export
        }
    }

    class XMLExport : Exports
    {
        public void Export(Invoice invoice)
        {
            // Logic XML export
        }
    }

    class JSONExport : Exports
    {
        public void Export(Invoice invoice)
        {
            // Logic JSON export
        }
    }

    class ExcelExport : Exports
    {
        public void Export(Invoice invoice)
        {
            // Logic Excel export
        }
    }
}
