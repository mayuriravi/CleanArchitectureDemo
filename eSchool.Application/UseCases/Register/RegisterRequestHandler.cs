using System;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using eSchool.Domain;
using MediatR;
namespace eSchool.Application
{
    //[AuditLog]
    public class RegisterRequestHandler : IRequestHandler<RegisterRequest, CreateResult>
    {
        IUnitOfWork serviceProxy;
        public RegisterRequestHandler(IUnitOfWork serviceProxy)
        {
            this.serviceProxy = serviceProxy;
        }

        public async Task<CreateResult> Handle(RegisterRequest command, CancellationToken cancellationToken)
        {
            if (command.CourseList.Count < 1)
                throw new CourseNotSelectedException();
            var student = new Student(command.Name, command.Email,command.StudentCode);
            foreach (string course in command.CourseList)
            {
                if (!string.IsNullOrEmpty(course))
                {
                    Course c = await serviceProxy.CourseService.GetByName(course);
                    student.Enroll(c);
                }
            }

            var data = await serviceProxy.StudentService.Add(student);

            await serviceProxy.Commit();

            return new CreateResult { NewId = data };
        }
    }
}

