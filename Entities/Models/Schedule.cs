using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Schedule
    {
        public int Id { get; set; }

        public DateTime LessonDate { get; set; }

        public ICollection<Attendence> Attendence { get; set; }

        public StudentGroups StudentGroups { get; set; }

        public int StudentGroupId { get; set; }


    }
}
