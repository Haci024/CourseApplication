﻿using Microsoft.AspNetCore.Identity;
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
    }
}