
using System;
using System.Collections.Generic;
using System.Text;

namespace eSchool.Domain.Exceptions
{
    public class InvalidStudentCodeException : DomainException
    {
        public InvalidStudentCodeException(string msg, Exception ex):base(msg,ex)
            {}
    }
}
