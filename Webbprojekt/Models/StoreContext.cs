using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Webbprojekt.Models
{
    public class StoreContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<StoreContext>(null);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Gallery> Galleries { get; set; }
    }
}