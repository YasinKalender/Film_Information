using Film_Information.Entities.ORM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Film_Information.Dto.Dtos.FilmDto
{
    public class FilmCommentDto:BaseEntity
    {

        public string FilmName { get; set; }

        public string FilmDescription { get; set; }

        public string Image { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Comment { get; set; }

        public int AppUserID { get; set; }

        public AppUser AppUser { get; set; }

        public int FilmID { get; set; }

        public Film Film { get; set; }

        public List<Comments> Comments { get; set; }
    }
}
