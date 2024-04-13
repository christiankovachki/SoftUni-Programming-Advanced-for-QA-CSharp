using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars;

public class Seat : ICar
{
    private string _model;
    private string _color;
    public string Model { get => _model; set => _model = value; }
    public string Color { get => _color; set => _color = value; }

    public Seat(string model, string color)
    {
        Model = model;
        Color = color;
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
        return $"{Color} {GetType().Name} {Model}{Environment.NewLine}" +
               $"{Start()}{Environment.NewLine}" +
               $"{Stop()}";
    }
}