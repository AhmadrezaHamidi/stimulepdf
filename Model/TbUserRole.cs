using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace VstaabnerWpf.Model
{
    public class TbUserRole : IdentityUserRole<string>
    {
        public TbUser User { get; set; }
        public TbRole Role { get; set; }
    }
}
