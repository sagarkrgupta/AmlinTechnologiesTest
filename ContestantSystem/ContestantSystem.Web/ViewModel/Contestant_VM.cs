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
        [Required]
        public DateTime DateOfBirth { get; set; }
        public bool IsActive { get; set; } = true;
        [Required]
        public int DistrictId { get; set; }
        public string Gender { get; set; }
        public string PhotoUrl { get; set; } = "/Media/Default.png";
        [Required]
        public string Address { get; set; }

        [ForeignKey("DistrictId")]
        public virtual District District { get; set; }
    }
}