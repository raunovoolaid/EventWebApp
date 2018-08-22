using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RIK_HomeWork.Controllers
{
    public class MuudaEraisikController : Controller
    {
        // GET: MuudaEraisik
        //public ActionResult Index()
        //{
        //    return View();
        //}

        // GET: MuudaEraisik/Details/5
        public ActionResult Index(int? id = null)
        {
            if (id == null) return Redirect(Url.Content("~/"));
            EraisikApiController eraisikApiController = new EraisikApiController();
            var eraisik = eraisikApiController.Get(0, id);

            ViewBag.Eraisik = eraisik;
            return View();
        }

        // GET: MuudaEraisik/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MuudaEraisik/Create
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

        // GET: MuudaEraisik/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MuudaEraisik/Edit/5
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

        // GET: MuudaEraisik/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MuudaEraisik/Delete/5
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
