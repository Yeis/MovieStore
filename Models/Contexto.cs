using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MovieStore.Models;

namespace MovieStore.Data
{
    public class Contexto : DbContext
    {

        public DbSet<AutorModel> Autores { get; set; }
        public DbSet<GeneroModel> Generos { get; set; }
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<PeliculaModel> Peliculas { get; set; }
        public DbSet<RentaModel> Rentas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<RentaModel>()
                .HasRequired(r => r.RentaDetalle);

            base.OnModelCreating(modelBuilder);
        }
    }
}