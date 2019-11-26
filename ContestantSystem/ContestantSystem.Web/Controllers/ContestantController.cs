using ContestantSystem.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContestantSystem.Web.Controllers
{
    public class ContestantController : Controller
    {
        // GET: Contestant
        public ActionResult Index()
        {
            return View();
        }

        // GET: Contestant/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        private void LoadDDL()
        {
            ViewBag.DistrictDDL = new List<SelectListItem> { new SelectListItem { Text="Morang", Value="1" } };
        }
        // GET: Contestant/Create
        public ActionResult Create()
        {
            LoadDDL();
            return View();
        }

        // POST: Contestant/Create
        [HttpPost]
        public ActionResult Create(Contestant_VM obj)
        {
            if (ModelState.IsValid)
            {
                return View("Index");
            }

            LoadDDL();
            return View(obj);
        }

        // GET: Contestant/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Contestant/Edit/5
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

        // GET: Contestant/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contestant/Delete/5
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
