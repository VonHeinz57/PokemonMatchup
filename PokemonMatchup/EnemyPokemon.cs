using System;
using System.Collections.Generic;
using System.IO;

namespace PokemonMatchup
{
    public class EnemyPokemon 
    {
        
        public static string GetEnemyType1(Pokemon[] pokedex, string enemy)
        {
            foreach (Pokemon enemyPokemon in pokedex)
            {
                if (enemyPokemon.Name == enemy)
                    return enemyPokemon.Type1;
            }
            return null;
        }

        public static string GetEnemyType2(Pokemon[] pokedex, string enemy)
        {
            foreach (Pokemon enemyPokemon in pokedex)
            {
                if (enemyPokemon.Name == enemy)
                    return enemyPokemon.Type2;
            }
            return null;
        }

        public static List<string> GetSuperEffective(string type1, string type2)
        {
            List<string> superEffective = new List<string>();

            if (type1 == "bug")
            {
                superEffective.Add("grass");
                superEffective.Add("dark");
                superEffective.Add("psychic");
            }

            if (type1 == "dark")
            {
                superEffective.Add("ghost");
                superEffective.Add("psychic");
            }

            if (type1 == "dragon")
            {
                superEffective.Add("dragon");
            }

            if (type1 == "electric")
            {
                superEffective.Add("flying");
                superEffective.Add("water");
            }

            if (type1 == "fairy")
            {
                superEffective.Add("fighting");
                superEffective.Add("dark");
                superEffective.Add("dragon");
            }

            if (type1 == "fighting")
            {
                superEffective.Add("dark");
                superEffective.Add("ice");
                superEffective.Add("normal");
                superEffective.Add("rock");
                superEffective.Add("steel");
            }

            if (type1 == "fire")
            {
                superEffective.Add("bug");
                superEffective.Add("grass");
                superEffective.Add("ice");
                superEffective.Add("steel");
            }

            if (type1 == "flying")
            {
                superEffective.Add("bug");
                superEffective.Add("fighting");
                superEffective.Add("grass");
            }

            if (type1 == "ghost")
            {
                superEffective.Add("ghost");
                superEffective.Add("psychic");
            }

            if (type1 == "grass")
            {
                superEffective.Add("ground");
                superEffective.Add("rock");
                superEffective.Add("water");
            }

            if (type1 == "ground")
            {
                superEffective.Add("electric");
                superEffective.Add("fire");
                superEffective.Add("poison");
                superEffective.Add("rock");
                superEffective.Add("steel");
            }

            if (type1 == "ice")
            {
                superEffective.Add("dragon");
                superEffective.Add("flying");
                superEffective.Add("grass");
                superEffective.Add("ground");
            }

            if (type1 == "poison")
            {
                superEffective.Add("fairy");
                superEffective.Add("grass");
            }

            if (type1 == "psychic")
            {
                superEffective.Add("fighting");
                superEffective.Add("poison");
            }

            if (type1 == "rock")
            {
                superEffective.Add("bug");
                superEffective.Add("fire");
                superEffective.Add("flying");
                superEffective.Add("ice");
            }

            if (type1 == "steel")
            {
                superEffective.Add("fairy");
                superEffective.Add("ice");
                superEffective.Add("rock");
            }

            if (type1 == "water")
            {
                superEffective.Add("fire");
                superEffective.Add("ground");
                superEffective.Add("rock");
            }

            if (type2 == "bug")
            {
                superEffective.Add("grass");
                superEffective.Add("dark");
                superEffective.Add("psychic");
            }

            if (type2 == "dark")
            {
                superEffective.Add("ghost");
                superEffective.Add("psychic");
            }

            if (type2 == "dragon")
            {
                superEffective.Add("dragon");
            }

            if (type2 == "electric")
            {
                superEffective.Add("flying");
                superEffective.Add("water");
            }

            if (type2 == "fairy")
            {
                superEffective.Add("fighting");
                superEffective.Add("dark");
                superEffective.Add("dragon");
            }

            if (type2 == "fighting")
            {
                superEffective.Add("dark");
                superEffective.Add("ice");
                superEffective.Add("normal");
                superEffective.Add("rock");
                superEffective.Add("steel");
            }

            if (type2 == "fire")
            {
                superEffective.Add("bug");
                superEffective.Add("grass");
                superEffective.Add("ice");
                superEffective.Add("steel");
            }

            if (type2 == "flying")
            {
                superEffective.Add("bug");
                superEffective.Add("fighting");
                superEffective.Add("grass");
            }

            if (type2 == "ghost")
            {
                superEffective.Add("ghost");
                superEffective.Add("psychic");
            }

            if (type2 == "grass")
            {
                superEffective.Add("ground");
                superEffective.Add("rock");
                superEffective.Add("water");
            }

            if (type2 == "ground")
            {
                superEffective.Add("electric");
                superEffective.Add("fire");
                superEffective.Add("poison");
                superEffective.Add("rock");
                superEffective.Add("steel");
            }

            if (type2 == "ice")
            {
                superEffective.Add("dragon");
                superEffective.Add("flying");
                superEffective.Add("grass");
                superEffective.Add("ground");
            }

            if (type2 == "poison")
            {
                superEffective.Add("fairy");
                superEffective.Add("grass");
            }

            if (type2 == "psychic")
            {
                superEffective.Add("fighting");
                superEffective.Add("poison");
            }

            if (type2 == "rock")
            {
                superEffective.Add("bug");
                superEffective.Add("fire");
                superEffective.Add("flying");
                superEffective.Add("ice");
            }

            if (type2 == "steel")
            {
                superEffective.Add("fairy");
                superEffective.Add("ice");
                superEffective.Add("rock");
            }

            if (type2 == "water")
            {
                superEffective.Add("fire");
                superEffective.Add("ground");
                superEffective.Add("rock");
            }

            return superEffective;

        }


        //set the pokemon.name field as the name entered in the main method
        //public string SetType(string name)




        //use an array find on the pokedex to get the enemy type1 and type2


    }
        
}

