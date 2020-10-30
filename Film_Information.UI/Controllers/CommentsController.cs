using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Film_Information.Business.Abstract;
using Film_Information.Dto.Dtos.CommentsDto;
using Film_Information.Dto.Dtos.FilmDto;
using Film_Information.Entities.ORM.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Film_Information.UI.Controllers
{

  
    public class CommentsController : Controller
    {

        private ICommentService _commentService;
        private IFilmService _filmService;
        private IMapper _mapper;
        private UserManager<AppUser> _userManager;


        public CommentsController(ICommentService commentService, IFilmService filmService, IMapper mapper, UserManager<AppUser> userManager)
        {
            _commentService = commentService;
            _filmService = filmService;
            _mapper = mapper;
            _userManager = userManager;
        }

       [AllowAnonymous]
        public async Task<IActionResult> CommentsAdd(int id)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.user = user.FirstName;
            ViewBag.Luser = user.LastName;

            return View(_mapper.Map<FilmCommentDto>(_filmService.AllFilms(id)));
        }


        [HttpPost]
        public async Task<IActionResult> CommentsAdd(FilmCommentDto model)
        {

            var fillms = _filmService.Getbyid(model.ID);
          

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                _commentService.Add(new Entities.ORM.Entities.Concrete.Comments()
                {

                 
                    FilmID=model.ID,
                    FirstName = user.FirstName,
                    LastName=user.LastName,
                    Email = model.Email,
                    Comment = model.Comment,
                    AppUserID=user.Id
                    
                  
                    

                });

                return RedirectToAction("CommentsAdd");


            }


            return View(model);
        }
    }
}
