using eSchool.Domain;
using MediatR;
using System.Threading;

namespace eSchool.Application
{
    public class UnregisterRequest : IRequest<Result>
    {
        public int Id { get; set; }
    }

    
}
