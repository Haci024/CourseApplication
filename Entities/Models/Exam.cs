using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Exam
    {
        public int Id { get; set; }

        public bool Status { get; set; }

        public string Name { get; set; }

        public int ExamDuration { get; set; }//dəqiqə hesablanır

        public DateTime StartDate { get; set; }

        public DateTime LastDate { get; set; }

        public ICollection<ExamQuestions> ExamQuestions { get; set; }

        public ICollection<StudentExam> StudentExam { get; set;}
    }
}
