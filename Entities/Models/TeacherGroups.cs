using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class TeacherGroups
    {

        public Teachers Teachers { get; set; }
        public int TeacherId { get; set; }

        public Groups Groups { get; set; }
        public int GroupId { get; set; }


    }
}
