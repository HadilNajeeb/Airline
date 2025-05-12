using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineEntityFramework.Model
{
    internal class Flight
    {
        public int FlightId { get; set; }
        public string DepartmentCity { get; set; } 
        public string DestinationCity { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string FlightStatus { get; set; }
        public int GateNumber { get; set; }

    }
}
