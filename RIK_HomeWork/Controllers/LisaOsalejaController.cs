using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RIK_HomeWork.Controllers
{
    public class LisaOsalejaController : Controller
    {
        // GET: LisaOsaleja
        //public ActionResult Index()
        //{
        //    return View("~/Views/Home");
        //}

        // GET: LisaOsaleja/Index/5
        public ActionResult Index(int? id)
        {
            if (id == null) return Redirect(Url.Content("~/"));
            ViewBag.Title = "Osaleja lisamine";
            YritusApiController yritusController = new YritusApiController();
            var yritused = yritusController.Get(id);
            ViewBag.Yritus = yritused;
            return View();
        }

        // GET: LisaOsaleja/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LisaOsaleja/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LisaOsaleja/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LisaOsaleja/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LisaOsaleja/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LisaOsaleja/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
