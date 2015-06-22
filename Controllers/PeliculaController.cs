using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieStore.Bussiness;

namespace MovieStore.Controllers
{
    public class PeliculaController : Controller
    {

        PeliculaBLL Pelicula_BLL = new PeliculaBLL();

        // GET: Pelicula
        public ActionResult Index()
        {

            return View(PeliculaBLL.GetPeliculas());
        }

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
            return View();
        }

        //
        // POST: /Pelicula/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, PeliculaModel pelicula)
        {
            try
            {
                // TODO: Add update logic here
                //Genero_BLL.Editar(Genero);
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
            return View();
        }

        //
        // POST: /Pelicula/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, PeliculaModel pelicula)
        {
            try
            {
                // TODO: Add Pelicula logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}