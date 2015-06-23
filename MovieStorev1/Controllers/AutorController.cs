using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieStorev1.Controllers
{
    public class AutorController : Controller
    {
        //
        // GET: /Autor/
        public ActionResult Index()
        {
            List<AutorModel> lista = AutorBLL.GetAutores();
            return View(lista);
        }

        //
        // GET: /Autor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Autor/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Autor/Create
        [HttpPost]
        public ActionResult Create(AutorModel autor)
        {
            try
            {
                AutorBLL.Agregar(autor);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Autor/Edit/5
        public ActionResult Edit(int id)
        {
            AutorModel autor = AutorBLL.GetAutor(id);
            return View(autor);
        }

        //
        // POST: /Autor/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, AutorModel autor)
        {
            try
            {
                AutorBLL.Editar(id, autor);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Autor/Delete/5
        public ActionResult Delete(int id)
        {
            AutorModel autor = AutorBLL.GetAutor(id);
            return View(autor);
        }

        //
        // POST: /Autor/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, AutorModel autor)
        {
            try
            {
                AutorBLL.Eliminar(id, autor);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
