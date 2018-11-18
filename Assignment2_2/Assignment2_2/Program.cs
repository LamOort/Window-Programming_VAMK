using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TextAnalyzer t = new TextAnalyzer();
            Console.WriteLine("Generated characters:");
            Console.WriteLine(t.text);
            SortedList<char, int> charactersList = t.getCharactersList();
            
            foreach(char c in charactersList.Keys)
            {
                Console.WriteLine( "Character " + c + " appears: " + charactersList[c] + " times");
            }
            Console.ReadLine();
        }
    }
}
