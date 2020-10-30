using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Film_Information.Business.Abstract;
using Film_Information.Dto.Dtos.CategoryDto;
using Film_Information.Entities.ORM.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Film_Information.UI.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class CategoryController : Controller
    {

        private ICategoryService _categoryService;
        private IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {



            return View(_mapper.Map<List<CategoryListUpdateAddDto>>(_categoryService.GetAll()));
        }

        public IActionResult CategoryAdd()
        {


            return View();
        }


        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult CategoryAdd(CategoryListUpdateAddDto model)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Add(new Category() {
                
                    CategoryName=model.CategoryName,
                    CategoryDetails=model.CategoryDetails
                
                
                });

                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult CategoryUpdate(int id)
        {
            

            return View(_mapper.Map<CategoryListUpdateAddDto>(_categoryService.Getbyid(id)));
        }


        [ValidateAntiForgeryToken,HttpPost]
        public IActionResult CategoryUpdate(CategoryListUpdateAddDto model)
        {
            if (ModelState.IsValid)
            {

                _categoryService.Update(new Category()
                {
                    ID=model.ID,
                    CategoryName=model.CategoryName,
                    CategoryDetails=model.CategoryDetails


                });

                return RedirectToAction("Index");


            }


            return View(model);
        }
    }
}
