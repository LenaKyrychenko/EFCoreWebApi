using ClassLibrary1.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary2
{
    public class ApplicationContext:IdentityDbContext<User>
    {
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<TypesOfTour> TypesOfTours { get; set; }
        public DbSet<TypesOfTransport> TypesOfTransports { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TourAgencyEF;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Reservation>()
                .HasOne(p => p.User)
                .WithMany(t => t.Reservations)
                .HasForeignKey(p => p.UserId);*/

            /*modelBuilder.Entity<Reservation>()
                .HasOne(p => p.Tour)
                .WithMany(t => t.Reservations)
                .HasForeignKey(p => p.TourId);

            modelBuilder.Entity<Tour>()
                .HasOne(p => p.TypesOfTour)
                .WithMany(t => t.Tours)
                .HasForeignKey(p => p.TypeOfTourId);

            modelBuilder.Entity<Tour>()
                .HasOne(p => p.TypesOfTransport)
                .WithMany(t => t.Tours)
                .HasForeignKey(p => p.TypeOfTransportId);*/
            base.OnModelCreating(modelBuilder);
        }
    }
}
