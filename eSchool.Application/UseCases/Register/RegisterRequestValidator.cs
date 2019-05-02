using eSchool.Domain;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace eSchool.Application.Register
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(v => v.Name).NotEmpty().Length(50);
            RuleFor(v => v.Email).NotEmpty().Length(50);
            RuleFor(v => v.StudentCode).NotEmpty().Length(10);
        }
    }
}
