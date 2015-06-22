using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieStore.BLL
{
    public class PeliculaRentaBLL
    {
        #region Métodos

        public static void Agregar(PeliculaRentaModel pr)
        {
            using (var bd = new Contexto())
            {
                bd.PeliculaRenta.Add(pr);
                bd.SaveChanges();
            }
        }

        public static void Editar(PeliculaRentaModel pr)
        {
            using (var bd = new Contexto())
            {
                bd.PeliculaRenta.Attach(pr);
                bd.SaveChanges();
            }
        }

        public static void Eliminar(PeliculaRentaModel pr)
        {
            using (var bd = new Contexto())
            {
                bd.PeliculaRenta.Remove(pr);
                bd.SaveChanges();
            }
        }

        #endregion
    }
}