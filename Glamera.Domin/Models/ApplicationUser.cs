﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.Domin.Models
{
    public class ApplicationUser: IdentityUser
    {      
        public string Password { get; set; }
        public string RoleName { get; set; }
        public int AccountID { get; set; }
    }
}
