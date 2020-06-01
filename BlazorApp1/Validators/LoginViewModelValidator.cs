using BlazorApp1.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Validators
{
    public class LoginViewModelValidator : AbstractValidator<LoginViewModel>
    {
        public LoginViewModelValidator()
        {
            RuleFor(m => m.Email).NotEmpty().WithMessage("This field is required!");
            RuleFor(m => m.Password).NotEmpty().WithMessage("This field is required!");
        }
    }
}
