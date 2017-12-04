using Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final.Controllers
{
    public class VentasController : Controller
    {
         private DbApplication dbContext = new DbApplication();
       
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetCostumers()
        {
            var products = dbContext.Cliente.ToList();

            return Json(products, JsonRequestBehavior.AllowGet);


        }

    }

    
}