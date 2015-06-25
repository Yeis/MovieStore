using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieStore.Models;

namespace MovieStore.Models
{
    public class RentaDetalleModelo
    {
        public int Id { get; set; }
        public RentaModel RentaFK { get; set; }
        public PeliculaModel PeliculaFK { get; set; }


    }
}