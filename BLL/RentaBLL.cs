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
                bd.Rentas.Add(renta);
                bd.SaveChanges();
            }
        }

        public static void Editar(RentaModel renta)
        {
            using (var bd = new Contexto())
            {
                bd.Rentas.Attach(renta);
                bd.SaveChanges();
            }
        }

        public static void Eliminar(RentaModel renta)
        {
            using (var bd = new Contexto())
            {
                bd.Rentas.Remove(renta);
                bd.SaveChanges();
            }
        }

        public static List<RentaModel> GetRentas()
        {
            using (var bd = new Contexto())
            {
                return bd.Rentas.ToList();
            }
        }

        #endregion
    }
}