using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RIK_HomeWork.Controllers
{
    public class LisaYritusController : Controller
    {
        // GET: LisaYritus
        public ActionResult Index()
        {
            return View();
        }

        // GET: LisaYritus/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LisaYritus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LisaYritus/Create
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

        // GET: LisaYritus/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LisaYritus/Edit/5
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

        // GET: LisaYritus/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LisaYritus/Delete/5
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
