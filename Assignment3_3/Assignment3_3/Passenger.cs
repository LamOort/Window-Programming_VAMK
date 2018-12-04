using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment3_3
{
    class Passenger
    {
        public int id;
        String firstName, lastName, phoneNum;
        ArrayList ticketList = new ArrayList();

        public Passenger(int id, String firstName, String lastName, String phoneNum)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNum = phoneNum;
        }

        public virtual void addTicket(Ticket ticket)
        {
            this.ticketList.Add(ticket);
        }
        public virtual String getInfo(int id)
        {
            if (this.id == id)
            {
                String tickets = "Tickets: \n";
                foreach (Ticket ticket in ticketList)
                {
                    tickets += ticket.toString();
                }
                return this.toString() + tickets;
            }
            else return null;
        }
        public String toString()
        {
            return ("Passenger's ID: " + id + "| First Name: " + firstName + "| Last Name: " + lastName + "| Phone Number:" + phoneNum +"\n");
        }
    }
}
