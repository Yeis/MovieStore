using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieStore.BLL
{
    public class GeneroBLL
    {
        #region Métodos

        public static void Agregar(GeneroModel genero)
        {
            using (var bd = new Contexto())
            {
                bd.Generos.Add(genero);
                bd.SaveChanges();
            }
        }

        public static void Editar(GeneroModel genero)
        {
            using (var bd = new Contexto())
            {
                bd.Generos.Attach(genero);
                bd.SaveChanges();
            }
        }

        public static void Eliminar(GeneroModel genero)
        {
            using (var bd = new Contexto())
            {
                bd.Generos.Remove(genero);
                bd.SaveChanges();
            }
        }

        public static List<GeneroModel> GetGeneros()
        {
            using (var bd = new Contexto())
            {
                return bd.Generos.ToList();
            }
        }

        #endregion
    }
}