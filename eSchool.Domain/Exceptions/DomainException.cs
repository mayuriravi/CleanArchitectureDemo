using System;
using System.Collections.Generic;
using System.Text;

namespace eSchool.Domain
{
    public class DomainException:Exception
    {
        public DomainException(string msg):base(msg)
        {

        }
        public DomainException(string msg,Exception ex) : base(msg,ex)
        {

        }
    }
}
