
using System.Threading.Tasks;

namespace eSchool.Domain
{
    public interface ICourseRepository :IRepository<Course>
    {
        Task<Course> GetByName(string name);

    }
}
