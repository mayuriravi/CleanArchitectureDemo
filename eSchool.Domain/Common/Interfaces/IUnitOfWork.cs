using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eSchool.Domain
{
    public interface IUnitOfWork
    {
        ICourseRepository CourseService { get; }
        IStudentRepository StudentService { get; }
        Task<int> Commit();
    }
}
