using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieStore.Models
{
    public class RentaModel
    {
        #region Propiedades

        public int Id { get; set; }
        public DateTime FechaRenta { get; set; }
        public DateTime FechaEntrega { get; set; }
        public double CostoTotal { get; set; }
        public ClienteModel Cliente { get; set; }
        public PeliculaModel Pelicula{ get; set; }         
        public int? ClienteId { get; set; }
        public string Status { get; set; }
        public bool Creada { get; set; }

        #endregion
    }
}