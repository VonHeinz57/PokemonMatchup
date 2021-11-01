using System;

namespace PokemonMatchup
{
    public class Pokemon
    {
        internal static string name;

        public int Number { get; set; }
        public string Name { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }

        public Pokemon (int number, string name, string type1, string type2)
        {
            this.Number = number;
            this.Name = name;
            this.Type1 = type1;
            this.Type2 = type2;
        }       
    }
}
