using ContestantSystem.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContestantSystem.Web.ViewModel
{
    public class Contestant_VM
    {
        
        [Key]
        public int Id { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }

        public string FullName { get { return this.Firstname + " " + this.Lastname; } }

        [Required]
        public DateTime DateOfBirth { get; set; }
        public bool IsActive { get; set; } = true;
        [Required]
        public int DistrictId { get; set; }
        [Required]
        public string Gender { get; set; }

        public HttpPostedFileBase PhotoFile { get; set; }
        public string PhotoUrl { get; set; } = "/Media/Default.png";

        [Required]
        public string Address { get; set; }

        [ForeignKey("DistrictId")]
        public virtual District District { get; set; }



        public Contestant VM_To_Domain()
        {

            return new Contestant
            {
                Address = this.Address,
                DateOfBirth = this.DateOfBirth,
                Id = this.Id,
                District = this.District,
                DistrictId = this.DistrictId,
                Firstname = this.Firstname,
                Gender = this.Gender,
                IsActive = this.IsActive,
                Lastname = this.Lastname,
                PhotoUrl = this.PhotoUrl,

            };
        }

        public Contestant_VM Domain_To_VM(Contestant obj)
        {

            return new Contestant_VM
            {
                Address = obj.Address,
                DateOfBirth = obj.DateOfBirth,
                Id = obj.Id,
                District = obj.District,
                DistrictId = obj.DistrictId,
                Firstname = obj.Firstname,
                Gender = obj.Gender,
                IsActive = obj.IsActive,
                Lastname = obj.Lastname,
                PhotoUrl = obj.PhotoUrl,

            };
        }

    }
}