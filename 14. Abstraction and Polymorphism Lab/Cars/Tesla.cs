using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars;

internal class Tesla : IElectricCar, ICar
{
    private string _model;
    private string _color;
    private int _battery;
    public string Model { get => _model; set => _model = value; }
    public string Color { get => _color; set => _color = value; }
    public int Battery { get => _battery; set => _battery = value; }

    public Tesla(string model, string color, int battery)
    {
        Model = model;
        Color = color;
        Battery = battery;
    }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Break!";
    }

    public override string ToString()
    {
        return $"{Color} {GetType().Name} {Model} with {Battery} Batteries{Environment.NewLine}" +
               $"{Start()}{Environment.NewLine}" +
               $"{Stop()}";
    }
}