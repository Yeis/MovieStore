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
        public string Nombre { get; set; }
        public double Rating { get; set; }
        public double Precio { get; set; }
        public int DiasRenta { get; set; }
        public int AutorId { get; set; }
        public virtual AutorModel Autor { get; set; }
        public int GeneroId { get; set; }
        public virtual GeneroModel Genero { get; set; }



        //public virtual RentaDetalleModelo RentaDetalle { get; set; }

        #endregion
    }
}