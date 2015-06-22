using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieStore.Models
{
    public class PeliculaRentaModel
    {
        #region Propiedades

        public int PeliculaRentaId { get; set; }
        public PeliculaModel Pelicula { get; set; }
        public int? PeliculaId { get; set; }
        public RentaModel Renta { get; set; }
        public int? RentaId { get; set; }

        #endregion
    }
}