using System;
using System.Collections.Generic;
using System.Text;

namespace eSchool.Application
{
    public class Result
    {
        public Result()
        {
           Success = true;
        }
        public Result(string msg)
        {
            Message = msg;
            Success=string.IsNullOrEmpty(msg)?false:true;
        }
        public string Message { get; private set; }
        public bool Success { get; private set; }
    }
}
