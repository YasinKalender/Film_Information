using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Film_Information.Repository.Abstract
{
    public interface IBaseRepository<T>
    {
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> expression);

        T GetOne(Expression<Func<T, bool>> expression);

        T Getbyid(int id);

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);



        

    }
}
