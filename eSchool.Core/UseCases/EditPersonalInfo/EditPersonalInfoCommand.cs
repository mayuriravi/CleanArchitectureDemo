

using eSchool.Core.Domain;
using eSchool.Core.UseCases;
using MediatR;

namespace eSchool.Core.UseCases
{
    public class EditPersonalInfoCommand : IRequest<Result>
    {
        public int Id { get; }
        public string Name { get; }
        public string Email { get; }
    }
}
