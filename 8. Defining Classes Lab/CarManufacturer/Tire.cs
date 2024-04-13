using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Tire
    {
        private int _year;
        private double _pressure;
        public int Year { get { return _year; } set {  _year = value; } }
        public double Pressure { get { return _pressure; } set { _pressure = value; } }

        public Tire() { }

        public Tire(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }
    }
}