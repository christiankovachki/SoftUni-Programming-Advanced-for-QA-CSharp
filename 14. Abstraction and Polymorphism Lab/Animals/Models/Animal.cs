using System;

namespace Animals.Models;

public abstract class Animal
{
    private string _name;
    private string _favouriteFood;

    protected string Name { get => _name; set => _name = value; }
    protected string FavouriteFood { get => _favouriteFood; set => _favouriteFood = value; }

    protected Animal(string name, string favouriteFood)
    {
        Name = name;
        FavouriteFood = favouriteFood;
    }

    public virtual string ExplainSelf() 
    {
        return $"I am {Name} and my fovourite food is {FavouriteFood}{Environment.NewLine}";
    }
}