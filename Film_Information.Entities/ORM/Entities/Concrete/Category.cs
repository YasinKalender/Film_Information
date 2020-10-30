using System;
using System.Collections.Generic;
using System.Text;

namespace Film_Information.Entities.ORM.Entities.Concrete
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }

        public string CategoryDetails { get; set; }

        public List<Film> Films { get; set; }

    }
}
