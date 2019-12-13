using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemApp_P113.Models
{
   public class TicketsDbContext : DbContext
    {
        public TicketsDbContext() : base("ticketDb") { }

        public DbSet<User> Users { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<Commentator> Commentators { get; set; }
    }
}
