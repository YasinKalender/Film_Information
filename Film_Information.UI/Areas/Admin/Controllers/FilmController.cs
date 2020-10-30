using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Film_Information.Business.Abstract;
using Film_Information.Dto.Dtos.FilmDto;
using Film_Information.Entities.ORM.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Film_Information.UI.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class FilmController : Controller
    {

        private readonly IFilmService _filmService;
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;

        public FilmController(IFilmService filmService, IMapper mapper, ICategoryService categoryService)
        {
            _filmService = filmService;
            _mapper = mapper;
            _categoryService = categoryService;
        }

        public  IActionResult Index()
        {
        

            return View(_mapper.Map<List<FilmListAddUpdateDto>>(_filmService.WithCategory()));
        }

        public IActionResult FilmAdd()
        {
            List<SelectListItem> category = _categoryService.GetAll().Select(i => new SelectListItem() { Text = i.CategoryName, Value = i.ID.ToString() }).ToList();

            ViewBag.category = category;

            ViewBag.categories = new SelectList(_categoryService.GetAll(), "ID","CategoryName");

            

            return View();
        }


        [ValidateAntiForgeryToken,HttpPost]
        public async Task<IActionResult> FilmAdd(FilmListAddUpdateDto model,IFormFile image)
        {
       


            if (ModelState.IsValid)
            {

                if (image != null)
                {
                    var images = Path.GetExtension(image.FileName);
                    string guid = Guid.NewGuid() + images;
                    var addimages = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/image/" + guid);

                    using (var stream = new FileStream(addimages, FileMode.Create))
                    {

                        await image.CopyToAsync(stream);
                    }

                    _filmService.Add(new Film()
                    {
                        CategoryID = model.CategoryID,
                        FilmName = model.FilmName,
                        FilmDescription = model.FilmDescription,
                        Image = guid



                    });


                }

               

                return RedirectToAction("Index");

            }
            ViewBag.categories = new SelectList(_categoryService.GetAll(), "ID", "CategoryName");


            return View(model);
        }

        public IActionResult FilmUpdate(int id)
        {
            ViewBag.category = new SelectList(_categoryService.GetAll(), "ID", "CategoryName", "ID");

         ;



            return View(_mapper.Map<FilmListAddUpdateDto>(_filmService.Getbyid(id)));
        }

        [HttpPost]
        public async Task<IActionResult> FilmUpdate(FilmListAddUpdateDto films,IFormFile Image)
        {
           

            if (ModelState.IsValid)
            {
                if (Image==null)
                {
                    

                    _filmService.Update(new Film()
                    {
                        ID = films.ID,
                        CategoryID = films.CategoryID,
                        FilmName = films.FilmName,
                        FilmDescription = films.FilmDescription,
                        Image = films.Image


                    });

                    return RedirectToAction("Index");

                }

                if (Image != null)
                {
                    var path = Path.GetFileName(Image.FileName);
                    var guid = Guid.NewGuid() + path;
                    var image = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/image/" + guid);

                    using (var stream = new FileStream(image, FileMode.Create))
                    {

                        await Image.CopyToAsync(stream);

                    }

                    _filmService.Update(new Film()
                    {
                        ID = films.ID,
                        CategoryID = films.CategoryID,
                        FilmName = films.FilmName,
                        FilmDescription = films.FilmDescription,
                        Image = guid


                    });



                }


                return RedirectToAction("Index");







            }

            return View(films);
        }
    }
}
