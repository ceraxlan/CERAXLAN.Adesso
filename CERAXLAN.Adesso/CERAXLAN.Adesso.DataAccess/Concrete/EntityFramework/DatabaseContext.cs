using CERAXLAN.Adesso.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.Adesso.DataAccess.Concrete.EntityFramework
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Travel> Travels { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Passenger> Passengers { get; set; }

        public static string ConnectionString { get; set; } = "User Id=ceraslan; Password=ceraxlan; Server=CERAXLAN; Database=ADESSO; Integrated Security=True; Connection Timeout=60;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Travel>().HasMany(c => c.Passengers).WithOne(e => e.Travel)
            //    .HasForeignKey(f=>f.TravelId).OnDelete(DeleteBehavior.Cascade);
            
        }

    }
}
