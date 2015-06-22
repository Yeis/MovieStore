using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieStore.BLL
{
    public class RentaBLL
    {
        #region Métodos

        public static void Agregar(RentaModel renta)
        {
            using (var bd = new Contexto())
            {
                bd.Renta.Add(renta);
                bd.SaveChanges();
            }
        }

        public static void Editar(RentaModel renta)
        {
            using (var bd = new Contexto())
            {
                bd.Renta.Attach(renta);
                bd.SaveChanges();
            }
        }

        public static void Eliminar(RentaModel renta)
        {
            using (var bd = new Contexto())
            {
                bd.Renta.Remove(renta);
                bd.SaveChanges();
            }
        }

        #endregion
    }
}