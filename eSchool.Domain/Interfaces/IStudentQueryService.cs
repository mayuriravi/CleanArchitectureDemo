
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eSchool.Domain
{
    public interface IStudentQueryService
    {
        Task<List<StudentsListViewModel>> GetStudents(StudentsListFilter filter);
    }
}