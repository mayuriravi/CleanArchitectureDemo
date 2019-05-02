using System;
using System.Collections.Generic;
using System.Text;

namespace eSchool.Domain
{
   
        public interface IRepository<T> where T : IAggregateRoot
        {
          
        }
    
}
