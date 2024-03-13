using MediatR;
using MediumProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProject.Application.UseCases.MediumProjectUser.Queries
{
    public class GetAllUsersCommandQuery : IRequest<List<User>>
    {
    }
}
