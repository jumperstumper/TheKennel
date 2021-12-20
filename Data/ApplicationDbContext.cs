using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KennelProgram.Models;
using Microsoft.EntityFrameworkCore;

namespace KennelProgram.Data
{
   public class ApplicationDbContext : DbContext
    {
        private const string connectionString = "Server=;Database=Kennel;Trusted_Connection=True;MultipleActiveResultSets=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Services> Services { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            ////Many to Many Customer and Dog
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<CustomerDog>().HasKey(ba => new { ba.DogId, ba.CustomerId });

            //modelBuilder.Entity<CustomerDog>().HasOne(b => b.Dog).WithMany(b => b.CustomerDogs).HasForeignKey(b => b.DogId);
            //modelBuilder.Entity<CustomerDog>().HasOne(b => b.Customer).WithMany(b => b.CustomerDogs).HasForeignKey(b => b.CustomerId);

        }

    }
}

