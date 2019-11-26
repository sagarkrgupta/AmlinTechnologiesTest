using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContestantSystem.Domain
{
    public class ContestantRating
    {
        public int Id { get; set; }
        public int ContestantId { get; set; }
        public int Rating { get; set; }
        public DateTime RatedDate { get; set; }
    }
}
