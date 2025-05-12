using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineEntityFramework.Model
{
    internal class AirportOfficer
    {
        public int AirportOfficerId { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  Position { get; set; }
        public string Department { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }

    }
}
