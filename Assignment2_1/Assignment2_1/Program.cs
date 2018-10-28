using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Concert c1 = new Concert("Rock", "Helsinki", "28.04.2014", "8pm", 30);
            Concert c2 = new Concert("Opera", "Berlin", "09.11.2014", "6pm", 150);
            Hashtable concerts = new Hashtable();
            concerts.Add("Rock", c1);
            concerts.Add("Opera", c2);
            Console.WriteLine("List of concerts:");
            foreach (DictionaryEntry concert in concerts)
            {
                Console.WriteLine(concert.Key + " - " + concert.Value);
            }
            c1++;
            Console.WriteLine("Concert 1 after increment: " + c1);
            c2++;
            Console.WriteLine("Concert 2 after increment: " + c2);
            c1--;
            Console.WriteLine("Concert 1 after decrement: " + c1);
            c2--;
            Console.WriteLine("Concert 2 after decrement: " + c2);
            Console.WriteLine("Concert 1 's price < Concert 2 's price?\n" + (c1 < c2));
            Console.ReadLine();
        }
    }
}
