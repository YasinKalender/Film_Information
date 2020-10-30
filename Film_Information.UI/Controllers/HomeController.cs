using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Film_Information.Business.Abstract;
using Film_Information.Dto.Dtos;
using Film_Information.Dto.Dtos.AppUserDto;
using Film_Information.Dto.Dtos.CategoryDto;
using Film_Information.Dto.Dtos.FilmDto;
using Film_Information.Entities.ORM.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NLog;

namespace Film_Information.UI.Controllers
{


    public class HomeController : Controller
    {
        private IMapper _mapper;
        private IFilmService _filmService;
        private ICategoryService _categoryService;
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;
        private INLog _nLog;

        public HomeController(IMapper mapper, IFilmService filmService, ICategoryService categoryService, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, INLog nLog)
        {
            _mapper = mapper;
            _filmService = filmService;
            _categoryService = categoryService;
            _userManager = userManager;
            _signInManager = signInManager;
            _nLog = nLog;
        }


        public IActionResult Index(int? id,string s)
        {

            ViewBag.s = s;
            HomeDto model = new HomeDto()
            {
                Categories = _mapper.Map<List<CategoryListUpdateAddDto>>(_categoryService.GetAll()),
                Films = _mapper.Map<List<FilmListAddUpdateDto>>(_filmService.GetAll(s)),
                FilmCount = _mapper.Map<List<FilmListAddUpdateDto>>(_filmService.CategoryAll(id)).Count(),
                LastFilms = _filmService.LastFilm(),
     

            };

           


        



            return View(model);
        }

        public IActionResult FilmDetails(int id)
        {

           

            return View(_mapper.Map<FilmListAddUpdateDto>(_filmService.Getbyid(id)));
        }


        public IActionResult CategoryFilm(int? id)
        {
            

            return View(_mapper.Map<List<FilmListAddUpdateDto>>(_filmService.CategoryAll(id)));
        }

        public IActionResult Register()
        {


            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(AppUserRegister model)
        {

            if (ModelState.IsValid)
            {

                AppUser appUser = new AppUser()
                {
                    FirstName=model.FirstName,
                    LastName=model.LastName,
                    UserName=model.Username,
                    Email=model.Email,


                };

                var result = await _userManager.CreateAsync(appUser, "1");

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(appUser, "Member");
                    return RedirectToAction("Index");
                }

                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

            }

            return View(model);
        }

        public IActionResult SignIn()
        {
         

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> SignIn(AppUserSignIn model)
        {
            var user = await _userManager.FindByNameAsync(model.Username);

            if (ModelState.IsValid)
            {
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }

                    else
                    {
                        ModelState.AddModelError("", "Kullanıcı adı veya şifre yanlış");
                    }
                }
            }

            return View(model);
        }

        public IActionResult UpdateUser(int id)
        {
            var user = _userManager.Users.FirstOrDefault(i => i.Id == id);

            AppUserUpdate model = new AppUserUpdate()
            {
                ID=user.Id,
                FirstName=user.FirstName,
                LastName=user.LastName,
                Email=user.Email,
                Username=user.UserName
                


            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser(AppUserUpdate model,IFormFile Image)
        {
            var user = _userManager.Users.FirstOrDefault(i => i.Id == model.ID);

            if (ModelState.IsValid)
            {

                user.Id = model.ID;
                user.UserName = model.Username;
                user.Email = model.Email;
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;


                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }

                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

            }

           
            return View(model);
        }

        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index");
        }

        public IActionResult StatusCode(int? code)
        {
            if (code==404)
            {
                ViewBag.mesaj = "Sayfa bulunamadı";
                ViewBag.hata = "Hata";
            }


            return View();
        }

        public IActionResult Error()
        {

            var exceptionHandlerPathFeature =HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            _nLog.Eror($"Hata yeri:{exceptionHandlerPathFeature.Path}, Hata mesajı:{exceptionHandlerPathFeature.Error.Message}");

            ViewBag.hata = exceptionHandlerPathFeature.Error;

            


            return View();
        }
        public IActionResult Hata()
        {



            throw new Exception("Hata Oluştu");


        }

    }
}
