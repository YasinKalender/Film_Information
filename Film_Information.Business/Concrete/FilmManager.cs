using Film_Information.Business.Abstract;
using Film_Information.Entities.ORM.Entities.Concrete;
using Film_Information.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Film_Information.Business.Concrete
{
    public class FilmManager : IFilmService
    {

        private readonly IFilmRepository _filmRepository;

        public FilmManager(IFilmRepository filmRepository)
        {
            _filmRepository = filmRepository;
        }
        public void Add(Film entity)
        {
            _filmRepository.Add(entity);
        }

        public Film AllFilms(int id)
        {
            return _filmRepository.AllFilms(id);
        }

        public List<Film> CategoryAll(int? id)
        {
            return _filmRepository.CategoryAll(id);
        }

        public void Delete(Film entity)
        {
            _filmRepository.Delete(entity);
        }

        public List<Film> GetAll(string s)
        {
            return _filmRepository.GetAll(s);
        }

        public List<Film> GetAll()
        {
            return _filmRepository.GetAll();
        }

        public List<Film> GetAll(Expression<Func<Film, bool>> expression)
        {
            return _filmRepository.GetAll(expression);
        }

        public Film Getbyid(int id)
        {
            return _filmRepository.Getbyid(id);
        }

        public Film GetOne(Expression<Func<Film, bool>> expression)
        {
            return _filmRepository.GetOne(expression);
        }

        public List<Film> LastFilm()
        {
            return _filmRepository.LastFilm();
        }

        public void Update(Film entity)
        {
            _filmRepository.Update(entity);
        }

        public List<Film> WithCategory()
        {
            return _filmRepository.WithCategory();
        }
    }
}
