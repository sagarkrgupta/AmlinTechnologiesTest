using ContestantSystem.Service.Contestant;
using ContestantSystem.Service.Districts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContestantSystem.Web.Controllers
{
    public class MapController : Controller
    {
       
        private readonly IContestantService _ContestantService;

        public MapController()
        {
           
            _ContestantService = new ContestantService();
        }


        // GET: Map
        public ActionResult Index()
        {
            LoadContestantDensity();
            return View();
        }


        private void LoadContestantDensity()
        {
            var list = _ContestantService.GetAllContestants().Where(x => x.IsActive == true).ToList();
            ViewBag.ContestantList = list;
        }
    }
}