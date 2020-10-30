using Film_Information.DAL.Context;
using Film_Information.Entities.ORM.Entities.Concrete;
using Film_Information.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Film_Information.Repository.Concrete
{
    public class FilmRepository:BaseRepository<Film>,IFilmRepository
    {
       
        public FilmRepository(ProjectContext projectContext):base(projectContext)
        {

        }

        public Film AllFilms(int id)
        {
            return _projectContext.Films.Include(i => i.Comments).ThenInclude(i => i.AppUser).FirstOrDefault(i => i.ID == id);
        }

        public List<Film> CategoryAll(int? id)
        {
            var films = _projectContext.Films.Include(i => i.Category).AsQueryable();

            if (id!=null)
            {
                films = films.Where(i => i.CategoryID == id);
            }

            return films.ToList();
        }

        public List<Film> GetAll(string s)
        {
           var result =  _projectContext.Films.AsQueryable();

            if (!string.IsNullOrWhiteSpace(s))
            {
                result = result.Where(i => i.FilmName.ToLower().Contains(s));
            }

            return result.ToList();
        }

        public List<Film> LastFilm()
        {
            return _projectContext.Films.OrderByDescending(i => i.AddDate).ToList();
        }

        public List<Film> WithCategory()
        {
            return _projectContext.Films.Include(i => i.Category).ToList();
        }
    }
}
