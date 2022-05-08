using AcademicSystem.Application.Departaments.Queries;
using AcademicSystem.Domain.Aggregates;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Application.Departaments.QueriesHandlers
{
    public class GetAllDepartamentQueryCommand : IRequestHandler<GetAllDepartamentQuery, Departament>
    {
        public Task<Departament> Handle(GetAllDepartamentQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
