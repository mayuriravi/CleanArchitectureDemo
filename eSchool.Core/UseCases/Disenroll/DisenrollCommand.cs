using CleanArchitectureDemo.Core.Interfaces;
using eSchool.Core.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eSchool.Core.UseCases
{
    public sealed class DisenrollCommand : IRequest<Result>
    {
        public int Id { get; set; }
        public int EnrollmentNumber { get; set; }
        public string Comment { get; set; }
    }

    
}
