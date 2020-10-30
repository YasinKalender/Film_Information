﻿using Film_Information.Entities.ORM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Film_Information.Dto.Dtos.CommentsDto
{
    public class CommentsDto:BaseEntity
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Comment { get; set; }

        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }

        public int FilmID { get; set; }

        public Film Film { get; set; }
    }
}
