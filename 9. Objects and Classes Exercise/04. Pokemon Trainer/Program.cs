namespace _04._Pokemon_Trainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            string command = Console.ReadLine();

            while (command != "Tournament")
            {
                string[] input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string trainerName = input[0];
                string pokemonName = input[1];
                string pokemonElement = input[2];
                int pokemonHealth = int.Parse(input[3]);

                if (!trainers.ContainsKey(trainerName))
                {
                    Trainer trainer = new Trainer(trainerName);
                    trainers.Add(trainerName, trainer);
                }

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                trainers[trainerName].Pokemons.Add(pokemon);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                if (command == "Fire")
                {
                    CheckPokemonForElement(trainers, command);
                }
                else if (command == "Water")
                {
                    CheckPokemonForElement(trainers, command);
                }
                else if (command == "Electricity")
                {
                    CheckPokemonForElement(trainers, command);
                }

                command = Console.ReadLine();
            }

            trainers.OrderByDescending(t => t.Value.NumberOfBadges)
                    .Select(t => 
                        { 
                            Console.WriteLine($"{t.Value.Name} {t.Value.NumberOfBadges} {t.Value.Pokemons.Count}");

                            return 1;
                        })
                    .ToList();
        }

        public static void CheckPokemonForElement(Dictionary<string, Trainer> trainers, string command)
        {
            foreach (var trainer in trainers.Values)
            {
                bool hasElement = trainer.Pokemons.Any(p => p.Element.Equals(command)).Equals(true);
                if (hasElement)
                {
                    trainer.NumberOfBadges++;
                }
                else
                {
                    trainer.Pokemons.ForEach(p => p.Health -= 10);
                    trainer.Pokemons.RemoveAll(p => p.Health <= 0);
                }
            }
        }
    }
}