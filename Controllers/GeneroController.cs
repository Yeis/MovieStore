using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieStore.Bussiness;
namespace MovieStore.Controllers
{
    public class GeneroController : Controller
    {
        // GET: Genero
        GeneroBLL Genero_BLL = new GeneroBLL();
        public ActionResult Index()
        {
            return View(GeneroBLL.GetGeneros());
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
            return View();
        }

        //
        // POST: /Genero/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, GeneroModel Genero)
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
        // GET: /Genero/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Genero/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, GeneroModel Genero)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}