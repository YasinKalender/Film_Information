using Film_Information.DAL.Context;
using Film_Information.Entities.ORM.Entities.Concrete;
using Film_Information.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Film_Information.Repository.Concrete
{
    public class CommentRepository:BaseRepository<Comments>,ICommentsRepository
    {

        public CommentRepository(ProjectContext projectContext):base(projectContext)
        {

        }
    }
}
