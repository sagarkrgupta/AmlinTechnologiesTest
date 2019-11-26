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
        public int Rating { get; set; }
        public DateTime RatedDate { get; set; }

        [ForeignKey("ContestantId")]
        public virtual Contestant Contestant { get; set; }
    }
}