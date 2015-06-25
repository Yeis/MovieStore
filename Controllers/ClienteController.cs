using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieStorev1.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            return View(ClienteBLL.GetClientes());
        }
        //
        // GET: /Cliente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Cliente/Create
        [HttpPost]
        public ActionResult Create(ClienteModel cliente)
        {
            try
            {
                ClienteBLL.Agregar(cliente);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            ClienteModel genero = ClienteBLL.GetCliente(id);
            return View(genero);
        }

        //
        // POST: /Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ClienteModel cleinte)
        {
            try
            {
                ClienteBLL.Editar(id, cleinte);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            ClienteModel genero = ClienteBLL.GetCliente(id);
            return View(genero);
        }

        //
        // POST: /Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ClienteModel cliente)
        {
            try
            {
                ClienteBLL.Eliminar(id, cliente);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}