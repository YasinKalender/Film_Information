using Film_Information.Dto.Dtos.AppUserDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Film_Information.Business.FluentValidation
{
    public class AppUserRegisterValidation:AbstractValidator<AppUserRegister>
    {

        public AppUserRegisterValidation()
        {
            RuleFor(i => i.FirstName).NotNull().WithMessage("İsim alanı zorunludur");
            RuleFor(i => i.Username).NotNull().WithMessage("Kullanıcı adı alanı zorunludur");
            RuleFor(i => i.Password).NotNull().WithMessage("Parola alanı zorunludur");
            RuleFor(i => i.Email).NotNull().WithMessage("Email alanı zorunludur").EmailAddress().WithMessage("Lütfen geçerli email adresi giriniz");
        }
    }
}
