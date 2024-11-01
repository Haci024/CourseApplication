using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class QuestionOfDay
    {
        public int Id { get; set; }

        public Questions Questions { get; set; }

        public int Question { get; set; }

        public AppUser AppUser { get; set; }

        public Guid AppUserId { get; set; }

        public ICollection<AnswerList> AnswerList { get; set; }

        public string Answer { get; set; }


    }
}
