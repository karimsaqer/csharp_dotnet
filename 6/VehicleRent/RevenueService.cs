using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
    public static class RevenueService
    {
        private static double _totalRevenue = 0;
        public static void AddRevenue(double amount)
        {
            _totalRevenue += amount;
        }
        public static double GetTotalRevenue()
        {
            return _totalRevenue;
        }

        public static void DisplayRevenue()
        {
            Console.WriteLine($"Total Revenue: {_totalRevenue}");
        }
    }
}
