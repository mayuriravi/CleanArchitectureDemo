using eSchool.Domain;

namespace eSchool.Persistence.EntityFramework
{
    public class ServiceProxy :IServiceProxy
    {
        public ICourseService CourseService { get; }
        public IStudentService StudentService { get; }
        public IUnitOfWork UnitOfWork { get; }
        public ServiceProxy(eSchoolSqlDbContext context)
        {
            this.CourseService = new CourseService(context);
            this.StudentService = new StudentService(context);
            this.UnitOfWork = new UnitOfWork(context);
        }
    }
}
