using System.Collections.Generic;
using System.Threading.Tasks;

namespace eSchool.Core.Domain
{
    public interface IStudentService 
    {
        Task<Student> GetById(int id) ;
        Task<List<Student>> GetAll() ;
        void Update(Student entity);
        void Delete(Student entity);
        Task<int> Add(Student entity);
    }
}
