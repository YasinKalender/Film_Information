using Film_Information.Dto.Dtos.CategoryDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Film_Information.Business.FluentValidation
{
    public class CategoryListUpdateAddValidation:AbstractValidator<CategoryListUpdateAddDto>
    {

        public CategoryListUpdateAddValidation()
        {
            RuleFor(i => i.CategoryName).NotNull().WithMessage("Bu alan boş geçilemez");
            RuleFor(i => i.CategoryDetails).NotNull().WithMessage("Detay alanı boş geçilemez");
        }
    }
}
