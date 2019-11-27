using ContestantSystem.Service.Contestant;
using ContestantSystem.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContestantSystem.Web.Controllers
{
    public class GalleryController : Controller
    {
        private readonly IContestantService _Service;
        public GalleryController()
        {
            _Service = new ContestantService();
        }
        // GET: Gallery
        public ActionResult Index()
        {
            IList<Contestant_VM> VMList = _Service.GetAllContestants().Where(x=>x.IsActive==true).Select(x => new Contestant_VM().Domain_To_VM(x)).ToList();

            return View(VMList);

           
        }
    }
}