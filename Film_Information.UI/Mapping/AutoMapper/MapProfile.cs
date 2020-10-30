using AutoMapper;
using Film_Information.Dto.Dtos.AppUserDto;
using Film_Information.Dto.Dtos.CategoryDto;
using Film_Information.Dto.Dtos.FilmDto;
using Film_Information.Entities.ORM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Film_Information.UI.Mapping.AutoMapper
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryListUpdateAddDto>();
            CreateMap<CategoryListUpdateAddDto, Category>();

            CreateMap<Film, FilmListAddUpdateDto>();
            CreateMap<FilmListAddUpdateDto, Film>();
            CreateMap<FilmCommentDto, Film>();
            CreateMap<Film, FilmCommentDto>();

            CreateMap<AppUser, AppUserRegister>();
            CreateMap<AppUserRegister, AppUser>();
        }

    }
}
