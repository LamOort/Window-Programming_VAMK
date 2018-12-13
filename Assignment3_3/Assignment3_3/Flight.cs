using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_3
{
    public class Flight
    {
        public int id, price;
        public String origin, destination, date;

        public Flight(int id, String origin, String destination, String date)
        {
            this.id = id;
            this.origin = origin;
            this.destination = destination;
            this.date = date;
        }
        public String FindFlight(int id)
        {
            if (this.id == id)
            {
                return this.toString();
            }
            else return null;
        }
        public String toString()
        {
            return ("Flight ID: " + id + "| Flight's orgin: " + origin + "| Flight's destination: " + destination + "| Flight's date: " + date +"| Flight's price: "+ price);
        }
    }
}
