using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieStorev1.Controllers
{
    public class GeneroController : Controller
    {
        // GET: /Genero/
        public ActionResult Index()
        {
            List<GeneroModel> lista = GeneroBLL.GetGeneros();
            return View(lista);
        }

        //
        // GET: /Genero/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Genero/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Genero/Create
        [HttpPost]
        public ActionResult Create(GeneroModel genero)
        {
            try
            {
                GeneroBLL.Agregar(genero);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Genero/Edit/5
        public ActionResult Edit(int id)
        {
            GeneroModel genero = GeneroBLL.GetGeneros(id); 
            return View(genero);
        }

        //
        // POST: /Genero/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, GeneroModel genero)
        {
            try
            {
                GeneroBLL.Editar(id, genero);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Genero/Delete/5
        public ActionResult Delete(int id)
        {
            GeneroModel genero = GeneroBLL.GetGeneros(id); 
            return View(genero);
        }

        //
        // POST: /Genero/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, GeneroModel genero)
        {
            try
            {
                GeneroBLL.Eliminar(id, genero);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}