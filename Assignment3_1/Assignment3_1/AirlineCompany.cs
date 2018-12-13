using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_1
{
    class AirlineCompany
    {
        private readonly string companyName;
        private Flight[] flights = new Flight[4];
        
        public AirlineCompany()
        {
            String[] Company = new String[] { "Finnair", "Japan Airlines", "Qatar Airways" };
            Random random = new Random();
            int j = random.Next(0, 2);
            companyName = Company[j];
            this.flights[0] = new Flight(1020, "Helsinki", "Stockhom", "19.03.2010", 120);
            this.flights[1] = new Flight(241, "Tokyo", "Osaka", "23.11.2008", 45);
            this.flights[2] = new Flight(128, "Helsinki", "Doha", "05.12.2012", 640);
        }
        public Flight this[int index]
        {
            set
            {
                flights[index] = value;
            }
            get
            {
                return flights[index];
            }
        }

        public String ShowFlight(Flight flight)
        {
            return String.Format("Flight ID: " + flight.id + "| Flight's origin: " + flight.origin + "| Flight's destination: " + flight.destination + "| Flight's Date: "+ flight.date + "| Flight's price: "+ flight.price);
        }
        public String ShowFlightshort(Flight flight)
        {
            return String.Format("Flight's origin: " + flight.origin + "| Flight's destination: " + flight.destination);
        }

        public String ProcessCheapPrice(ProcessFlightDelegate processFlightDelegate, int price)
        {
            String content = "";
            foreach(Flight flight in flights)
            {
                if (flight.CheckPrice(price))
                {
                    content += processFlightDelegate(flight) + "\n";
                }
            }
            return content;
        }
    }
}
