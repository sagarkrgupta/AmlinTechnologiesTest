using ContestantSystem.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContestantSystem.Web.ViewModel
{
    public class ContestantRating_VM
    {
        [Key]
        public int Id { get; set; }
        public int ContestantId { get; set; }
        [Required]
        public int Rating { get; set; }
        public DateTime RatedDate { get; set; } 

        [ForeignKey("ContestantId")]
        public virtual Contestant Contestant { get; set; }


        public decimal AverageRate { get; set; } = 0;
        public ContestantRating VM_To_Domain()
        {

            return new ContestantRating
            {
                ContestantId = this.ContestantId,
                Rating = this.Rating,
                Id = this.Id,
                RatedDate = this.RatedDate,
                Contestant = this.Contestant,
               
            };
        }

        public ContestantRating_VM Domain_To_VM(ContestantRating obj)
        {

            return new ContestantRating_VM
            {
                ContestantId = obj.ContestantId,
                Rating = obj.Rating,
                Id = obj.Id,
                RatedDate = obj.RatedDate,
                Contestant = obj.Contestant,

            };
        }

    }
}