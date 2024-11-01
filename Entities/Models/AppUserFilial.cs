using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class AppUserFilial
    {
        public Guid AppUserId { get; set; }

        public AppUser AppUser { get; set; }

        public int FilialId { get; set; }

        public Filial Filial { get; set; }


    }
}
