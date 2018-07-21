using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RIK_HomeWork.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            YritusController yritusController = new YritusController();
            var yritused = yritusController.Get(null);
            ViewBag.Yritus = yritused;
            return View();
        }
    }
}
