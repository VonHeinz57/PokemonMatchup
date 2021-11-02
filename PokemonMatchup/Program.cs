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
            int i = 1;
            while (i > 0)
            {
                Console.WriteLine("Welcome to Pokemon Matchup! What would you like to do?");
                Console.WriteLine("1: Search for super effective types by enemy name");
                Console.WriteLine("2: Quit");

                int entry = Convert.ToInt32(Console.ReadLine());

                if (entry == 1)
                {


                    //initialize the pokedex class which should be an array full of pokemon with their info

                    Pokemon[] pokedex = Pokedex.InitializePokedex();

                    //sets a variable --> will define the enemyPokemon object in the method
                    Console.WriteLine("What Pokemon are you up against?");
                    string enemy = Console.ReadLine();

                    string enemyForCheck = enemy.ToLower();

                    string enemyType1 = EnemyPokemon.GetEnemyType1(pokedex, enemyForCheck).ToLower();
                    string enemyType2 = EnemyPokemon.GetEnemyType2(pokedex, enemyForCheck).ToLower();

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

                else if (entry == 2)
                {
                    i = 0;
                }

                else
                {
                    Console.WriteLine("Not a valid entry.");
                }
            }
        }
    }
}