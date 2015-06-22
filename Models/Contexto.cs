using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieStore.Models
{
    public class Contexto : DbContext
    {
        public DbSet<AutorModel> Autores { get; set; }
        public DbSet<GeneroModel> Generos { get; set; }
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<PeliculaModel> Peliculas { get; set; }
        public DbSet<RentaModel> Rentas { get; set; }
        public DbSet<RentaPeliculaModel> RentaPeliculas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}