using Film_Information.Entities.ORM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Film_Information.Dto.Dtos.FilmDto
{
    public class FilmListAddUpdateDto:BaseEntity
    {

        public string FilmName { get; set; }

        public string FilmDescription { get; set; }

        public string Image { get; set; }

        public int CategoryID { get; set; }

        public Category Category { get; set; }
    }
}
