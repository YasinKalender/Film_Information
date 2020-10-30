using Film_Information.DAL.Context;
using Film_Information.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Film_Information.Repository.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {

        protected ProjectContext _projectContext;

        public BaseRepository(ProjectContext projectContext)
        {
            _projectContext = projectContext;
        }
        public void Add(T entity)
        {
            _projectContext.Set<T>().Add(entity);
            _projectContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            _projectContext.Set<T>().Remove(entity);
            _projectContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _projectContext.Set<T>().ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return _projectContext.Set<T>().Where(expression).ToList();
        }

        public T Getbyid(int id)
        {
            return _projectContext.Set<T>().Find(id);
        }

        public T GetOne(Expression<Func<T, bool>> expression)
        {
            return _projectContext.Set<T>().FirstOrDefault(expression);
        }

        public void Update(T entity)
        {
            _projectContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _projectContext.SaveChanges();
        }
    }
}
