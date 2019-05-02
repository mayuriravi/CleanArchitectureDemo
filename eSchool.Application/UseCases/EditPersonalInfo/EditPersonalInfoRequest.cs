using eSchool.Domain;
using MediatR;

namespace eSchool.Application
{
    public class EditPersonalInfoRequest : IRequest<Result>
    {
        public int Id { get; }
        public string Name { get; }
        public string Email { get; }
       
    }
}
