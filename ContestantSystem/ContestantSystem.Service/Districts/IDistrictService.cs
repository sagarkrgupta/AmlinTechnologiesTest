using System.Collections.Generic;

namespace ContestantSystem.Service.Districts
{
    public interface IDistrictService
    {

        IEnumerable<ContestantSystem.Domain.District> GetAllDistrict();
        ContestantSystem.Domain.District GetDistrictByID(int Id);
    }
}