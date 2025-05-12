using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineEntityFramework.Model
{
    internal class Passenger
    {
        public int PassengerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DOB { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
    }
}
