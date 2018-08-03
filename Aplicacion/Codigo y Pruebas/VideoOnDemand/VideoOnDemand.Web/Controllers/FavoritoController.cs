using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VideoOnDemand.Web.Controllers
{
    public class FavoritoController : Controller
    {
        // GET: Favorito
        public ActionResult Index()
        {
            return View();
        }

        // GET: Favorito/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Favorito/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Favorito/Create
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

        // GET: Favorito/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Favorito/Edit/5
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

        // GET: Favorito/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Favorito/Delete/5
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
