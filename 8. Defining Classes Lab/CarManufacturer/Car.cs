using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Car
    {
        private string _make;
        private string _model;
        private int _year;
        private double _fuelQuantity;
        private double _fuelConsumption;
        private Engine _engine;
        private Tire[] _tires;
        public string Make { get { return _make; } set {  _make = value; } }
        public string Model { get { return _model; } set { _model = value; } }
        public int Year { get { return _year; } set { _year = value; } }
        public double FuelQuantity { get { return _fuelQuantity; } set { _fuelQuantity = value; } }
        public double FuelConsumption { get { return _fuelConsumption; } set { _fuelConsumption = value; } }
        public Engine Engine { get { return _engine; } set { _engine = value; } }
        public Tire[] Tires { get { return _tires; } set { _tires = value; } }

        public Car() 
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumption) 
        {
            Engine = engine;
            Tires = tires;
        }

        public void Drive(double distance)
        {
            if (FuelQuantity - (distance * FuelConsumption) > 0)
            {
                FuelQuantity -= (distance * FuelConsumption);
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {this.Make}{Environment.NewLine}" +
                   $"Model: {this.Model}{Environment.NewLine}" +
                   $"Year: {this.Year}{Environment.NewLine}" +
                   $"Fuel: {this._fuelQuantity:F2}";
        }
    }
}