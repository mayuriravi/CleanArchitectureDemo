
using eSchool.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eSchool.Application
{
    public sealed class DisenrollRequest : IRequest<Result>
    {
        public int Id { get; set; }
        public int EnrollmentNumber { get; set; }
        public string Comment { get; set; }
    }

    
}
