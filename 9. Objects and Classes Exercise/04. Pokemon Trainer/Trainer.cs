namespace _04._Pokemon_Trainer
{
    public class Trainer
    { 
        private string _name;
        private int _numberOfBadges;
        private List<Pokemon> _pokemons;

        public string Name { get => _name; set => _name = value; }
        public int NumberOfBadges { get => _numberOfBadges; set => _numberOfBadges = value; }
        public List<Pokemon> Pokemons { get => _pokemons; set => _pokemons = value; }

        public Trainer() { }

        public Trainer(string name)
        {
            Name = name;
            NumberOfBadges = 0;
            Pokemons = new List<Pokemon>();
        }
    }
}