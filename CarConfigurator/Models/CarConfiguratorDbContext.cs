using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CarConfigurator.Models
{
    // The database context used by this application.
    public class CarConfiguratorDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Paint> Paints { get; set; }
        public DbSet<Rims> Rims { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<CarConfiguration> CarConfigurations { get; set; }
    }
}