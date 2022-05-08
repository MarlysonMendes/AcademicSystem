using AcademicSystem.Domain.Aggregates;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Application.Departaments.Queries
{
    public class GetDepartamentByIdQuery : IRequest<Departament>
    {
        public Guid DepartamentId { get; set; }
    }
}
