using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Flight[] flightList = new Flight[3];

            flightList[0] = new Flight(123, "NY", "LA", "24.1.2018");
            flightList[1] = new Flight(456, "HEL", "VAA", "16.04.2011");

            Passenger[] passengerList = new Passenger[3];

            passengerList[0] = new Passenger(1, "Uyen", "Thao", "0123456789");
            passengerList[1] = new EconomyPassenger(2, "Lam", "Nguyen", "0465711995", 60);
            passengerList[2] = new FirstClassPassenger(3, "Hirai", "Momo", "012947812", 45, "Sushi");

            Ticket[] ticketList = new Ticket[2];

            ticketList[0] = new Ticket();
            ticketList[0].addTicket(flightList[0], 1, 2, 500);

            ticketList[1] = new Ticket();
            ticketList[1].addTicket(flightList[1], 2, 3, 1000);

            passengerList[1].addTicket(ticketList[0]);
            passengerList[1].addTicket(ticketList[1]);

            passengerList[2].addTicket(ticketList[0]);
            passengerList[2].addTicket(ticketList[1]);

            int i;

            Console.Write("Please enter a flight's ID: ");
            int id = Convert.ToInt16(Console.ReadLine());
            for (i = 0; i < 2; i++)
            {
                Console.Write(flightList[i].FindFlight(id));
            }
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("Ticket ID: "+ ticketList[i].ticketID+  "'s details \n" );
                Console.Write(ticketList[i].getInfo(passengerList));
            }

            Console.Write("\n\nEnter passenger's ID: ");
            id = Convert.ToInt16(Console.ReadLine());
            for (i = 0; i < 3; i++)
            {
                Console.Write(passengerList[i].getInfo(id));
            }
            Console.ReadLine();
        }
    }
}
