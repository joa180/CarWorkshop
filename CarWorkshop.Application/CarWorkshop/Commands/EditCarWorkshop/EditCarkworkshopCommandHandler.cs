using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Application.CarWorkshop.Commands.EditCarWorkshop
{
    internal class EditCarkworkshopCommandHandler : IRequestHandler<EditCarkworkshopCommand>
    {
        public Task<Unit> Handle(EditCarkworkshopCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
