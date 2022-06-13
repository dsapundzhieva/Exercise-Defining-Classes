using System.Collections.Generic;

namespace DefiningClasses
{
    public class Trainer
    {
        public Trainer(string name, List<Pokemon> pokemons)
        {
            this.Name = name;
            this.NumberOfBadges = 0;
            this.Pokemons = pokemons;
        }

        public string Name { get; set; }

        public int NumberOfBadges { get; set; }

        public List<Pokemon> Pokemons { get; set; }

        
    }
}
