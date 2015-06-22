using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieStore.BLL
{
    public class PeliculaBLL
    {
        #region Métodos

        public static void Agregar(PeliculaModel pm)
        {
            using (var bd = new Contexto())
            {
                bd.Pelicula.Add(pm);
                bd.SaveChanges();
            }
        }

        public static void Editar(PeliculaModel pm)
        {
            using (var bd = new Contexto())
            {
                bd.Pelicula.Attach(pm);
                bd.SaveChanges();
            }
        }

        public static void Eliminar(PeliculaModel pm)
        {
            using (var bd = new Contexto())
            {
                bd.Pelicula.Remove(pm);
                bd.SaveChanges();
            }
        }

        #endregion
    }
}