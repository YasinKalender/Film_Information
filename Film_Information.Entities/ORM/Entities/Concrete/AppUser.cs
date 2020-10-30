using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Film_Information.Entities.ORM.Entities.Concrete
{
    public class AppUser:IdentityUser<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Image { get; set; }

    }
}
