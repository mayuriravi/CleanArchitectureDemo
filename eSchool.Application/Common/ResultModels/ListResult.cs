using System;
using System.Collections.Generic;
using System.Text;

namespace eSchool.Application
{
    public class ListResult<T>:Result where T : class
    {
        public List<T> Items { get; set; }
    }
}
