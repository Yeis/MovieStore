using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieStorev1.Controllers
{
    public class PeliculaController : Controller
    {
        // GET: Pelicula
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Peliculas/Peliculas_Genero
        public ActionResult Peliculas_Genero(GeneroModel genero) 
        {

            //Logica
            return View();
        }
        //
        // GET: /Peliculas/Peliculas_Autor
        public ActionResult Peliculas_Genero(AutorModel genero)
        {

            //Logica
            return View();
        }


        //
        // GET: /Pelicula/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Pelicula/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Pelicula/Create
        [HttpPost]
        public ActionResult Create(PeliculaModel pelicula)
        {
            try
            {
                PeliculaBLL.Agregar(pelicula);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Pelicula/Edit/5
        public ActionResult Edit(int id)
        {
            PeliculaModel genero = PeliculaBLL.GetPeliculas(id);
            return View(genero);
        }

        //
        // POST: /Pelicula/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, PeliculaModel pelicula)
        {
            try
            {
                PeliculaBLL.Editar(id, pelicula);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Pelicula/Delete/5
        public ActionResult Delete(int id)
        {
            PeliculaModel genero = PeliculaBLL.GetPeliculas(id);
            return View(genero);
        }

        //
        // POST: /Pelicula/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, PeliculaModel pelicula)
        {
            try
            {
                PeliculaBLL.Eliminar(id, pelicula);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}