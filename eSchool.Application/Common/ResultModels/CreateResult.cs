
using System;
using System.Collections.Generic;
using System.Text;

namespace eSchool.Application
{
    public class CreateResult:Result
    {
        public CreateResult() :base()
        { }
        public CreateResult(string msg):base(msg)
        { }
        public int NewId { get; set; }
    }
}
