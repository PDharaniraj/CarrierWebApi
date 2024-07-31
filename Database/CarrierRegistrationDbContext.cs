using CarrierWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CarrierWebApi.Database
{
    public class CarrierRegistrationDbContext(DbContextOptions options) : DbContext(options)
    {


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("CarrierReg");
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<VesselRegistration> VesselRegistration { get; set; }
        public DbSet<ShipOwnerDetails> ShipOwnerDetails { get; set; }
        public DbSet<CharterersDetails> CharterersDetails { get; set; }
        public DbSet<Certificates> Certificates { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<States> States { get; set; }
        public DbSet<UserLogin> UserLogin { get; set; }

    }
}
