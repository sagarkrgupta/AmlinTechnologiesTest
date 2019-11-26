using ContestantSystem.Service.Contestant;
using ContestantSystem.Service.Districts;
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

        private readonly IContestantService _Service;
        private readonly IDistrictService _DistrictService;

        public ContestantController()
        {
            _Service = new ContestantService();
            _DistrictService = new DistrictService();
        }


        // GET: Contestant
        public ActionResult Index()
        {
            ViewBag.csname = ContestantSystem.Common.DBManager.GetConnectionStringName;
            ViewBag.csvalue = ContestantSystem.Common.DBManager.DbConnect().ConnectionString;

            return View();

        }


        private void LoadDDL()
        {
           var list = _DistrictService.GetAllDistrict().Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
            ViewBag.DistrictDDL = list;
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
            LoadDDL();
            return View("Create");
        }

        // POST: Contestant/Edit/5
        [HttpPost]
        public ActionResult Edit(Contestant_VM obj)
        {
            if (ModelState.IsValid)
            {
                return View("Index");
            }

            LoadDDL();
            return View("Create", obj);
        }

        //// GET: Contestant/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: Contestant/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {

            return View();

        }
    }
}
