

using CleanArchitectureDemo.Core.Interfaces;
using MediatR;
using System.Threading;

namespace eSchool.Core.UseCases.Unregister
{
    public class UnregisterCommand : IRequest<Unit>
    {
        public long Id { get; set; }
    }

    
}
