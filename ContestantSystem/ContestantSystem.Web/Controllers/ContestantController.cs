using ContestantSystem.Domain;
using ContestantSystem.Service.Contestant;
using ContestantSystem.Service.Districts;
using ContestantSystem.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
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

            IList<Contestant_VM> VMList = _Service.GetAllContestants().Select(x => new Contestant_VM().Domain_To_VM(x)).ToList();

            return View(VMList);

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
            var obj = new Contestant_VM();

            return View(obj);
        }

        private string UploadFile(HttpPostedFileBase PhotoFile)
        {


            try
            {
                string ReturnFileName = string.Empty;
                string filename = Path.GetFileNameWithoutExtension(PhotoFile.FileName) + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(PhotoFile.FileName);
                ReturnFileName = "~/Media/Contestant/" + filename;

                filename = Path.Combine(Server.MapPath("~/Media/Contestant/"), filename);
                PhotoFile.SaveAs(filename);

                ViewBag.FileStatus = "File uploaded successfully.";

                return ReturnFileName;
            }
            catch (Exception)
            {
                ViewBag.FileStatus = "Error while file uploading.";
                return "/Media/Default.png";
            }


        }

        // POST: Contestant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Contestant_VM vm)
        {

            if (ModelState.IsValid)
            {
                if (vm.PhotoFile != null)
                    vm.PhotoUrl = UploadFile(vm.PhotoFile);

                
                var obj = vm.VM_To_Domain();

                _Service.InsertContestant(obj);
                return View("Index");

            }

            LoadDDL();
            return View(vm);
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

      
        // POST: Contestant/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {

            if (id>0)
            {
                var obj = _Service.GetContestantsByID(id);
                if (obj!=null)
                {
                    //_Service.RemoveContestant(obj);
                    TempData["Message"] = new string[] { "success", "Contestant", "Deleted Succesfully." };
                }
                else
                    TempData["Message"] = new string[] { "error", "Contestant", "Some Error Occured While Deleting." };
               
            }

            return RedirectToAction("Index");


        }
    }
}
