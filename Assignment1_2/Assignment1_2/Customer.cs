using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_2
{
    class Customer
    {
        string name;
        int id, flightID;

        public Customer(string name, int id, int flightID)
        {
            this.name = name;
            this.id = id;
            this.flightID = flightID;
        }
        public int GetflightID()
        {
            return flightID;
        }
      
        public bool CustomerSearch(int id)
        {
            return (id == this.id);
        }

        public bool flightSearch(int flightID)
        {
            return (flightID == this.flightID);
        }

        public string CustomerInfo()
        {
            return ("Name: " + name + "\t\tID: " + id + "\t\tFlight ID: " + flightID);
        }

    }
}
