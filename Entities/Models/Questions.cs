using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Questions
    {
        public enum TypeList
        {
            Açıq = 1,
            Variant = 2,
            Mətn = 3,
            Audio = 4
        }
        public int Id { get; set; }

        public string Content { get; set; }

        public bool Status { get; set; }

        public TypeList QuestionTypes { get; set; }

        public ICollection<Options> Options { get; set; }

        public ICollection<ExamQuestions> ExamQuestions { get; set; }

        public ICollection<StudentAnswers> StudentAnswers { get; set; }
    }
}
