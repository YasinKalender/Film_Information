using Film_Information.Business.Abstract;
using Film_Information.Entities.ORM.Entities.Concrete;
using Film_Information.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Film_Information.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {

        private readonly ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void Add(Category entity)
        {
            _categoryRepository.Add(entity);
        }

        public void Delete(Category entity)
        {
            _categoryRepository.Delete(entity);
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> expression)
        {
            return _categoryRepository.GetAll(expression);
        }

        public Category Getbyid(int id)
        {
            return _categoryRepository.Getbyid(id);
        }

        public Category GetOne(Expression<Func<Category, bool>> expression)
        {
            return _categoryRepository.GetOne(expression);
        }

        public void Update(Category entity)
        {
            _categoryRepository.Update(entity);
        }
    }
}
