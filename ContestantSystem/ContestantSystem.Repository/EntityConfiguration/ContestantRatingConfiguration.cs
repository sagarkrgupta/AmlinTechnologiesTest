using ContestantSystem.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContestantSystem.Repository.EntityConfiguration
{
    class ContestantRatingConfiguration: EntityTypeConfiguration<ContestantRating>
    {
        public ContestantRatingConfiguration()
        {
            this.Property(p => p.ContestantId).IsRequired().HasColumnType("int");
            this.Property(p => p.Rating).IsRequired().HasColumnType("int");
            this.Property(p => p.RatedDate).HasColumnType("datetime");
           
        }
    }
}
