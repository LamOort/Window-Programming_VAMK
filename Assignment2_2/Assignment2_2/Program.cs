using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TextAnalyzer text = new TextAnalyzer();
            Dictionary<char, int> characters = new Dictionary<char, int>();
            string TextGenerate = text.getText();
            Console.WriteLine("Generated string: " + TextGenerate);

            foreach(char c in TextGenerate)
            {
                if (!characters.ContainsKey(c))
                    characters.Add(c, 1);
                characters[c] += 1;
            }

            Console.WriteLine("Characters counted: ");
            foreach(KeyValuePair<char, int> character in characters)
            {
                Console.WriteLine("Character: {0} \n Appearance times: {1} ", character.Key, character.Value);
            }
            Console.ReadLine();
        }
    }
}
