using System;
using System.Collections.Generic;
using System.Text;

namespace eSchool.Application.Exceptions
{
    public class ApplicationException:Exception
    {
        public ApplicationException(string msg):base(msg)
        {

        }
    }
}
