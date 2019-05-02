using System;
using System.Collections.Generic;
using System.Text;

namespace eSchool.Application.Exceptions
{
    public class CourseIsIncorrectException: ApplicationException
    {
        public CourseIsIncorrectException(string msg):base(msg)
        {

        }
    }
}
