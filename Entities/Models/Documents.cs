using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Documents
    {
        public int Id { get; set; }

        public string FileContent { get; set; }

        public string SavedFileUrl { get; set; }

        public bool Status { get; set; }

        public DateTime AddingDate { get; set; }

        public ICollection<GroupDocuments> GroupDocuments { get; set; }
    }
}
