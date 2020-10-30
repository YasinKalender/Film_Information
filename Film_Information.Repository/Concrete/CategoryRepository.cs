using Film_Information.DAL.Context;
using Film_Information.Entities.ORM.Entities.Concrete;
using Film_Information.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Film_Information.Repository.Concrete
{
    public class CategoryRepository:BaseRepository<Category>,ICategoryRepository
    {
        public CategoryRepository(ProjectContext projectContext):base(projectContext)
        {

        }

       
    }
}
