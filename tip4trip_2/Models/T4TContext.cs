using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace tip4trip_2.Models
{
    public class T4TContext : DbContext
    {
        const string connectionString = @"Data Source=MUNTAN-PC\SQLEXPRESS;Initial Catalog=T4Trip;Integrated Security=True";
        public T4TContext() : base(connectionString){}

        public DbSet<House> Houses { get; set; }

        public DbSet<Location> Locations { get; set; }


    }
}