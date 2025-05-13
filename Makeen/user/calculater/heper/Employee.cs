using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculater.heper
{
    internal class Employee
    {
        public Employee(int id, string name, double wage, string loggedhours, string position)
        {
            Id = id;
            this.name = name;
            this.wage = wage;
            this.loggedhours = loggedhours;
            this.position = position;
        }

        public int Id { get; set; }
        public string name { get; set; }
        public double wage { get; set; }
        public string loggedhours { get; set; }
        public string position { get; set; }

    }
    
}
