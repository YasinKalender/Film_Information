using Film_Information.Entities.ORM.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Film_Information.UI.Identity
{
    public static class IdentityInitializer
    {
        public static async Task Identity(UserManager<AppUser> userManager,RoleManager<AppRole> roleManager)
        {
            var role = await roleManager.FindByNameAsync("Admin");

            if (role==null)
            {
                await roleManager.CreateAsync(new AppRole() { Name = "Admin" });
            }

            var memberrole = await roleManager.FindByNameAsync("Member");

            if (memberrole==null)
            {
                await roleManager.CreateAsync(new AppRole() { Name = "Member" });
            }


            var user = await userManager.FindByNameAsync("Yasin");

            if (user==null)
            {
                var adminuser = new AppUser()
                {
                    FirstName = "Yasin",
                    LastName = "Kalender",
                    UserName = "Yasin",
                    Email = "ysn@gmail.com"
                };

                await userManager.CreateAsync(adminuser, "1");
                await userManager.AddToRoleAsync(adminuser, "Admin");
            }


        }

    }
}
