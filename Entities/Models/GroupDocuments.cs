using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class GroupDocuments
    {

        public Groups Groups { get; set; }
        public int GroupId { get; set; }

        public Documents Documents { get;set; }
        public int DocumentsId { get; set; }
    }
}
