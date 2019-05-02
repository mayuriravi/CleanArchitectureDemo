using System;
using System.Collections.Generic;
using System.Text;

namespace eSchool.Core.Domain.Interfaces
{
    public interface IServiceProxy
    {
        ICourseService CourseService { get; }
        IStudentService StudentService { get; }
        IUnitOfWork UnitOfWork { get; }
    }
}
