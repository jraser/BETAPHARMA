using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Systema.Areas.Venta.Controllers
{
    public class PrecioController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult ListAdd()
        {
            return View(); 
        }
	}
}