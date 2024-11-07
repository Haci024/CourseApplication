using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class AppUser:IdentityUser<Guid>
    {    
        public int ForgetPasswordCode { get; set; }

        public string Email { get; set; }

        public ICollection<AppUserFilial> AppUserFilial { get; set; }    

        public Teachers Teachers { get; set; }

        public Students Students { get; set; }

        public ICollection<Payments> Payments { get; set; }

        public ICollection<Notfications> Notfications { get; set; }






    }
}
