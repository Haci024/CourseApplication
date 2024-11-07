using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Teachers
    {
        public int Id { get; set; }

        public AppUser AppUser { get; set; }

        public Guid AppUserId { get; set; }

        public string FullName { get; set; }

        public bool Status { get; set; }

        public DateTime BirthDate { get; set; }

        public ICollection<TeacherGroups> TeacherGroups { get; set; }

        public string ImageUrl { get; set; }

        public string SavedImageUrl { get; set; }
    }
}
