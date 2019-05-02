using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace eSchool.Application.EditPersonalInfo
{
    public class EditPersonalInfoRequestValidator:AbstractValidator<EditPersonalInfoRequest>
    {
        public EditPersonalInfoRequestValidator()
        {
            RuleFor(v => v.Email).NotEmpty().Length(20);
            RuleFor(v => v.Name).NotEmpty().Length(20);
        }
    }
}
