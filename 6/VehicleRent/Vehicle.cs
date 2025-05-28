using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
    public class Vehicle
    {
        private string _model;
        private string _license;
        private int _rent_price_per_day;
        private bool _is_taken;
        public string Model { get { return _model; } }
        public string License { get { return _license; } }
        public bool IsTaken { get { return _is_taken; } }


        public Vehicle(string model, string license, int rent_price_per_day)
        {
            _model = model;
            _license = license;
            _rent_price_per_day = rent_price_per_day;
            _is_taken = false;
        }

        public virtual double RentalCost(int rental_days)
        {
            return _rent_price_per_day * rental_days;
        }
        public void Rent()
        {
            _is_taken = true;
        }

    }

    public class Car : Vehicle
    {
        public bool _is_Automatic;
        public Car(string model, string license, int rent_price_per_day, bool isAutomatic) : base(model, license, rent_price_per_day)
        {
            _is_Automatic = isAutomatic;
        }


        public override double RentalCost(int rental_days)
        {
            double cost = base.RentalCost(rental_days);
            if (_is_Automatic)
                return cost + (0.1 * cost);
            return cost;
        }
    }

    public class Bike : Vehicle
    {
        public bool _has_Helmet;
        public Bike(string model, string license, int rent_price_per_day, bool has_helmet) : base(model, license, rent_price_per_day)
        {
            _has_Helmet = has_helmet;
        }

        public override double RentalCost(int rental_days)
        {
            double cost = base.RentalCost(rental_days);
            if (_has_Helmet)
                return cost + (0.05 * cost);
            return cost;
        }
    }
}
