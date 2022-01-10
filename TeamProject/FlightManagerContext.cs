using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace TeamProject
{
    class FlightManagerContext : DbContext
    {
        public FlightManagerContext() : base("name=FlightManagerContext")
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }

       
    }
}
