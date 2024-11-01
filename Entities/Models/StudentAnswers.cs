using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class StudentAnswers
    {
        public long Id { get; set; }

        public StudentExam StudentExam { get; set; }

        public long StudentExamId { get; set; }

        public Questions Questions { get; set; }

        public int QuestionId { get; set; }

        public bool TrueOrNot { get; set; }
    }
}
