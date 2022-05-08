using AcademicSystem.Domain.Aggregates;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Application.Departaments.Command
{
    public class CreateUpdateDepartamentCommand : IRequest<Departament>
    {
        public string DepartamentName { get; set; }
    }
}
