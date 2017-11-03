using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Pokemon_Evolution
{
    class PokemonInfo
    {
        public string PokemonName { get; set; }
        public List<KeyValuePair<string, int>> TypeAndIndex { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<PokemonInfo> pokemonsData = new List<PokemonInfo>();
            
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "wubbalubbadubdub")
                {
                    break;
                }

                string[] data = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                PokemonInfo pokemonInfo = new PokemonInfo();
                pokemonInfo.TypeAndIndex = new List<KeyValuePair<string, int>>();

                if (data.Length == 1)
                {
                    foreach (var item in pokemonsData.Where(x => x.PokemonName.Contains(data[0])))
                    {
                        Console.WriteLine($"# {item.PokemonName}");
                        foreach (var pokemon in item.TypeAndIndex)
                        {
                            Console.WriteLine($"{pokemon.Key} <-> {pokemon.Value}");
                        }
                    }
                }
                else
                {
                    if (pokemonsData.Any(x => x.PokemonName.Equals(data[0])))
                    {
                        foreach (var pokemon in pokemonsData.Where(x => x.PokemonName.Equals(data[0])))
                        {
                            pokemon.TypeAndIndex.Add(new KeyValuePair<string, int>(data[1], int.Parse(data[2])));
                        }
                    }
                    else
                    {
                        pokemonInfo.PokemonName = data[0];
                        pokemonInfo.TypeAndIndex.Add(new KeyValuePair<string, int>(data[1], int.Parse(data[2])));
                        pokemonsData.Add(pokemonInfo);
                    }
                }
            }

            foreach (var item in pokemonsData)
            {
                Console.WriteLine($"# {item.PokemonName}");
                foreach (var pokemon in item.TypeAndIndex.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{pokemon.Key} <-> {pokemon.Value}");
                }
            }
        }
    }
}
