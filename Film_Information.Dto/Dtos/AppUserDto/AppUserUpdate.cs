using System;
using System.Collections.Generic;
using System.Text;

namespace Film_Information.Dto.Dtos.AppUserDto
{
    public class AppUserUpdate
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string Image { get; set; }
    }
}
