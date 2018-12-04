using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_3
{
    class FirstClassPassenger : EconomyPassenger
    {
        String menu;
        private double bonus = 0.0;
        public double Bonus
        {
            get
            {
                return bonus;
            }
        }
        public FirstClassPassenger(int id, String firstName, String lastName, String phoneNum, int luggageWeight, String menu) : base(id, firstName, lastName, phoneNum, luggageWeight)
        {
            this.menu = menu;
        }
        public override void addTicket(Ticket ticket)
        {
            base.addTicket(ticket);
            bonus += ticket.getPrice(ticket.ticketID) * 0.02;
        }
        public override string getInfo(int id)
        {
            return base.getInfo(id) + "\n\nMenu:" + menu + "Bonus: " + this.Bonus;
        }
    }
}
