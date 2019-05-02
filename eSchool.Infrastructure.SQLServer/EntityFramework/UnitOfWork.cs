using eSchool.Domain;
using eSchool.Persistence.Dapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eSchool.Persistence.EntityFramework
{
    public class UnitOfWork :IUnitOfWork
    {
        eSchoolSqlDbContext context;
        public ICourseRepository CourseService { get; }
        public IStudentRepository StudentService { get; }
       
        public UnitOfWork(eSchoolSqlDbContext context)
        {
            this.context = context;
            this.CourseService = new CourseService(context);
            this.StudentService = new StudentService(context);
           
        }
        public async Task<int> Commit()
        {
          var result=  await this.context.SaveChangesAsync();
            return result;
        }
    }
}
