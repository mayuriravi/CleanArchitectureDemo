using System.Collections.Generic;
using System.Threading.Tasks;

namespace eSchool.Domain
{
    public interface IStudentRepository: IRepository<Student>
    {
        Task<Student> GetById(int id) ;
        Task<List<Student>> GetAll() ;
        void Update(Student entity);
        void Delete(Student entity);
        Task<int> Add(Student entity);
    }
}
