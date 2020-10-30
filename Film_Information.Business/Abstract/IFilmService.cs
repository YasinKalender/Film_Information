using Film_Information.Entities.ORM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Film_Information.Business.Abstract
{
    public interface IFilmService:IBaseService<Film>
    {

        List<Film> WithCategory();
        List<Film> CategoryAll(int? id);
        List<Film> GetAll(string s);
        List<Film> LastFilm();

        Film AllFilms(int id);
    }
}
