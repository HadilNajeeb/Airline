using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Models
{
    internal class Employee 
    {
        public Employee(int id, string name, string gender, double totalsalse)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Totalsalse = totalsalse;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Totalsalse { get; set; }


    }
}
