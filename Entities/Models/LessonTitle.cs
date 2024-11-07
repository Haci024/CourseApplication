using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class LessonTitle
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public bool Status { get; set; }

        public TeacherGroups TeacherGroups { get; set; }

        public int TeacherGroupsId { get; set; }


    }
}
