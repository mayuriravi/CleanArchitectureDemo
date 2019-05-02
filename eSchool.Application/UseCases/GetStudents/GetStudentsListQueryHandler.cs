using eSchool.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eSchool.Application
{
    public class GetStudentsListQueryHandler : IRequestHandler<GetStudentsListQuery, ListResult<StudentsListViewModel>>
    {
             private readonly IStudentQueryService qSvc;

            public GetStudentsListQueryHandler(IStudentQueryService svc)
            {
            qSvc = svc;
            }

            public async Task<ListResult<StudentsListViewModel>> Handle(GetStudentsListQuery query, CancellationToken cancellationToken)
            {
            var data= await qSvc.GetStudents(query);
            return new ListResult<StudentsListViewModel> { Items = data };
            }
        }
    }
