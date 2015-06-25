using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieStore.Data;

public class PeliculaBLL
{

    #region Métodos

    public static void Agregar(PeliculaModel pm)
    {
        using (var bd = new Contexto())
        {
            bd.Peliculas.Add(pm);
            bd.SaveChanges();
        }
    }

    public static void Editar(int id, PeliculaModel pelicula)
    {
        using (var bd = new Contexto())
        {
            PeliculaModel p = bd.Peliculas.Find(id);
            p.Nombre = pelicula.Nombre;
            p.Precio = pelicula.Precio;
            p.Genero = pelicula.Genero;
            p.Rating = pelicula.Rating;
            p.DiasRenta = pelicula.DiasRenta;
            p.Autor = pelicula.Autor;
            bd.SaveChanges();
        }
    }

    public static void Eliminar(int id, PeliculaModel pm)
    {
        using (var bd = new Contexto())
        {
            PeliculaModel p = bd.Peliculas.Find(id);
            bd.Peliculas.Remove(p);
            bd.SaveChanges();
        }
    }

    public static List<PeliculaModel> GetPeliculas()
    {
        using (var bd = new Contexto())
        {
            return bd.Peliculas.ToList();
        }
    }
    public static PeliculaModel GetPeliculas(int id)
    {
        using (var bd = new Contexto())
        {
            return bd.Peliculas.Find(id);
        }
    }

    #endregion
}