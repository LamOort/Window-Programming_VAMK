using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_1
{
    public delegate String ProcessFlightDelegate(Flight flight);
    class Program
    {
        
        static void Main(string[] args)
        {
            AirlineCompany airlineCompany = new AirlineCompany();
            airlineCompany[3] = new Flight(1229, "Seoul", "Jakarta", "20.05.2019", 792);

            for (int i=0; i<4; i++)
            {
                Console.WriteLine(airlineCompany[i].ToString());
            }

            Console.Write("Please enter a flight ID: ");
            int input = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Found Result: ");
            for(int k=0; k < 4; k++)
            {
                Console.WriteLine(airlineCompany[k].FindFlight(input));
            }
            Console.WriteLine("Please enter your budget: ");
            int price = Convert.ToInt16(Console.ReadLine());

            ProcessFlightDelegate pfd = new ProcessFlightDelegate(airlineCompany.ShowFlight);
            ProcessFlightDelegate pfd2 = new ProcessFlightDelegate(airlineCompany.ShowFlightshort);
            ProcessFlightDelegate pfd3 = pfd + pfd2;

            Console.WriteLine(airlineCompany.ProcessCheapPrice(pfd3, price));

            Console.ReadLine();
        }
    }
}
