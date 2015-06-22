using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieStore.Models
{
    public class Contexto : DbContext
    {
        public DbSet<AutorModel> Autor { get; set; }
        public DbSet<GeneroModel> Genero { get; set; }
        public DbSet<ClienteModel> Cliente { get; set; }
        public DbSet<PeliculaModel> Pelicula { get; set; }
        public DbSet<RentaModel> Renta { get; set; }
        public DbSet<PeliculaRentaModel> PeliculaRenta { get; set; }
    }
}