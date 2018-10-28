using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_2
{
    class Flight
    {
        int id;
        string origin, destination, date;

        public Flight(int id, string origin, string destination, string date)
        {
            this.id = id;
            this.origin = origin;
            this.destination = destination;
            this.date = date;
        }

        public string flightSearch(int id)
        {
            if (this.id == id)
            {
                return ("Flight ID: " + id + "\t\tOrigin: " + origin + "\t\tDestination: " + destination + "\t\tDate: " + date);
            }
            else return ("");
        }
    }
}
