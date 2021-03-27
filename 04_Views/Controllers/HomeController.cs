using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _04_Views.Controllers
{
    public class HomeController : Controller
    {
        // GET: Ana Sayfa
        public ActionResult Homepage()
        {
            return View();
        }
        //Hakkımızda
        public ActionResult About()
        {
            return View();
        }
        //Iletisim
        public ActionResult Contact()
        {
            return View();
        }
    }
}