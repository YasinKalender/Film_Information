using System;
using System.Collections.Generic;
using System.Text;

namespace Film_Information.Entities.ORM.Entities.Concrete
{
    public class Film:BaseEntity
    {
        public string FilmName { get; set; }

        public string FilmDescription { get; set; }

        public string Image { get; set; }

        public int CategoryID { get; set; }

        public Category Category { get; set; }

        public List<Comments> Comments { get; set; }

    }
}
