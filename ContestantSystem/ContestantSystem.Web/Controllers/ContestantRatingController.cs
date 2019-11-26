using ContestantSystem.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContestantSystem.Web.Controllers
{
    public class ContestantRatingController : Controller
    {
        // GET: ContestantRating
        public ActionResult Index()
        {
            var list = new List<ContestantRating_VM>();
            return View(list);
        }
    }
}