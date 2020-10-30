using AutoMapper;
using Film_Information.Business.Abstract;
using Film_Information.Dto.Dtos.FilmDto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Film_Information.UI.ViewComponents.FilmDescription
{
    public class FilmD:ViewComponent
    {
        private IFilmService _filmService;
        private IMapper _mapper;
        public FilmD(IFilmService filmService, IMapper mapper)
        {
            _filmService = filmService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke(int id)
        {
            

            return View(_mapper.Map<FilmListAddUpdateDto>(_filmService.Getbyid(id)));
        }

    }
}
