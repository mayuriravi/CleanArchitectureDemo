using eSchool.Application.Exceptions;
using eSchool.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eSchool.Application
{

    public class EnrollRequestHandler : IRequestHandler<EnrollRequest, Result>
    {
        IUnitOfWork serviceProxy;
        public EnrollRequestHandler(IUnitOfWork serviceProxy)
        {
            this.serviceProxy = serviceProxy;
        }

        public async Task<Result> Handle(EnrollRequest command, CancellationToken cancellationToken)
        {
          
            var student = await serviceProxy.StudentService.GetById(command.Id);
            if (student == null)
                throw new StudentNotFoundException($"No student found with Id '{command.Id}'");

            var course = await serviceProxy.CourseService.GetByName(command.Course);
            if (course == null)
               throw new CourseIsIncorrectException($"Course is incorrect: '{command.Course}'");

            student.Enroll(course);

            await this.serviceProxy.Commit();
            return new Result();
        }
    }
}
