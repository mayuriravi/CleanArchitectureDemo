using eSchool.Core.Domain;
using eSchool.Core.Domain.Interfaces;
using eSchool.Core.UseCases;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace eSchool.Core.UseCases
{
    internal sealed class DisenrollCommandHandler : IRequestHandler<DisenrollCommand, Result>
    {
        IServiceProxy serviceProxy;


        public DisenrollCommandHandler(IServiceProxy serviceProxy)
        {
            this.serviceProxy = serviceProxy;
        }

        public async Task<Result> Handle(DisenrollCommand command, CancellationToken cancellationToken)
        {
            Student student = await serviceProxy.StudentService.GetById(command.Id);
            if (student == null)
                return new Result($"No student found for Id {command.Id}");


            if (string.IsNullOrWhiteSpace(command.Comment))
                return new Result("Disenrollment comment is required");

            Enrollment enrollment = student.GetEnrollment(command.EnrollmentNumber);
            if (enrollment == null)
                return new Result($"No enrollment found with number '{command.EnrollmentNumber}'");

            student.RemoveEnrollment(enrollment, command.Comment);

            await serviceProxy.UnitOfWork.Commit();

            return new Result();
        }
    }
}