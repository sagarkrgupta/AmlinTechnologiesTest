using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContestantSystem.Domain;
using ContestantSystem.Repository.Persistance;

namespace ContestantSystem.Service.Districts
{
    public class DistrictService : IDistrictService
    {

        private readonly IGenericRepositories<ContestantSystem.Domain.District> _DistrictRepo;

        public DistrictService()
        {
            _DistrictRepo = new GenericRepositories<ContestantSystem.Domain.District>();
        }
        

        public IEnumerable<District> GetAllDistrict()
        {
            return _DistrictRepo.GetList();
        }

        public District GetDistrictByID(int Id)
        {
            return _DistrictRepo.GetbyID(Id);
        }
    }
}
