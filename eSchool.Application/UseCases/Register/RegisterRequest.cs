using eSchool.Domain;
using MediatR;
using System.Collections.Generic;

namespace eSchool.Application
{
    public sealed class RegisterRequest : IRequest<CreateResult>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string StudentCode { get; set; }
        public List<string> CourseList { get; set; }

    }

        
}