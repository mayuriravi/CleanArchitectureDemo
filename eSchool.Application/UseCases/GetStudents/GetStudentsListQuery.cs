
using eSchool.Domain;

using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace eSchool.Application
{
    public class GetStudentsListQuery: StudentsListFilter, IRequest<ListResult<StudentsListViewModel>>
    {
    }
}
