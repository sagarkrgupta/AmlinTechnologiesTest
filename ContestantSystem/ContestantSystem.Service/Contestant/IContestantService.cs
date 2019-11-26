using System.Collections.Generic;

namespace ContestantSystem.Service.Contestant
{
    public interface IContestantService
    {
        IEnumerable<ContestantSystem.Domain.Contestant> GetAllContestants();
        ContestantSystem.Domain.Contestant GetContestantsByID(int Id);

        void InsertContestant(ContestantSystem.Domain.Contestant contestant);
        void UpdateContestant(ContestantSystem.Domain.Contestant contestant);
        void RemoveContestant(ContestantSystem.Domain.Contestant contestant);


    }
}