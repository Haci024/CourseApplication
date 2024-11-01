using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class StudentGroups
    {
        public Students Students { get; set; }

        public int StudentId { get; set; }

        public Groups Groups { get; set; }

        public int GroupId { get; set; }
    }
}
