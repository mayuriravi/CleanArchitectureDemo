using System;
using System.Threading;
using System.Threading.Tasks;

using eSchool.Core.Domain;
using eSchool.Core.Domain.Interfaces;
using MediatR;
namespace eSchool.Core.UseCases
{
    //[AuditLog]
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, CreateResult>
    {
        IServiceProxy serviceProxy;
        public RegisterCommandHandler(IServiceProxy serviceProxy)
        {
            this.serviceProxy = serviceProxy;
        }
    
        public async Task<CreateResult> Handle(RegisterCommand command, CancellationToken cancellationToken)
        {
            try
            {
                var student = new Student(command.Name, command.Email);

                if (command.Course1 != null)
                {
                    Course course = await serviceProxy.CourseService.GetByName(command.Course1);
                    student.Enroll(course);
                }

                if (command.Course2 != null)
                {
                    Course course = await serviceProxy.CourseService.GetByName(command.Course2);
                    student.Enroll(course);
                }

                var data = await serviceProxy.StudentService.Add(student);

                await serviceProxy.UnitOfWork.Commit();

                return new CreateResult { NewId = data };
            }
            catch(Exception ex)
            {
                return new CreateResult(ex.Message);
            }
            
        }
    }
}

