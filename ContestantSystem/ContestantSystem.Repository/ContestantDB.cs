using ContestantSystem.Common;
using ContestantSystem.Domain;
using ContestantSystem.Repository.EntityConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContestantSystem.Repository
{
    public class ContestantDB : DbContext
    {

        public ContestantDB() : base(DBManager.GetConnectionStringName)
        {
            Database.SetInitializer<ContestantDB>(new ContestantDBInitializer());
        }

        public DbSet<Contestant> Contestant { get; set; }
        public DbSet<ContestantRating> ContestantRating { get; set; }
        public DbSet<District> District { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<District>()
                .Property(e => e.Name).HasColumnType("varchar").HasMaxLength(50);




            modelBuilder.Configurations.Add(new ContestantConfiguration());
            modelBuilder.Configurations.Add(new ContestantRatingConfiguration());



        }

    }
}
