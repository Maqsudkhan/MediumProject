using MediatR;
using MediumProject.Domain.DTOs;
using MediumProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProject.Application.UseCases.MediumProjectUser.Commands
{
    public class UpdateUserCommand : UserDTO, IRequest<User>
    {
        public Guid Id { get; set; }    
    }
}
