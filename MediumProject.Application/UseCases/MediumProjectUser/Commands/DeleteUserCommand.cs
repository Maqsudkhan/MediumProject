using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProject.Application.UseCases.MediumProjectUser.Commands
{
    public class DeleteUserCommand : IRequest
    {
        public Guid Id { get; set; }    
    }
}
