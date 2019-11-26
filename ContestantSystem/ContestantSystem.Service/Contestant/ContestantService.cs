using ContestantSystem.Domain;
using ContestantSystem.Repository.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContestantSystem.Service.Contestant
{
    public class ContestantService : IContestantService
    {
        private readonly IGenericRepositories<ContestantSystem.Domain.Contestant> _ContestantRepo;

        public ContestantService()
        {
            _ContestantRepo = new GenericRepositories<ContestantSystem.Domain.Contestant>();
        }

        public IEnumerable<Domain.Contestant> GetAllContestants()
        {
           return _ContestantRepo.GetList();
        }

        public Domain.Contestant GetContestantsByID(int Id)
        {
            return _ContestantRepo.GetbyID(Id);
        }

        public void InsertContestant(Domain.Contestant contestant)
        {
            _ContestantRepo.Add(contestant);
        }

        public void RemoveContestant(Domain.Contestant contestant)
        {
            _ContestantRepo.Remove(contestant);
        }

        public void UpdateContestant(Domain.Contestant contestant)
        {
            _ContestantRepo.Update(contestant);
        }
    }
}
