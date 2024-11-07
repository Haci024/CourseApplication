using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Notfications
    {
        public long Id { get; set; }

        public AppUser Receiver { get; set; }

        public string Content { get; set; }

        public Guid AppUserId { get; set; }

        public DateTime SendDate { get; set; }

        public bool   ViewOrNot { get; set; }
       


    }
}
