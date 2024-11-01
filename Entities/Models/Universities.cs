using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Universities
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Status { get; set; }

        public ICollection<Students> Students { get; set; }
    }
}
