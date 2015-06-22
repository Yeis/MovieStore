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
                bd.Clientes.Add(cliente);
                bd.SaveChanges();
            }
        }

        public static void Editar(ClienteModel cliente)
        {
            using (var bd = new Contexto())
            {
                bd.Clientes.Attach(cliente);
                bd.SaveChanges();
            }
        }

        public static void Eliminar(ClienteModel cliente)
        {
            using (var bd = new Contexto())
            {
                bd.Clientes.Remove(cliente);
                bd.SaveChanges();
            }
        }

        public static List<ClienteModel> GetClientes()
        {
            using (var bd = new Contexto())
            {
                return bd.Clientes.ToList();
            }
        }

        #endregion
    }
}