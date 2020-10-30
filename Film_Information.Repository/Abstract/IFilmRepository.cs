using Film_Information.Entities.ORM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Film_Information.Repository.Abstract
{
    public interface IFilmRepository:IBaseRepository<Film>
    {

        List<Film> WithCategory();

        List<Film> CategoryAll(int? id);

        List<Film> GetAll(string s);

        List<Film> LastFilm();

        Film AllFilms(int id );
    }
}
