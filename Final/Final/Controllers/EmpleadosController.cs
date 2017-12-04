using Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final.Controllers
{
    public class EmpleadosController : Controller
    {
        // GET: Empleados
        public ActionResult Index()
        {
            return View();
        }

        DbApplication _context = new DbApplication();
        

        [HttpPost]
        public string AgregarEmpleados(Empleados Empleado)
        {
            string mgs = null;
            if (ModelState.IsValid)
            {
                _context.Empleado.Add(Empleado);
                _context.SaveChanges();
                return mgs = "registro Completado";
            }

            return mgs;
        }

    }
}