using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Engine
    {
        private int _horsePower;
        private double _cubicCapacity;
        public int HorsePower { get { return _horsePower; } set { _horsePower = value; } }
        public double CubicCapacity { get { return _cubicCapacity; } set { _cubicCapacity = value; } }

        public Engine() { }

        public Engine(int horsePower, double cubicCapacity) 
        {
            HorsePower = horsePower;
            CubicCapacity = cubicCapacity;
        }
    }
}