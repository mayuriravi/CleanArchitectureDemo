using eSchool.Core.UseCases.GetStudents;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace eSchool.Core.UseCases
{
    public class GetStudentsListQuery:IRequest<List<StudentsListViewModel>>
    {
        public string EnrolledIn { get; }
        public int? NumberOfCourses { get; }
    }
}
