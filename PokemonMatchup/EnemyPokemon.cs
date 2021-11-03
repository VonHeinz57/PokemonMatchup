using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PokemonMatchup
{
    public class EnemyPokemon 
    {
        
        public static string GetEnemyType1(Pokemon[] pokedex, string enemy)
        {
            foreach (Pokemon enemyPokemon in pokedex)
            {
                if (enemyPokemon.Name.ToLower() == enemy)
                    return enemyPokemon.Type1;
            }
            return null;
        }

        public static string GetEnemyType2(Pokemon[] pokedex, string enemy)
        {
            foreach (Pokemon enemyPokemon in pokedex)
            {
                if (enemyPokemon.Name.ToLower() == enemy)
                    return enemyPokemon.Type2;
            }
            return null;
        }


        public static List<string> GetSuperEffective(string type1, string type2)
        {
            List<string> superEffective = new List<string>();

            if (type1 == "bug")
            {
                superEffective.Add("fire");
                superEffective.Add("flying");
                superEffective.Add("rock");
            }

            if (type1 == "dark")
            {
                superEffective.Add("bug");
                superEffective.Add("fairy");
                superEffective.Add("fighting");
            }

            if (type1 == "dragon")
            {
                superEffective.Add("dragon");
                superEffective.Add("fairy");
                superEffective.Add("ice");
            }

            if (type1 == "electric")
            {
                superEffective.Add("ground");
            }

            if (type1 == "fairy")
            {
                superEffective.Add("poison");
                superEffective.Add("steel");
            }

            if (type1 == "fighting")
            {
                superEffective.Add("fairy");
                superEffective.Add("flying");
                superEffective.Add("psychic");
            }

            if (type1 == "fire")
            {
                superEffective.Add("ground");
                superEffective.Add("rock");
                superEffective.Add("water");
            }

            if (type1 == "flying")
            {
                superEffective.Add("electric");
                superEffective.Add("ice");
                superEffective.Add("rock");
            }

            if (type1 == "ghost")
            {
                superEffective.Add("dark");
                superEffective.Add("ghost");
            }

            if (type1 == "grass")
            {
                superEffective.Add("bug");
                superEffective.Add("fire");
                superEffective.Add("flying");
                superEffective.Add("ice");
                superEffective.Add("poison");
            }

            if (type1 == "ground")
            {
                superEffective.Add("grass");
                superEffective.Add("ice");
                superEffective.Add("water");
            }

            if (type1 == "ice")
            {
                superEffective.Add("fighting");
                superEffective.Add("fire");
                superEffective.Add("rock");
                superEffective.Add("steel");
            }

            if (type1 == "normal")
            {
                superEffective.Add("fighting");
            }

            if (type1 == "poison")
            {
                superEffective.Add("ground");
                superEffective.Add("psychic");
            }

            if (type1 == "psychic")
            {
                superEffective.Add("bug");
                superEffective.Add("dark");
                superEffective.Add("ghost");
            }

            if (type1 == "rock")
            {
                superEffective.Add("fighting");
                superEffective.Add("grass");
                superEffective.Add("ground");
                superEffective.Add("steel");
                superEffective.Add("water");
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
                superEffective.Add("fighting");
            }

            if (type2 == "bug")
            {
                superEffective.Add("fire");
                superEffective.Add("flying");
                superEffective.Add("rock");
            }

            if (type2 == "dark")
            {
                superEffective.Add("bug");
                superEffective.Add("fairy");
                superEffective.Add("fighting");
            }

            if (type2 == "dragon")
            {
                superEffective.Add("dragon");
                superEffective.Add("fairy");
                superEffective.Add("ice");
            }

            if (type2 == "electric")
            {
                superEffective.Add("ground");
            }

            if (type2 == "fairy")
            {
                superEffective.Add("poison");
                superEffective.Add("steel");
            }

            if (type2 == "fighting")
            {
                superEffective.Add("fairy");
                superEffective.Add("flying");
                superEffective.Add("psychic");
            }

            if (type2 == "fire")
            {
                superEffective.Add("ground");
                superEffective.Add("rock");
                superEffective.Add("water");
            }

            if (type2 == "flying")
            {
                superEffective.Add("electric");
                superEffective.Add("ice");
                superEffective.Add("rock");
            }

            if (type2 == "ghost")
            {
                superEffective.Add("dark");
                superEffective.Add("ghost");
            }

            if (type2 == "grass")
            {
                superEffective.Add("bug");
                superEffective.Add("fire");
                superEffective.Add("flying");
                superEffective.Add("ice");
                superEffective.Add("poison");
            }

            if (type2 == "ground")
            {
                superEffective.Add("grass");
                superEffective.Add("ice");
                superEffective.Add("water");
            }

            if (type2 == "ice")
            {
                superEffective.Add("fighting");
                superEffective.Add("fire");
                superEffective.Add("rock");
                superEffective.Add("steel");
            }

            if (type2 == "normal")
            {
                superEffective.Add("fighting");
            }

            if (type2 == "poison")
            {
                superEffective.Add("ground");
                superEffective.Add("psychic");
            }

            if (type2 == "psychic")
            {
                superEffective.Add("bug");
                superEffective.Add("dark");
                superEffective.Add("ghost");
            }

            if (type2 == "rock")
            {
                superEffective.Add("fighting");
                superEffective.Add("grass");
                superEffective.Add("ground");
                superEffective.Add("steel");
                superEffective.Add("water");
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
                superEffective.Add("fighting");
            }

            List<string> distinctSupers = superEffective.Distinct().ToList();

            return distinctSupers;
        }

        public static List<string> GetNotVeryEffective(string type1, string type2)
        {
            List<string> notVeryEffective = new List<string>();

            if (type1 == "bug")
            {
                notVeryEffective.Add("grass");
                notVeryEffective.Add("dark");
                notVeryEffective.Add("psychic");
            }

            if (type1 == "dark")
            {
                notVeryEffective.Add("ghost");
                notVeryEffective.Add("psychic");
            }

            if (type1 == "dragon")
            {
                notVeryEffective.Add("dragon");
            }

            if (type1 == "electric")
            {
                notVeryEffective.Add("flying");
                notVeryEffective.Add("water");
            }

            if (type1 == "fairy")
            {
                notVeryEffective.Add("fighting");
                notVeryEffective.Add("dark");
                notVeryEffective.Add("dragon");
            }

            if (type1 == "fighting")
            {
                notVeryEffective.Add("dark");
                notVeryEffective.Add("ice");
                notVeryEffective.Add("normal");
                notVeryEffective.Add("rock");
                notVeryEffective.Add("steel");
            }

            if (type1 == "fire")
            {
                notVeryEffective.Add("bug");
                notVeryEffective.Add("grass");
                notVeryEffective.Add("ice");
                notVeryEffective.Add("steel");
            }

            if (type1 == "flying")
            {
                notVeryEffective.Add("bug");
                notVeryEffective.Add("fighting");
                notVeryEffective.Add("grass");
            }

            if (type1 == "ghost")
            {
                notVeryEffective.Add("ghost");
                notVeryEffective.Add("psychic");
            }

            if (type1 == "grass")
            {
                notVeryEffective.Add("ground");
                notVeryEffective.Add("rock");
                notVeryEffective.Add("water");
            }

            if (type1 == "ground")
            {
                notVeryEffective.Add("electric");
                notVeryEffective.Add("fire");
                notVeryEffective.Add("poison");
                notVeryEffective.Add("rock");
                notVeryEffective.Add("steel");
            }

            if (type1 == "ice")
            {
                notVeryEffective.Add("dragon");
                notVeryEffective.Add("flying");
                notVeryEffective.Add("grass");
                notVeryEffective.Add("ground");
            }

            if (type1 == "poison")
            {
                notVeryEffective.Add("fairy");
                notVeryEffective.Add("grass");
            }

            if (type1 == "psychic")
            {
                notVeryEffective.Add("fighting");
                notVeryEffective.Add("poison");
            }

            if (type1 == "rock")
            {
                notVeryEffective.Add("bug");
                notVeryEffective.Add("fire");
                notVeryEffective.Add("flying");
                notVeryEffective.Add("ice");
            }

            if (type1 == "steel")
            {
                notVeryEffective.Add("fairy");
                notVeryEffective.Add("ice");
                notVeryEffective.Add("rock");
            }

            if (type1 == "water")
            {
                notVeryEffective.Add("fire");
                notVeryEffective.Add("ground");
                notVeryEffective.Add("rock");
            }

            if (type2 == "bug")
            {
                notVeryEffective.Add("grass");
                notVeryEffective.Add("dark");
                notVeryEffective.Add("psychic");
            }

            if (type2 == "dark")
            {
                notVeryEffective.Add("ghost");
                notVeryEffective.Add("psychic");
            }

            if (type2 == "dragon")
            {
                notVeryEffective.Add("dragon");
            }

            if (type2 == "electric")
            {
                notVeryEffective.Add("flying");
                notVeryEffective.Add("water");
            }

            if (type2 == "fairy")
            {
                notVeryEffective.Add("fighting");
                notVeryEffective.Add("dark");
                notVeryEffective.Add("dragon");
            }

            if (type2 == "fighting")
            {
                notVeryEffective.Add("dark");
                notVeryEffective.Add("ice");
                notVeryEffective.Add("normal");
                notVeryEffective.Add("rock");
                notVeryEffective.Add("steel");
            }

            if (type2 == "fire")
            {
                notVeryEffective.Add("bug");
                notVeryEffective.Add("grass");
                notVeryEffective.Add("ice");
                notVeryEffective.Add("steel");
            }

            if (type2 == "flying")
            {
                notVeryEffective.Add("bug");
                notVeryEffective.Add("fighting");
                notVeryEffective.Add("grass");
            }

            if (type2 == "ghost")
            {
                notVeryEffective.Add("ghost");
                notVeryEffective.Add("psychic");
            }

            if (type2 == "grass")
            {
                notVeryEffective.Add("ground");
                notVeryEffective.Add("rock");
                notVeryEffective.Add("water");
            }

            if (type2 == "ground")
            {
                notVeryEffective.Add("electric");
                notVeryEffective.Add("fire");
                notVeryEffective.Add("poison");
                notVeryEffective.Add("rock");
                notVeryEffective.Add("steel");
            }

            if (type2 == "ice")
            {
                notVeryEffective.Add("dragon");
                notVeryEffective.Add("flying");
                notVeryEffective.Add("grass");
                notVeryEffective.Add("ground");
            }

            if (type2 == "poison")
            {
                notVeryEffective.Add("fairy");
                notVeryEffective.Add("grass");
            }

            if (type2 == "psychic")
            {
                notVeryEffective.Add("fighting");
                notVeryEffective.Add("poison");
            }

            if (type2 == "rock")
            {
                notVeryEffective.Add("bug");
                notVeryEffective.Add("fire");
                notVeryEffective.Add("flying");
                notVeryEffective.Add("ice");
            }

            if (type2 == "steel")
            {
                notVeryEffective.Add("fairy");
                notVeryEffective.Add("ice");
                notVeryEffective.Add("rock");
            }

            if (type2 == "water")
            {
                notVeryEffective.Add("fire");
                notVeryEffective.Add("ground");
                notVeryEffective.Add("rock");
            }

            List<string> distinctUnSupers = notVeryEffective.Distinct().ToList();

            return distinctUnSupers;

        }


        //set the pokemon.name field as the name entered in the main method
        //public string SetType(string name)




        //use an array find on the pokedex to get the enemy type1 and type2


    }
        
}

