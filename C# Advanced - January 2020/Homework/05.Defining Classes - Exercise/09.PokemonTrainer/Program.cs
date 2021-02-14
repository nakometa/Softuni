using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            string input = Console.ReadLine();

            while (input != "Tournament")
            {
                string[] data = input.Split();
                string trainer = data[0];
                string pokemon = data[1];
                string pokemonElement = data[2];
                int pokemonHealth = int.Parse(data[3]);
                Pokemon currPokemon = new Pokemon(pokemon, pokemonElement, pokemonHealth);
                Trainer currTrainer;
                if (!trainers.Any(n => n.Name == trainer))
                {
                    currTrainer = new Trainer(trainer, currPokemon);
                    trainers.Add(currTrainer);
                }
                else
                {
                    trainers.FirstOrDefault(n => n.Name == trainer).Pokemons.Add(currPokemon);
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();

            while (input != "End")
            {
                foreach (Trainer trainer in trainers)
                {
                    if (trainer.Pokemons.Any(e => e.Element == input))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        foreach (Pokemon pokemon in trainer.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }
                        trainer.Pokemons = trainer.Pokemons.Where(p => p.Health > 0).ToList();
                    }
                }
                input = Console.ReadLine();
            }

            foreach (Trainer trainer in trainers.OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count()}");
            }
        }
    }
}
