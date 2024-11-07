using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entities.Models.Questions;

namespace Entities.Models
{
    public class Attendence
    {
        public long Id { get; set; }

        public Schedule Schedule { get; set; }

        public int ScheduleId { get; set; }

        public Students Students { get; set; }

        public int StudentsId { get; set; }

      public  enum Status
        {
            iştirak_edir=1, 
            Qayıb=2,
            Bayram=3,
        }
        public Status AttendenceStatus { get; set; }


    }
}
