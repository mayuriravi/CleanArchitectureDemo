

using System.Collections.Generic;
using System.Linq;

namespace eSchool.Domain
{

    public  class Course :Entity, IAggregateRoot
    {
        public Course()
        { }
        public Course(string name, int credits)
        {
            this.Name = name;
            this.Credits = credits;
        }
        public string Name { get; protected set; }
        public int Credits { get; protected set; }

       
    }
}
