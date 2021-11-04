using Microsoft.EntityFrameworkCore;

namespace Surfsup_API.Models
{
    public class SurfsupContext : DbContext
    {
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
        }

        public SurfsupContext(DbContextOptions<SurfsupContext> options) : base(options)
        {
        }

        //public DbSet<SurfsupContext> SurfsupItems { get; set; }
    }
}
