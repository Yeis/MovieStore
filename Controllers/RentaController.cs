using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieStore.Models;

namespace MovieStorev1.Controllers
{
    public class RentaController : Controller
    {
        // GET: Renta
        public ActionResult Index()
        {
            return View(RentaBLL.GetRentas());
        }

        //
        // GET: Agregar_Pelicula
        public ActionResult Agregar_Pelicula() 
        {
            //logica de agregar pelicula
            return View();
        }
        //
        // GET: Borrar_Pelicula
        public ActionResult Borrar_Pelicula()
        {
            //logica de borrar pelicula
            return View();
        }
        //
        // GET: Crear Renta
        public ActionResult Create(RentaModel renta)
        {
            try
            {
                if (RentaBLL.GetRentas()[RentaBLL.GetRentas().Count].Creada==true)
                {
                    //condicion y logica de creado
                    RentaBLL.Agregar(renta);
                }
                
                return RedirectToAction("Index");
                
            }
            catch (Exception)
            {

                return View();
            }
        }
        // GET: /Renta/Delete/5
        public ActionResult Delete(int id) { return View(); }
        //
        // POST: /Renta/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, RentaModel renta)
        {
            try
            {
                RentaBLL.Eliminar(id, renta);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}