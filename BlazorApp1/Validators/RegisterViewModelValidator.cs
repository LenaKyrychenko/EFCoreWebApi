using BlazorApp1.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Validators
{
    public class RegisterViewModelValidator : AbstractValidator<RegisterViewModel>
    {
        public RegisterViewModelValidator()
        {
            RuleFor(m => m.Name).NotEmpty().WithMessage("This field is required!");
            RuleFor(m => m.Surname).NotEmpty().WithMessage("This field is required!");
            RuleFor(m => m.Email).NotEmpty().WithMessage("This field is required!")
                .EmailAddress().WithMessage("Invalid email!");
            RuleFor(m => m.Password).NotEmpty().WithMessage("This field is required!")
                .MinimumLength(6).WithMessage("The password should be at least 6 characters long!");
            RuleFor(m => m.ConfirmPassword).NotEmpty().WithMessage("This field is required!")
                .Equal(m => m.Password).WithMessage("Password do not match!")
                .MinimumLength(6).WithMessage("The password should be at least 6 characters long!");
        }
    }
}
