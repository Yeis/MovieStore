using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieStore.Data;

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

    public static void Editar(int id, AutorModel autor)
    {    
		using (var bd = new Contexto())
		{
			AutorModel a = bd.Autores.Find(id);
			a.Nombre = autor.Nombre;
            a.Apellidos = autor.Apellidos;
            a.FechaNacimiento = autor.FechaNacimiento;
			bd.SaveChanges();
		}           
    }

    public static void Eliminar(int id, AutorModel autor)
    {
        using (var bd = new Contexto())
        {
            AutorModel a = bd.Autores.Find(id);
            bd.Autores.Remove(a);
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

    public static AutorModel GetAutor(int id)
    {
        using (var bd = new Contexto())
        {
            return bd.Autores.Find(id);
        }
    }

    #endregion
}
