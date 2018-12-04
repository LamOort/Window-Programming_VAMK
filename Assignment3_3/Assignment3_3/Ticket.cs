using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment3_3
{
    class Ticket
    {
        Flight flight;
        public int ticketID, passengerID;
        double price;
        private static readonly double tax;
        static DateTime date;

        static Ticket()
        {
            if ((date.DayOfWeek == DayOfWeek.Saturday) || (date.DayOfWeek == DayOfWeek.Sunday))
            {
                tax = 0.07;
            }
            else
            {
                tax = 0.05;
            }
        }
        public void addTicket(Flight flight, int ticketID, int passengerID, double price)
        {
            this.flight = flight;
            this.ticketID = ticketID;
            this.passengerID = passengerID;
            this.price = price;
        }

        public double getPrice(int id)
        {
            if (id == ticketID)
                return price + (price * tax);
            else return 0.0;   
        }
        public String getInfo(Passenger[] passengers)
        {
            String ticketInfo = "Ticket info: \n" + this.toString() + "Passenger info: \n";
            foreach (Passenger passenger in passengers)
            {
                if (passenger.id == this.passengerID)
                {
                    ticketInfo += passenger.getInfo(passengerID);
                }
            }
            return ticketInfo;
        }
        public String toString()
        {
            return "Flight: " + flight.toString() + "| Ticket ID: " + ticketID + "| Passenger ID: " + passengerID + "| Price: " + this.getPrice(this.ticketID) + "\n";
        }
    }
}
