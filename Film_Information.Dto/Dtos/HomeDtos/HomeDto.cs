using Film_Information.Dto.Dtos.CategoryDto;
using Film_Information.Dto.Dtos.FilmDto;
using Film_Information.Entities.ORM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Film_Information.Dto.Dtos
{
    public class HomeDto
    {
        public List<CategoryListUpdateAddDto> Categories { get; set; }

        public List<FilmListAddUpdateDto> Films { get; set; }

        public int FilmCount { get; set; }

        public List<Film> LastFilms { get; set; }

    }
}
