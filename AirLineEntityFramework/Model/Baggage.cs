using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineEntityFramework.Model
{
    internal class Baggage
    {
        public int BaggageId { get; set; } 
        public int Weight { get; set; }
        public int TrackingNumber { get; set; }
    }
}
