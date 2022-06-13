using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            string command;

            Dictionary<string, Trainer> dic = new Dictionary<string, Trainer>();

            while ((command = Console.ReadLine()) != "Tournament")
            {
                var cmdArgs = command.Split();

                string trainerName = cmdArgs[0];
                string pokemonName = cmdArgs[1];
                string pokemonElement = cmdArgs[2];
                int pokemonHealth = int.Parse(cmdArgs[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                Trainer trainer = new Trainer(trainerName, new List<Pokemon> { pokemon });

                if (!dic.ContainsKey(trainerName))
                {
                    dic.Add(trainerName, trainer);
                }
                else
                {
                    dic[trainerName].Pokemons.Add(pokemon);
                }
            }

            string secondCommand;

            while ((secondCommand = Console.ReadLine()) != "End")
            {
                foreach (var (trainerName, trainers) in dic)
                {
                    bool hasAtleastOneElement = false;
                    foreach (var pokemon in trainers.Pokemons)
                    {
                        if (pokemon.Element == secondCommand)
                        {
                            hasAtleastOneElement = true;
                            break;

                        }
                        else
                        {
                            hasAtleastOneElement = false;
                        }
                    }
                    if (hasAtleastOneElement)
                    {
                        dic[trainerName].NumberOfBadges += 1;
                    }
                    else
                    {
                        trainers.Pokemons.ForEach(x => x.Health -= 10);
                    }
                    if (trainers.Pokemons.Any(x => x.Health <= 0))
                    {
                        dic[trainerName].Pokemons.RemoveAll(x => x.Health <= 0);
                    }
                }
            }

            foreach (var (trainer, trainers) in dic.OrderByDescending(x => x.Value.NumberOfBadges))
            {
                Console.WriteLine($"{trainer} {trainers.NumberOfBadges} {trainers.Pokemons.Count}");
            }
        }
    }
}
