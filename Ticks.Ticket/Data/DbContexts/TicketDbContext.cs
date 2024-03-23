using Microsoft.EntityFrameworkCore;
using Ticks.Tickets.Entities;

namespace Ticks.Tickets.Data.DbContexts
{
    public class TicketDbContext : DbContext
    {
        public TicketDbContext(DbContextOptions<TicketDbContext> options) : base(options)
        {

        }

        public DbSet<Ticket> Ticket { get; set; }
    }
}

