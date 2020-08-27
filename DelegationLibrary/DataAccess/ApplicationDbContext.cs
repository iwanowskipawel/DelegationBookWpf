using DelegationLibrary.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationLibrary.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<IAddress> Addresses { get; set; }
        public DbSet<IBusinessTrip> BusinessTrips { get; set; }
        public DbSet<ICar> Cars { get; set; }
        public DbSet<ICompany> Companies { get; set; }
        public DbSet<IDestination> Destinations { get; set; }
        public DbSet<IDriver> Drivers { get; set; }
        public DbSet<IEmployee> Employees { get; set; }
        public DbSet<IKilometersCard> KilometersCards { get; set; }
        public DbSet<IProject> Projects { get; set; }
    }
}
