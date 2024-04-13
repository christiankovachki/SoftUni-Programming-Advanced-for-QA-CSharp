namespace _04._Pokemon_Trainer
{
    public class Pokemon
    { 
        private string _name;
        private string _element;
        private int _health;

        public string Name { get => _name; set => _name = value; }
        public string Element { get => _element; set => _element = value; }
        public int Health { get => _health; set => _health = value; }

        public Pokemon() { }

        public Pokemon(string name, string element, int health)
        {
            Name = name;
            Element = element;
            Health = health;
        }
    }
}