using eSchool.Application.Exceptions;
using eSchool.Domain;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace eSchool.Application
{
    public class UnregisterRequestHandler : IRequestHandler<UnregisterRequest, Result>
    {
        IUnitOfWork serviceProxy;
        ILogger logger;
        public UnregisterRequestHandler(IUnitOfWork serviceProxy, ILogger logger)
        {
            this.logger = logger;
            this.serviceProxy = serviceProxy;
        }

        public async Task<Result> Handle(UnregisterRequest command,CancellationToken cancellationtoken)
        {
            try
            {
                Student student = await this.serviceProxy.StudentService.GetById(command.Id);
                if (student == null)
                    throw new StudentNotFoundException($"No student found for Id {command.Id}");

                this.serviceProxy.StudentService.Delete(student);
                await this.serviceProxy.Commit();

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
