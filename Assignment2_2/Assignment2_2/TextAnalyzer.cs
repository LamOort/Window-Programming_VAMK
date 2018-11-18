using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_2
{
    public class TextAnalyzer
    {
        public string text;
        public TextAnalyzer()
        {
            Random random = new Random();
            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            this.text = new string(Enumerable.Repeat(characters, 50).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public SortedList<char, int> getCharactersList()
        {
            SortedList<char, int> charactersList = new SortedList<char, int>();
            foreach (char c in text)
            {
                if (charactersList.ContainsKey(c))
                {
                    charactersList[c]++;
                }
                else charactersList[c] = 1;
            }
            return charactersList;
        }
    }
}
        // need to use hashtable and from i = 1; i < 50, pick random an element in hashtable, then use it for this.text in constructor