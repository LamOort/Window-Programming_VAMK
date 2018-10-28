using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_1
{
    class Concert
    {
        string title, location, date, time;
        int price;
        public Concert(string title, string location, string date, string time, int price)
        {
            this.title = title;
            this.location = location;
            this.date = date;
            this.time = time;
            this.price = price;
        }
        public override string ToString()
        {
            return title + " " + location + " " + date + " " + time + " " + price + "\n"; 
        }

        public static bool operator <(Concert c1, Concert c2)
        {
            if (c1.price < c2.price)
                return true;
            return false;
        }
        public static bool operator >(Concert c1, Concert c2)
        {
            if (c1.price > c2.price)
                return true;
            return false;
        }
        public static Concert operator ++ (Concert Obj)
        {
            return new Concert(Obj.title, Obj.location, Obj.date, Obj.time, Obj.price + 5);
        }
        public static Concert operator -- (Concert Obj)
        {
            return new Concert(Obj.title, Obj.location, Obj.date, Obj.time, Obj.price - 5);
        }
    }
}
