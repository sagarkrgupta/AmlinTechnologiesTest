using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContestantSystem.Domain
{
    public class Contestant
    {
        [Key]
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public DateTime DateOfBirth { get; set; }
        public bool IsActive { get; set; }
        public int DistrictId { get; set; }
        public string Gender { get; set; }
        public string PhotoUrl { get; set; }
        public string Address { get; set; }

        [ForeignKey("DistrictId")]
        public virtual District District { get; set; }

    }

   
}
