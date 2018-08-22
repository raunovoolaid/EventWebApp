using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RIK_HomeWork.Controllers
{
    public class MuudaJurIsikController : Controller
    {
        // GET: MuudaJurIsik
        //public ActionResult Index()
        //{
        //   return View();
        //}

        // GET: MuudaJurIsik/Index/5
        public ActionResult Index(int? id = null)
        {
            if(id == null) return Redirect(Url.Content("~/"));
            JurIsikApiController jurIsikApiController = new JurIsikApiController();
            var jurisik = jurIsikApiController.Get(0, id);

            ViewBag.Jurisik = jurisik;
            return View();
        }

        // GET: MuudaJurIsik/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MuudaJurIsik/Create
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

        // GET: MuudaJurIsik/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MuudaJurIsik/Edit/5
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

        // GET: MuudaJurIsik/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MuudaJurIsik/Delete/5
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
