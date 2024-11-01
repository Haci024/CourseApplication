using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Options
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public bool TrueOrNot { get; set; }

        public Questions Questions { get; set; }

        public int QuestionId { get; set; }
        
    }
}
