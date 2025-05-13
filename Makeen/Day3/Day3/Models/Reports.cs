using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Models
{
    internal class Reports
    {
        public delegate bool Salescondition(Employee emp);
        public void processSales(Employee[]emp, string title , Salescondition cond )
        {
            Console.WriteLine("welcome to sales:");
            Console.WriteLine(title);
            foreach (var e in emp)
            {
                if (cond(e))
                {
                    Console.WriteLine($"{e.Name}has total :{e.Totalsalse}");
                }
            }
        }

        public void Totalsalesmorethan60(Employee[] emps)
        {
            Console.WriteLine("welcome to report generator  ");
            Console.WriteLine("\t\t\t total salse more than 60k   ");
            foreach (var e in emps)
            {
                if (e.Totalsalse >= 60000)
                {
                    Console.WriteLine($"{e.Name} has total salse with : {e.Totalsalse} ");
                    
                }
            }
        }



        public void Totalsalesmorethan30(Employee[] emps)
        {
            Console.WriteLine("welcome to report generator  ");
            Console.WriteLine("\t\t\t total salse more than 30k   ");
            foreach (var e in emps)
            {
                if (e.Totalsalse >= 30000)
                {
                    Console.WriteLine($"{e.Name} has total salse with : {e.Totalsalse} ");

                }
            }
        }


        public void Totalsaleslesthan30(Employee[] emps)
        {
            Console.WriteLine("welcome to report generator  ");
            Console.WriteLine("\t\t\t total salse more than 30k   ");
            foreach (var e in emps)
            {
                if (e.Totalsalse < 30000)
                {
                    Console.WriteLine($"{e.Name} has total salse with : {e.Totalsalse} ");

                }
            }
        }
    }

}
