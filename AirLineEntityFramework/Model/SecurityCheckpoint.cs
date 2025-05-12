using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineEntityFramework.Model
{
    internal class SecurityCheckpoint
    {
        public int SecurityCheckpointID { get; set; }
        public int PassengerCapacity { get; set; }
        public string Location { get; set; }
        public string TerminalName { get; set; }


    }
}
