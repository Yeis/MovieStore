using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieStore.Data;

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

    public static void Editar(int id, ClienteModel cliente)
    {
        using (var bd = new Contexto())
        {
            ClienteModel c = bd.Clientes.Find(id);
            c.Nombre = cliente.Nombre;
            c.Apellidos = cliente.Apellidos;
            c.FechaNacimiento = cliente.FechaNacimiento;
            c.CorreoElectronico = cliente.CorreoElectronico;
            c.Telefono = cliente.Telefono;
            bd.SaveChanges();
        }
    }

    public static void Eliminar(int id, ClienteModel cliente)
    {
        using (var bd = new Contexto())
        {
            ClienteModel c = bd.Clientes.Find(id);
            bd.Clientes.Remove(c);
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

    public static ClienteModel GetCliente(int id)
    {
        using (var bd = new Contexto())
        {
            return bd.Clientes.Find(id);
        }
    }

    #endregion
}
