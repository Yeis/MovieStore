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
        public ActionResult Index(int? Selected)
        {
            var db = new MovieStore.Data.Contexto();
            var autores = db.Autores.OrderBy(q => q.Nombre).ToList();
            ViewBag.SelectedDepartment = new SelectList(autores, "Id", "Nombre", Selected);
            int autorID = Selected.GetValueOrDefault();

            IQueryable<PeliculaModel> peliculas = db.Peliculas
                .Where(c => !Selected.HasValue || c.AutorId == autorID)
                .OrderBy(d => d.Id);

            var sql = peliculas.ToString();

            return View(peliculas);
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
            AutorDropDownList();
            GeneroDropDownList();
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
            PeliculaModel p = PeliculaBLL.GetPeliculas(id);
            AutorDropDownList(p.AutorId);
            GeneroDropDownList(p.GeneroId);
            return View(p);
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
            PeliculaModel pelicula = PeliculaBLL.GetPeliculas(id);
            return View(pelicula);
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

        private void AutorDropDownList(object selected = null)
        {
            var db = new MovieStore.Data.Contexto();

            var query = from d in db.Autores
                        orderby d.Nombre
                        select d;
            
            ViewData["AutorId"] = new SelectList(query, "Id", "Nombre", selected);
        }

        private void GeneroDropDownList(object selected = null)
        {
            var db = new MovieStore.Data.Contexto();

            var query = from d in db.Generos
                        orderby d.Nombre
                        select d;
            ViewBag.GeneroId = new SelectList(query, "Id", "Nombre", selected);
        }
    }
}