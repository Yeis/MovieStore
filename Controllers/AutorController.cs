﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieStore.Bussiness;
using MovieStore.Models;
using MovieStore.Data;
namespace MovieStore.Controllers
{
    public class AutorController : Controller
    {
        AutorBLL Autor= new AutorBLL();
        Contexto context = new Contexto();
        // GET: /Autor/
        public ActionResult Index()
        {
            return View(Autor.GetAutores());
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
            return View();
        }

        //
        // POST: /Autor/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, AutorModel model)
        {
            try
            {
                // TODO: Add update logic here
                Autor.Editar(model);
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
            return View();
        }

        //
        // POST: /Autor/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
