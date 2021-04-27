using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstDatabaseCodeFirstMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Website E-Commerce";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Kontak Kami";

            return View();
        }
    }
}