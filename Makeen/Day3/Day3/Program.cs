using Day3.Models;

namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Employee[] employee =
             {
                 new Employee(1, "hadeel", "famale", 6000),
                 new Employee(2, "noor", "famale", 3000),
                 new Employee(2, "aisha", "famale", 5000)

             };
             Reports reports = new Reports();
             // reports.Totalsaleslesthan30(emp);
             // reports.Totalsalesmorethan30(emp);
             // reports.Totalsalesmorethan60(emp);
            // 
             bool Salesmorethan30(Employee emp) => emp.Totalsalse >= 3000;
             bool Salesmorethan60(Employee emp) => emp.Totalsalse >= 6000;
             reports.processSales(employee, "total sales more than 30", Salesmorethan30); */

            Mony m1 = new Mony(5);
            Mony m2 = new Mony(8);
            Mony m3 = m1 + m2;
            Console.WriteLine(m3.amount);


            Mony h1 = new Mony(5);
            Mony h2 = new Mony(8);
            var h3 = m1 < m2;
            Console.WriteLine(h3);

        }
    }
}
