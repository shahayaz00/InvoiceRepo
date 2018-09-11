using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InvoiceRep.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult AboutMe()
        {
            ViewBag.Title = "Shah Ayaz";

            return View();
        }

        public ActionResult AboutMe1()
        {
            ViewBag.Title = "Rukhsar";

            return View();
        }
    }
}
