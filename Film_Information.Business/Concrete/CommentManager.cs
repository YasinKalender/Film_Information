using Film_Information.Business.Abstract;
using Film_Information.Entities.ORM.Entities.Concrete;
using Film_Information.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Film_Information.Business.Concrete
{
    public class CommentManager : ICommentService
    {

        private readonly ICommentsRepository _commentRepository;

        public CommentManager(ICommentsRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }
        public void Add(Comments entity)
        {
            _commentRepository.Add(entity);
        }

        public void Delete(Comments entity)
        {
            throw new NotImplementedException();
        }

        public List<Comments> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Comments> GetAll(Expression<Func<Comments, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Comments Getbyid(int id)
        {
            return _commentRepository.Getbyid(id);
        }

        public Comments GetOne(Expression<Func<Comments, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(Comments entity)
        {
            throw new NotImplementedException();
        }
    }
}
