using eSchool.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace eSchool.Domain
{
    public class CourseNotSelectedException: DomainException
    {
        public CourseNotSelectedException() : base($"Course Not selected")
        {

        }
       
    }
}
