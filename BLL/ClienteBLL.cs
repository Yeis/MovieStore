using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieStore.BLL
{
    public class ClienteBLL
    {
        #region Métodos

        public static void Agregar(ClienteModel cliente)
        {
            using (var bd = new Contexto())
            {
                bd.Cliente.Add(cliente);
                bd.SaveChanges();
            }
        }

        public static void Editar(ClienteModel cliente)
        {
            using (var bd = new Contexto())
            {
                bd.Cliente.Attach(cliente);
                bd.SaveChanges();
            }
        }

        public static void Eliminar(ClienteModel cliente)
        {
            using (var bd = new Contexto())
            {
                bd.Cliente.Remove(cliente);
                bd.SaveChanges();
            }
        }

        #endregion
    }
}