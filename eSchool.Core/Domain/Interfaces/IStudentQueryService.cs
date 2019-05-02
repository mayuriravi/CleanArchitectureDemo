using eSchool.Core.UseCases;
using eSchool.Core.UseCases.GetStudents;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eSchool.Core.Domain
{
    public interface IStudentQueryService
    {
        Task<List<StudentsListViewModel>> GetStudents(GetStudentsListQuery query);
    }
}