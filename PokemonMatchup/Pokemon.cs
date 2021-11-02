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

        public Pokemon (string csvData)
        {
            string[] data = csvData.Split(',');

            this.Number = Convert.ToInt32(data[0]);
            this.Name = data[1];
            this.Type1 = data[2];
            this.Type2 = data[3];

        }
    }
}
