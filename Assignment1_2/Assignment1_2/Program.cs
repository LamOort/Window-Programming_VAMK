using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[7];
            Flight[] flights = new Flight[6];
            int storedID = 0;

            customers[0] = new Customer("Justin", 10, 1);
            customers[1] = new Customer("Josh", 57, 1);
            customers[2] = new Customer("Michael", 20, 2);
            customers[3] = new Customer("Trevor", 510, 3);
            customers[4] = new Customer("Mark", 512, 3);
            customers[5] = new Customer("Grim", 123, 2);

            flights[0] = new Flight(1, "Atlanta", "California", "29.12.2018");
            flights[1] = new Flight(2, "Vaasa", "Helsinki", "01.01.2018");
            flights[2] = new Flight(3, "Oulu", "Tampere", "12.08.2018");
            flights[3] = new Flight(4, "Helsinki", "Ho Chi Minh city", "07.10.2018");
            flights[4] = new Flight(5, "Tokyo", "Seoul", "20.04.2018");

            Console.Write("Please enter customer's name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter customer's ID: ");
            int id = Int16.Parse(Console.ReadLine());
            Console.Write("Please enter customer's flight ID: ");
            int flightID = Int16.Parse(Console.ReadLine());
            customers[6] = new Customer(name, id, flightID);


            Console.Write("Please enter new flight's ID: ");
            id = Int16.Parse(Console.ReadLine());
            Console.Write("Please enter new flight's origin: ");
            string origin = Console.ReadLine();
            Console.Write("Please enter new flight's destination: ");
            string destination = Console.ReadLine();
            Console.Write("Please enter new flight's date: ");
            string date = Console.ReadLine();

            flights[5] = new Flight(id, origin, destination, date);

            Console.Write("Customer ID search: ");
            int searchElement = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Result found: ");
            for (int i = 0; i < customers.Length; i++)
            {
                if (customers[i].CustomerSearch(searchElement))
                {
                    Console.WriteLine(customers[i].CustomerInfo());
                    storedID = customers[i].GetflightID();
                }
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("Searched Customer's related flight: ");

            for (int i = 0; i < flights.Length; i++)
            {
                Console.WriteLine(flights[i].flightSearch(storedID));
            }

            Console.Write("Flight ID search: ");
            searchElement= Int16.Parse(Console.ReadLine());
            Console.WriteLine("Flights found: ");
            for (int i = 0; i < flights.Length; i++)
            { 
                    Console.WriteLine(flights[i].flightSearch(id));
            }
            Console.WriteLine("Passengers on the flight: ");
            for(int i = 0; i < customers.Length; i++)
            {
                if (customers[i].flightSearch(searchElement))
                {
                    Console.WriteLine(customers[i].CustomerInfo());
                    Console.WriteLine();
                }
            }
            Console.ReadLine();

        }
         
    }
}
