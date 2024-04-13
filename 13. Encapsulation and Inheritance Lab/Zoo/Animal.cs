namespace Zoo;

public class Animal
{
    private string _name;

    public string Name { get => _name; set => _name = value; }

    public Animal(string name)
    {
        Name = name;
    }
}