using System.Collections.Generic;

namespace ContestantSystem.Service.ContestantRating
{
    public interface IContestantRatingService
    {
        IEnumerable<ContestantSystem.Domain.ContestantRating> GetAllContestantRating();
        ContestantSystem.Domain.ContestantRating GetContestantRatingByID(int Id);
        ContestantSystem.Domain.ContestantRating GetContestantRatingByContestantRatingID(int Id);


        void UpdateContestantRating(ContestantSystem.Domain.ContestantRating contestantRating);
        void InsertContestantRating(ContestantSystem.Domain.ContestantRating contestantRating);

    }
}