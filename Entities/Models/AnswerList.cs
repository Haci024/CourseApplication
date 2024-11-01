using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class AnswerList
    {
        public AnswerList()
        {
            TrueOrNot=false;    
        }
        public long Id { get; set; }

        public QuestionOfDay QuestionOfDay { get; set; }

        public int QuestionOfDayId { get; set; }

        public Students Students { get; set; }

        public int StudentId { get; set; }

        public string Description { get; set; }

        public bool TrueOrNot { get; set; }
    }
}
