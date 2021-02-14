using System;
using System.Collections.Generic;
using System.Text;

namespace _09.PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name, Pokemon pokemon)
        {
            Name = name;
            Pokemons = new List<Pokemon>();
            Pokemons.Add(pokemon);
        }
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> Pokemons { get; set; }
    }
}
