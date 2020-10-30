using Film_Information.Dto.Dtos.FilmDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Film_Information.Business.FluentValidation
{
    public class FilmListAddUpdateValidation:AbstractValidator<FilmListAddUpdateDto>
    {
        public FilmListAddUpdateValidation()
        {
            RuleFor(i => i.FilmName).NotNull().WithMessage("Film alanı boş geçilemez");
            RuleFor(i=>i.FilmDescription).NotNull().WithMessage("Film açıklama alanı boş geçilemez");
            RuleFor(i => i.CategoryID).ExclusiveBetween(1, int.MaxValue).WithMessage("Kategori Alanı seçiniz");
            
        }

    }
}
