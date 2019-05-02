using eSchool.Domain;
using MediatR;

namespace eSchool.Application
{
    public class EnrollRequest : IRequest<Result>
    {
        public int Id { get; }
        public string Course { get; }
        public string Grade { get; }

    }

    }
