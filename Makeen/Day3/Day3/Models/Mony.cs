using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Models
{
    internal class Mony
    {
        public double amount { get; set; }
        public double shopping { get; set; }
        public Mony(double amount)
            
        {
            this.amount = amount;
        }
        public static Mony operator +(Mony a, Mony b)
        {
            double val = a.amount + b.amount;
            Mony m3 = new Mony(val);
            return m3;
        }


        public static Mony operator -(Mony a, Mony b)
        {
            double val = a.amount - b.amount;
            Mony m3 = new Mony(val);
            return m3;
        }


        public static bool operator < (Mony a, Mony b)
        {
            return a.amount < b.amount;
        }
        public static bool operator >(Mony a, Mony b)
        {
            return a.amount > b.amount;


        }
    }
}
