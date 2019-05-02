using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace eSchool.Application.Disenroll
{
    public class DisenrollRequestValidator: AbstractValidator<DisenrollRequest>
    {
        public DisenrollRequestValidator()
        {
            RuleFor(x => x.Comment).MaximumLength(150).NotEmpty();
            RuleFor(x => x.EnrollmentNumber).NotEmpty();
            RuleFor(x => x.Id).NotEmpty();          
        }
        
    }
}
