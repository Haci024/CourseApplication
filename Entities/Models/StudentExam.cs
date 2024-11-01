using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class StudentExam
    {
        public StudentExam()
        {
            StartTime= DateTime.UtcNow;
        }
        public long Id { get; set; }
        public Students Students { get; set; }
        public int StudentId { get; set; }
        public DateTime StartTime { get; set; }
        public Exam Exams { get; set; }
        public int ExamId { get; set; }
    }
}
