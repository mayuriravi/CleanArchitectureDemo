using eSchool.Application.Exceptions;
using eSchool.Domain;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace eSchool.Application
{
    public class EditPersonalInfoRequestHandler : IRequestHandler<EditPersonalInfoRequest, Result>
    {

        IUnitOfWork serviceProxy;
        ILogger logger;
        public EditPersonalInfoRequestHandler(IUnitOfWork serviceProxy, ILogger logger)
        {
            this.serviceProxy = serviceProxy;
            this.logger = logger;
        }

        public async Task<Result> Handle(EditPersonalInfoRequest command, CancellationToken cancellationToken)
        {
            try
            {
                Student student = await serviceProxy.StudentService.GetById(command.Id);

                if (student == null)
                    throw new StudentNotFoundException($"No student found for Id {command.Id}");
                student.UpdateInfo(command.Name, command.Name);
                await serviceProxy.Commit();

                return new Result();
            }
            catch(Exception ex)
            {
                logger.LogError(ex, ex.Message);
                return new Result(ex.Message);
            }
        }
    }
}
