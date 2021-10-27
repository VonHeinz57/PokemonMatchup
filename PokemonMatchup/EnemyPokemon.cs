using System;
using System.IO;

namespace PokemonMatchup
{
    public class EnemyPokemon : Pokemon
    {

        public EnemyPokemon(string enemyName)
        {
            name = enemyName;
        }

        public string getType1()
        {
            var linesOfCsv = File.ReadAllLines("/users/loganheinz/projects/pokemonmatchup/pokemonmatchup/pokemon.csv");

            foreach (var pokemon in linesOfCsv)
            {
                int comma1 = pokemon.IndexOf(',');//1
                int comma2 = pokemon.IndexOf(',', comma1+1);//10
                int comma3 = pokemon.IndexOf(',', comma2+1);

                if (pokemon.Substring(comma1+1, comma2-1) == name)
                {
                    type1 = pokemon;//pokemon.Substring(comma2, comma3-comma2);
                }
                break;
            }
            return type1;
            
        }
    }
}
