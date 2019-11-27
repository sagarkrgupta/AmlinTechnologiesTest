using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContestantSystem.Domain;
using ContestantSystem.Repository.Persistance;

namespace ContestantSystem.Service.ContestantRating
{
    public class ContestantRatingService : IContestantRatingService
    {
        private readonly IGenericRepositories<ContestantSystem.Domain.ContestantRating> _ContestantRatingRepo;

        public ContestantRatingService()
        {
            _ContestantRatingRepo = new GenericRepositories<ContestantSystem.Domain.ContestantRating>();
        }


        public IEnumerable<Domain.ContestantRating> GetAllContestantRating()
        {
            return _ContestantRatingRepo.GetList();
        }

        public Domain.ContestantRating GetContestantRatingByContestantRatingID(int Id)
        {
            return _ContestantRatingRepo.GetList().FirstOrDefault(x=>x.ContestantId==Id);
        }

        public Domain.ContestantRating GetContestantRatingByID(int Id)
        {
            return _ContestantRatingRepo.GetbyID(Id);
        }

        public void UpdateContestantRating(Domain.ContestantRating contestantRating)
        {
            _ContestantRatingRepo.Update(contestantRating);
        }
        public void InsertContestantRating(Domain.ContestantRating contestantRating)
        {
            _ContestantRatingRepo.Add(contestantRating);
        }
    }
}
