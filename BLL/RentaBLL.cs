using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieStore.Data;

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

    public static void Editar(int id, RentaModel renta)
    {
        using (var bd = new Contexto())
        {
            RentaModel r = bd.Rentas.Find(id);
         //   r.Cliente = renta.Cliente;
            r.CostoTotal = renta.CostoTotal;
            r.FechaEntrega = renta.FechaEntrega;
            r.FechaRenta = renta.FechaRenta;
            r.Status = renta.Status;
            bd.SaveChanges();
        }
    }

    public static void Eliminar(int id, RentaModel renta)
    {
        using (var bd = new Contexto())
        {
            RentaModel r = bd.Rentas.Find(id);
            bd.Rentas.Remove(r);
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

    public static RentaModel GetRentas(int id)
    {
        using (var bd = new Contexto())
        {
            return bd.Rentas.Find(id);
        }
    }

    #endregion
}