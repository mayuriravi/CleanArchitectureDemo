using eSchool.Core.Domain;
using eSchool.Core.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace eSchool.Core.UseCases
{
    public class EditPersonalInfoCommandHandler : IRequestHandler<EditPersonalInfoCommand, Result>
    {
        //[AuditLog]
        //[DatabaseRetry]

        IServiceProxy serviceProxy;
        public EditPersonalInfoCommandHandler(IServiceProxy serviceProxy)
        {
            this.serviceProxy = serviceProxy;
        }

        public async Task<Result> Handle(EditPersonalInfoCommand command, CancellationToken cancellationToken)
        {
            Student student = await serviceProxy.StudentService.GetById(command.Id);

            if (student == null)
                return new Result($"No student found for Id {command.Id}");

            student.Name = command.Name;
            student.Email = command.Email;

            await serviceProxy.UnitOfWork.Commit();

            return new Result();
        }
    }
}
