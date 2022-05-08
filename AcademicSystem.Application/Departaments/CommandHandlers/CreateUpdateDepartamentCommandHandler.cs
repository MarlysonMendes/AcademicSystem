using AcademicSystem.Application.Departaments.Command;
using AcademicSystem.Domain.Aggregates;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Application.Departaments.CommandHandlers
{
    public class CreateUpdateDepartamentCommandHandler : IRequestHandler<CreateUpdateDepartamentCommand, Departament>
    {
        public Task<Departament> Handle(CreateUpdateDepartamentCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
