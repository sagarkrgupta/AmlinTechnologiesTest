using ContestantSystem.Domain;
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


        private IEnumerable<ContestantRating_VM> GetAverageRating(DateTime? Datefrom, DateTime? Dateto, bool FilterOperation)
        {

            List<ContestantRating_VM> Returnlist = new List<ContestantRating_VM>();


            var RawList = _Service.GetAllContestantRating()
                .Where(x => x.Contestant.IsActive == true)
                // .Select(x => new ContestantRating_VM { Id = x.Id, ContestantId = x.ContestantId, Rating = x.Rating, RatedDate = x.RatedDate, Contestant = x.Contestant })
                .ToList();

            var groupedResult = RawList.GroupBy(x => x.ContestantId).Select(x => x);

            foreach (var item in groupedResult)
            {
                if (FilterOperation)
                {
                    //Perform Filter 
                    var datefilter = from a in item.Select(x => x)
                                            where (a.RatedDate.Date >= Datefrom &&  a.RatedDate.Date <= Dateto) || (a.RatedDate.Date >= Datefrom || a.RatedDate.Date <= Dateto)
                                            select a;

                  
                    if (datefilter.Count()>0)
                    {
                       decimal avg = (decimal)datefilter.Sum(x => x.Rating) / datefilter.Count();
                        var obj = datefilter.FirstOrDefault(x => x.ContestantId == item.Key);

                        Returnlist.Add(new ContestantRating_VM { ContestantId = obj.ContestantId, AverageRate = avg, Contestant = obj.Contestant });
                    }

                   

                   

                   
                }
                else
                {
                    //Calculate directly 
              
                    var avg = ((decimal)item.Sum(x => x.Rating) / item.Count());

                    var obj = item.FirstOrDefault(x => x.ContestantId== item.Key);

                    Returnlist.Add(new ContestantRating_VM { ContestantId = obj.ContestantId, AverageRate = avg, Contestant = obj.Contestant });

                }

            }

            return Returnlist;

        }

        // GET: ContestantRating
        public ActionResult Index()
        {
            var list = GetAverageRating(null, null, FilterOperation: false);

            return View(list);
        }

       
        public ActionResult SearchIndex(DateTime? Datefrom, DateTime? Dateto)
        {

            var list = GetAverageRating(Datefrom,Dateto, FilterOperation: true);

           
            return View("Index", list);

        }


        [HttpPost]
        public ActionResult AddNewRating(ContestantRating obj)
        {
            bool Success = false;

            try
            {
                obj.RatedDate = DateTime.Now;
                _Service.InsertContestantRating(obj);

                Response.StatusCode = 200;
                Success = true;



            }
            catch (Exception)
            {
                Response.StatusCode = 500;

            }

            return Json(new { Result = Success });
        }

    }
}