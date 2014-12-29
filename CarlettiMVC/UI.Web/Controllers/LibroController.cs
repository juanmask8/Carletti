using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Web.Models;
using Datos;
using Entidades;

namespace UI.Web.Controllers
{
    public class LibroController : Controller
    {
        //
        // GET: /Libro/

        public ActionResult Index()
        {
            var model = new LibrosModel
            {
                Libros = LibroRepository.GetAll()
            };
            return View(model);
        }

        public ActionResult Ver(int id)
        {
            Libro libroID = LibroRepository.GetLibroById(id);
            if (libroID != null)
            {
                var model = new DetalleModel
                {
                    libro = libroID
                };
                return View(model);
            }
            else
            {
                return Redirect("/Libro");
            }
        }


    }
}
