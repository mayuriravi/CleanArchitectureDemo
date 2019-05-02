using System;
using System.Collections.Generic;
using System.Text;

namespace eSchool.Application.Exceptions
{
    public class StudentNotFoundException : ApplicationException
    {
        public StudentNotFoundException(string msg):base(msg)
            {}
    }
}
