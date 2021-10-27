using System;
using System.IO;
using System.Linq;

namespace PokemonMatchup
{
    class Program
    {
        static void Main(string[] args)
        {
            EnemyPokemon enemyPokemon = new EnemyPokemon(Console.ReadLine());

            Console.WriteLine(enemyPokemon.getType1());

            //var linesOfCsv = File.ReadAllLines("/users/loganheinz/projects/pokemonmatchup/pokemonmatchup/pokemon.csv");

            //foreach (var pokemon in linesOfCsv)
            //{
            //    Console.WriteLine(pokemon);
            //}
        }
    }
}

///users/loganheinz/projects/pokemonmatchup/pokemonmatchup/pokemon.csv
//
