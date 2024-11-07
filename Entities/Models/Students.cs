using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Students
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string FatherName { get; set; }

        public DateTime AddingDate { get; set; }

        public AppUser  AppUser { get; set; }

        public bool IsMale { get; set; }

        public ICollection<StudentGroups> StudentGroups { get; set; }

        public Guid AppUserId { get; set; }

        public Universities Universities { get; set; }

        public int UniversityId { get; set; }

        public decimal BachelorPoint { get; set; }

        public ICollection<Payments> Payments { get; set; }

        public ICollection<Attendence> Attendences { get; set; }

        public string  Description { get; set; }

        public decimal TotalPayments { get; set; }

        public ICollection<StudentExam> StudentExams { get; set; }

        public string DocumentUrl { get; set; }

        public string SavedFileUrl { get; set; }

        




    }
}
