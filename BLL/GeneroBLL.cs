using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieStore.Data;

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

    public static void Editar(int id, GeneroModel genero)
    {
        using (var bd = new Contexto())
        {
            GeneroModel g = bd.Generos.Find(id);
            g.Nombre = genero.Nombre;
            g.Descripcion = genero.Descripcion;
            bd.SaveChanges();
        }
    }

    public static void Eliminar(int id, GeneroModel genero)
    {
        using (var bd = new Contexto())
        {
            GeneroModel g = bd.Generos.Find(id);
            bd.Generos.Remove(g);
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

    public static GeneroModel GetGenero(int id)
    {
        using (var bd = new Contexto())
        {
            return bd.Generos.Find(id);
        }
    }

    #endregion
}
