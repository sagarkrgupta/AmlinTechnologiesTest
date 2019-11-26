using ContestantSystem.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContestantSystem.Repository.EntityConfiguration
{
    class ContestantConfiguration : EntityTypeConfiguration<Contestant>
    {
        public ContestantConfiguration()
        {
            //ToTable("Contestant");
            this.Property(p => p.Firstname).IsRequired().HasColumnType("Varchar").HasMaxLength(50);
            this.Property(p => p.Lastname).IsRequired().HasColumnType("Varchar").HasMaxLength(50);
            this.Property(p => p.DateOfBirth).IsRequired().HasColumnType("date");
            this.Property(p => p.DistrictId).IsRequired().HasColumnType("int");
            this.Property(p => p.Gender).IsRequired().HasColumnType("Varchar").HasMaxLength(20);
            this.Property(p => p.PhotoUrl).IsRequired().HasColumnType("Varchar").HasMaxLength(50);
            this.Property(p => p.Address).IsRequired().HasColumnType("Varchar").HasMaxLength(100);


        }
    }
}
