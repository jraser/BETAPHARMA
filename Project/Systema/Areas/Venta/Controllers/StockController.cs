using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Systema.Areas.Venta.Controllers
{
    public class StockController : Controller{

        public ActionResult ListAdd()
        {
            return View();
        }
        public ActionResult AddStock()
        {
            return View();
        }
    }
}