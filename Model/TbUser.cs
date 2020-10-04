using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace VstaabnerWpf.Model
{

    public class TbUser : IdentityUser
    {

        public virtual DateTimeOffset? Birthday { get; set; }
        public List<TbUserRole> userRoles { get; set; }
        public List<TbShelve> Shelves { get; set; }
    }
}
