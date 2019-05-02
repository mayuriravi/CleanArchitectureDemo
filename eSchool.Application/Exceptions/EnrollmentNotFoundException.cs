using System;
using System.Collections.Generic;
using System.Text;

namespace eSchool.Application.Exceptions
{
    public class EnrollmentNotFoundException : ApplicationException
    {
        public EnrollmentNotFoundException(string msg) : base(msg)
            {}
    }
}
