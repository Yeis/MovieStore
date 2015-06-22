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
                bd.Peliculas.Add(pm);
                bd.SaveChanges();
            }
        }

        public static void Editar(PeliculaModel pm)
        {
            using (var bd = new Contexto())
            {
                bd.Peliculas.Attach(pm);
                bd.SaveChanges();
            }
        }

        public static void Eliminar(PeliculaModel pm)
        {
            using (var bd = new Contexto())
            {
                bd.Peliculas.Remove(pm);
                bd.SaveChanges();
            }
        }

        public static List<PeliculaModel> GetPeliculas()
        {
            using (var bd = new Contexto())
            {
                return bd.Peliculas.ToList();
            }
        }

        #endregion
    }
}