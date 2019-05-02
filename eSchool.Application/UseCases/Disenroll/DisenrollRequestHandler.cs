
using eSchool.Domain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System;
using eSchool.Application.Exceptions;

namespace eSchool.Application
{
    internal sealed class DisenrollRequestHandler : IRequestHandler<DisenrollRequest, Result>
    {
        IUnitOfWork serviceProxy;
        private readonly ILogger logger;

        public DisenrollRequestHandler(IUnitOfWork serviceProxy, ILogger logger)
        {
            this.serviceProxy = serviceProxy;
            this.logger = logger;
        }

        public async Task<Result> Handle(DisenrollRequest command, CancellationToken cancellationToken)
        {
            try
            {
                Student student = await serviceProxy.StudentService.GetById(command.Id);
                if (student == null)
                   throw new StudentNotFoundException($"No student found for Id {command.Id}");

                if (string.IsNullOrWhiteSpace(command.Comment))
                    throw new DisenrollmentCommentRequiredException();

                Enrollment enrollment = student.GetEnrollment(command.EnrollmentNumber);
                if (enrollment == null)
                    throw new EnrollmentNotFoundException($"No enrollment found with number '{command.EnrollmentNumber}'");

                student.Disenroll(enrollment, command.Comment);

                await serviceProxy.Commit();

                return new Result();
            }
            catch(Exception ex)
            {
                logger.LogError(ex,ex.Message);
                return new Result(ex.Message);                
            }
        }
    }
}