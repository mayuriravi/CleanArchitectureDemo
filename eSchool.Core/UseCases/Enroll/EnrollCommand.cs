

using CleanArchitectureDemo.Core.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace eSchool.Core.UseCases
{
    public class EnrollCommand : IRequest<Result>
    {
        public int Id { get; }
        public string Course { get; }
        public string Grade { get; }

    }

        public class EnrollCommandHandler : IRequestHandler<EnrollCommand,Result>
        {
        IStudentService studentSvc;
        ICourseService courseSvc;
        public EnrollCommandHandler(IStudentService studentSvc, ICourseService courseSvc)
        {
            this.courseSvc = courseSvc;
            this.studentSvc = studentSvc;
        }

        public async Task<Result> Handle(EnrollCommand command, CancellationToken cancellationToken)
            {
                var unitOfWork = new UnitOfWork(_sessionFactory);
               
                var student = await studentSvc.GetById(command.Id);
                if (student == null)
                    return new Result($"No student found with Id '{command.Id}'");

                var course = await courseSvc.GetByName(command.Course);
                if (course == null)
                    return new Result($"Course is incorrect: '{command.Course}'");

                student.Enroll(course);

                await unitOfWork.Commit();

                return new Result();
            }
        }
    }
