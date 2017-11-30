using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HelloAPI.Models
{
    public class MontadoraContext : DbContext
    {
        public MontadoraContext() : base("Montadora")
        {
            Database.SetInitializer(new MontadoraDBInitializer());
        }

        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Marca> Marcas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}