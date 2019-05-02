using eSchool.Persistence.Dapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eSchool.Core.UseCases.GetStudents
{
    public class GetStudentsListQueryHandler : IRequestHandler<GetStudentsListQuery, List<StudentsListViewModel>>
    {
             private readonly IStudentQueryService qSvc;

            public GetStudentsListQueryHandler(IStudentQueryService svc)
            {
            qSvc = svc;
            }

            public async Task<List<StudentsListViewModel>> Handle(GetStudentsListQuery query, CancellationToken cancellationToken)
            {
            return await qSvc.GetStudents(query);
            }
        }
    }
