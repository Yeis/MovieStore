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

        public static void Agregar(RentaPeliculaModel pr)
        {
            using (var bd = new Contexto())
            {
                bd.RentaPeliculas.Add(pr);
                bd.SaveChanges();
            }
        }

        public static void Editar(RentaPeliculaModel pr)
        {
            using (var bd = new Contexto())
            {
                bd.RentaPeliculas.Attach(pr);
                bd.SaveChanges();
            }
        }

        public static void Eliminar(RentaPeliculaModel pr)
        {
            using (var bd = new Contexto())
            {
                bd.RentaPeliculas.Remove(pr);
                bd.SaveChanges();
            }
        }

        public static List<RentaPeliculaModel> GetRentaPeliculas()
        {
            using (var bd = new Contexto())
            {
                return bd.RentaPeliculas.ToList();
            }
        }

        #endregion
    }
}