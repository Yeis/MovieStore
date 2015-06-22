using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieStore.Models
{
    public class PeliculaModel
    {
        #region Propiedades

        public int Id { get; set; }
        public int Nombre { get; set; }
        public int Rating { get; set; }
        public double Precio { get; set; }
        public int DiasRenta { get; set; }
        public AutorModel Autor { get; set; }
        public int? AutorId { get; set; }
        public GeneroModel Genero { get; set; }
        public int? GeneroId { get; set; }

        #endregion
    }
}