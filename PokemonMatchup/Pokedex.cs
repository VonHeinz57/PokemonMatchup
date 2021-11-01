using System;
namespace PokemonMatchup
{
    public class Pokedex
    {


        //create the full array to be referenced, use the CSV for this, go ahead and store all the values
        public static Pokemon[] InitializePokedex()
        {
            return new Pokemon[] {
                new Pokemon(1,"Bulbasaur","Grass","Poison"),
                new Pokemon(2,"Ivysaur","Grass","Poison"),
                new Pokemon(3,"Venusaur","Grass","Poison"),
                new Pokemon(4,"Charmander","Fire",""),
                new Pokemon(5,"Charmeleon","Fire",""),
                new Pokemon(6,"Charizard","Fire","Flying"),
                new Pokemon(7,"Squirtle","Water",""),
                new Pokemon(8,"Wartortle","Water",""),
                new Pokemon(9,"Blastoise","Water","")
            };
        }
    }
}