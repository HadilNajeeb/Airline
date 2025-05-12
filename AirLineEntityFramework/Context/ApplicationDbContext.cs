using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirLineEntityFramework.Model;
using Microsoft.EntityFrameworkCore;

namespace AirLineEntityFramework.Context
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=.; Database=AirLine;Integrated Security = True;TrustServerCertificate = true");
        }
        public DbSet<AirPort> Airports { get; set; }
        public DbSet<AirLine> AirLines { get; set; }
        public DbSet<AirportOfficer> AirportOfficers { get; set; }
        public DbSet <Flight> Flights { get; set; }
        public DbSet<Gate> Gates { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Baggage> Baggages { get; set; }
        public DbSet<SecurityCheckpoint> SecurityCheckpoints { get; set; }
        public DbSet<Terminal> Terminals { get; set; }

    }
}
