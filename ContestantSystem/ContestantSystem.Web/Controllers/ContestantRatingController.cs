using ContestantSystem.Service.Contestant;
using ContestantSystem.Service.ContestantRating;
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
        private readonly IContestantRatingService _Service;
        private readonly IContestantService _ContestantService;

        public ContestantRatingController()
        {
            _Service = new ContestantRatingService();
            _ContestantService = new ContestantService();
        }

        // GET: ContestantRating
        public ActionResult Index()
        {
            var RawList = _Service.GetAllContestantRating()
                .Where(x => x.Contestant.IsActive == true)
                .Select(x=> new ContestantRating_VM { Id=x.Id, ContestantId = x.ContestantId, Rating= x.Rating, RatedDate=x.RatedDate, Contestant=x.Contestant })
                .ToList();

            return View(RawList);
        }


        public ActionResult UpdateRating()
        {
            var list = _Service.GetAllContestantRating().Where(x => x.Contestant.IsActive == true).ToList();
            return View(list);
        }

    }
}