using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PokemonMatchup
{
    class Program
    {
        static void Main(string[] args)
        {

            //initialize the pokedex class which should be an array full of pokemon with their info

            Pokemon[] pokedex = Pokedex.InitializePokedex();

            //sets a variable --> will define the enemyPokemon object in the method
            Console.WriteLine("what Pokemon are you up against?");
            string enemy = Console.ReadLine();

            string enemyType1 = EnemyPokemon.GetEnemyType1(pokedex, enemy).ToLower();
            string enemyType2 = EnemyPokemon.GetEnemyType2(pokedex, enemy).ToLower() ;

            List<string> supers = EnemyPokemon.GetSuperEffective(enemyType1, enemyType2);

            if (enemyType1 != null && enemyType2 != "")
                Console.WriteLine($"Your enemy, {enemy}, is a {enemyType1}/{enemyType2} type");
            else if (enemyType1 != null && enemyType2 == "")
                Console.WriteLine($"Your enemy, {enemy}, is a {enemyType1} type");
            else
                Console.WriteLine($"I can't find that pokemon in the pokedex");

            Console.WriteLine("You should use Pokemon of the following types.");

            foreach (string type in supers)
            {
                Console.WriteLine(type);
            }
        }
    }
}


///users/loganheinz/projects/pokemonmatchup/pokemonmatchup/pokemon.csv
//
