using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
    public class Customer
    {
        private string _name;
        private string _phone;
        private string _email;
        private string _address;

        public string Name { get { return _name; } }
        public string Phone { get { return _phone; } }
        public string Email { get { return _email; } }
        public string Address { get { return _address; } }

        public Customer(string name, string phone, string email, string address)
        {
            _name = name;
            _phone = phone;
            // email validation.
            if (!email.Contains("@") || !email.Contains("."))
            {
                throw new ArgumentException("Invalid email");
            }
            _email = email;
            _address = address;
        }

        public double CalculateTotalCost(Vehicle vehicle, int days)
        {
            return vehicle.RentalCost(days);
        }
    }
}
