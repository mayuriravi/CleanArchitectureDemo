
using eSchool.Core.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eSchool.Core.Domain
{
    public interface ICourseService 
    {
        Task<Course> GetByName(string name);

    }
}
