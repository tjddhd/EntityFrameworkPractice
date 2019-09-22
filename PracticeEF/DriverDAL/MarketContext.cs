using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PracticeEF.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PracticeEF.DriverDAL
{
    public class MarketContext : DbContext
    {
        public MarketContext() : base("MarketContext")
        {

        }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}