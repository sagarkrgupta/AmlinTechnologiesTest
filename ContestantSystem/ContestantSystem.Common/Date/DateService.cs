using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContestantSystem.Common.Date
{
   public class DateService : IDateService
    {
        public DateTime GetDate()
        {
            return DateTime.Now.Date;
        }
    }
}
