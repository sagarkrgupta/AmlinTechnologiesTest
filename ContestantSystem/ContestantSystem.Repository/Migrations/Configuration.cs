namespace ContestantSystem.Repository.Migrations
{
    using ContestantSystem.Domain;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ContestantSystem.Repository.ContestantDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ContestantSystem.Repository.ContestantDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            if (context.District.Count()<=0)
            {
                IList<District> Districtinit = new List<District> {


                new District { Name="Achham" },
                new District { Name="Arghakhanchi" },
                new District { Name="Baglung" },
                new District { Name="Baitadi" },
                new District { Name="Bajhang" },
                new District { Name="Bajura" },
                new District { Name="Banke" },
                new District { Name="Bara" },
                new District { Name="Bardiya" },
                new District { Name="Bhaktapur" },
                new District { Name="Bhojpur" },
                new District { Name="Chitwan" },
                new District { Name="Dadeldhura" },
                new District { Name="Dailekh" },
                new District { Name="Dang" },
                new District { Name="Darchula" },
                new District { Name="Dhading" },
                new District { Name="Dhankuta" },
                new District { Name="Dhanusa" },
                new District { Name="Dolakha" },
                new District { Name="Dolpa" },  new District { Name="Doti" },  new District { Name="Gorkha" },  new District { Name="Gulmi" },  new District { Name="Humla" },  new District { Name="Ilam" },  new District { Name="Jajarkot" },  new District { Name="Jhapa" },  new District { Name="Jumla" },  new District { Name="Kailali" },  new District { Name="Kalikot" },  new District { Name="Kanchanpur" },  new District { Name="Kapilvastu" },  new District { Name="Kaski" },  new District { Name="Kathmandu" },  new District { Name="Kavrepalanchok" },  new District { Name="Khotang" },  new District { Name="Lalitpur" },  new District { Name="Lamjung" },  new District { Name="Mahottari" },  new District { Name="Makwanpur" },  new District { Name="Manang" },  new District { Name="Morang" },  new District { Name="Mugu" },  new District { Name="Mustang" },  new District { Name="Myagdi" },  new District { Name="Nawalparasi" },  new District { Name="Nuwakot" },  new District { Name="Okhaldhunga" },  new District { Name="Palpa" },  new District { Name="Panchthar" },  new District { Name="Parbat" },  new District { Name="Parsa" },  new District { Name="Pyuthan" },  new District { Name="Ramechhap" },  new District { Name="Rasuwa" },  new District { Name="Rautahat" },  new District { Name="Rolpa" },  new District { Name="Rukum" },  new District { Name="Rupandehi" },  new District { Name="Salyan" },  new District { Name="Sankhuwasabha" },  new District { Name="Saptari" },  new District { Name="Sarlahi" },  new District { Name="Sindhuli" },  new District { Name="Sindhupalchok" },  new District { Name="Siraha" },  new District { Name="Solukhumbu" },  new District { Name="Sunsari" },  new District { Name="Surkhet" },  new District { Name="Syangja" },  new District { Name="Tanahu" },  new District { Name="Taplejung" },  new District { Name="Terhathum" },  new District { Name="Udayapur" }


            };

                context.District.AddRange(Districtinit);
                context.SaveChanges();

            }

        }
    }
}
