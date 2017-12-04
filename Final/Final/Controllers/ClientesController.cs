using Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            return View();
        }

        DbApplication _context = new DbApplication();
        // GET: Clientes

        [HttpPost]
        public string AgregarClientes(Clientes cliente)
        {
            string mgs = null;
            if (ModelState.IsValid)
            {
                _context.Cliente.Add(cliente);
                _context.SaveChanges();
                return mgs = "registro Completado";
            }

            return mgs;

        }
    }
}