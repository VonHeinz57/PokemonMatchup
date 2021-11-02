using System;
using System.Collections.Generic;

namespace PokemonMatchup
{
    public class Pokedex
    {

        public static Pokemon[] InitializePokedex()
        {
            string[] csvLines = System.IO.File.ReadAllLines($"/users/loganheinz/projects/pokemonmatchup/pokemonmatchup/pokemon.csv");

            var pokedex = new List<Pokemon>();

            for (int i = 1; i <csvLines.Length; i++)
            {
                Pokemon pokemon = new Pokemon(csvLines[i]);
                pokedex.Add(pokemon);
            }

            return pokedex.ToArray();
        }

        // HARD CODED ARRAY FOR TESTING //

        //create the full array to be referenced, use the CSV for this, go ahead and store all the values
        //public static Pokemon[] InitializePokedex()
        //{
        //    return new Pokemon[] {
        //        new Pokemon(1,"Bulbasaur","Grass","Poison"),
        //        new Pokemon(2,"Ivysaur","Grass","Poison"),
        //        new Pokemon(3,"Venusaur","Grass","Poison"),
        //        new Pokemon(4,"Charmander","Fire",""),
        //        new Pokemon(5,"Charmeleon","Fire",""),
        //        new Pokemon(6,"Charizard","Fire","Flying"),
        //        new Pokemon(7,"Squirtle","Water",""),
        //        new Pokemon(8,"Wartortle","Water",""),
        //        new Pokemon(9,"Blastoise","Water","")
        //    };
    
    }
}