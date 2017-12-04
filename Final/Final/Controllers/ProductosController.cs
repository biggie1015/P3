using Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final.Controllers
{
    public class ProductosController : Controller
    {

        DbApplication _context = new DbApplication();

        // GET: Productos
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string AgregarProductos(Productos producto)

        {
            string mgs = null;
            if (ModelState.IsValid)
            {
                _context.Producto.Add(producto);
                _context.SaveChanges();
                return mgs = "registro Completado";
            }

            return mgs;
        }

[HttpGet]
public JsonResult GetProducts()
{
    var products = _context.Producto.ToList();

    return Json(products, JsonRequestBehavior.AllowGet);
}

    }
}