using CleanArchitectureDemo.Core.Interfaces;
using eSchool.Core.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eSchool.Core.UseCases.Unregister
{
    public class UnregisterCommandHandler : IRequestHandler<UnregisterCommand, Unit>
    {
        public UnregisterCommandHandler(IStudentService studentSvc, ICourseService courseSvc)
        {

        }

        public async Task<Unit> Handle(UnregisterCommand command,CancellationToken cancellationtoken)
        {
            //var unitOfWork = new UnitOfWork(_sessionFactory);
            //var repository = new StudentRepository(unitOfWork);
            //Student student = repository.GetById(command.Id);
           // if (student == null)
             //   return new Result($"No student found for Id {command.Id}");

            //repository.Delete(student);
            //unitOfWork.Commit();

            return  Unit.Value;
        }
    }
}
