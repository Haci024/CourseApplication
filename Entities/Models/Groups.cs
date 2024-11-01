using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Groups
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Status { get; set; }

        public ICollection<StudentGroups> StudentGroups { get; set; }

        public ICollection<TeacherGroups> TeacherGroups { get; set; }

        public ICollection<GroupDocuments> GroupDocuments { get; set; }

        public Filial Filial { get; set; }

        public int FilialId { get; set; }


    }
}
