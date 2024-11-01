using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ExamQuestions
    {
        public Questions Questions { get; set; }
        public int QuestionId { get; set; }

        public Exam Exams { get; set; }
        public int ExamId { get; set; }
    }
}
