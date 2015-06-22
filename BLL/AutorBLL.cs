using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieStore.BLL
{
    public class AutorBLL
    {
        #region Métodos

        public static void Agregar(AutorModel autor)
        {
            using (var bd = new Contexto())
            {
                bd.Autores.Add(autor);
                bd.SaveChanges();
            }
        }

        public static void Editar(AutorModel autor)
        {
            using (var bd = new Contexto())
            {
                bd.Autores.Attach(autor);
                bd.SaveChanges();
            }
        }

        public static void Eliminar(AutorModel autor)
        {
            using (var bd = new Contexto())
            {
                bd.Autores.Remove(autor);
                bd.SaveChanges();
            }
        }

        public static List<AutorModel> GetAutores()
        {
            using (var bd = new Contexto())
            {
                return bd.Autores.ToList();
            }
        }

        #endregion
    }
}