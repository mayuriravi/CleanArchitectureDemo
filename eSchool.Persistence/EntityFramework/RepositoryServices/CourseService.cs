
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using eSchool.Domain;
using AutoMapper;

namespace eSchool.Persistence.EntityFramework
{
    public class CourseService : ICourseRepository
    {
        //TODO: add async get calls
        private readonly eSchoolSqlDbContext dbContext;

        public CourseService(eSchoolSqlDbContext context) 
        {
            dbContext = context;
        }
        public async Task<Course> GetByName(string name)
        {
            return await dbContext.Courses.SingleOrDefaultAsync(m => m.Name == name);
            //return Mapper.Map<CourseEntity, Course>(data);
        }
       
    }
}
