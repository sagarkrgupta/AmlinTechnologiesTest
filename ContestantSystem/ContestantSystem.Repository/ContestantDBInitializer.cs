using ContestantSystem.Domain;
using System.Collections.Generic;
using System.Data.Entity;

namespace ContestantSystem.Repository
{
    public class ContestantDBInitializer : DropCreateDatabaseIfModelChanges<ContestantDB>
    {
        protected override void Seed(ContestantDB context)
        {
            base.Seed(context);

            IList<District> Districtinit = new List<District> {
                new District { Name="Kathmandu" },
                new District { Name="Bhaktapur" },
                new District { Name="Lalitpur" },
                new District { Name="Morang" },
                new District { Name="Sunsari" },
                new District { Name="Illam" },
                new District { Name="Jhapa" }

            };

            context.District.AddRange(Districtinit);
            context.SaveChanges();

        }
    }
}