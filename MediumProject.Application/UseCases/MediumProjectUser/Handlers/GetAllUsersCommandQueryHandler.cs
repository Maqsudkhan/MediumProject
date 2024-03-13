using MediatR;
using MediumProject.Application.Abstraction;
using MediumProject.Application.UseCases.MediumProjectUser.Queries;
using MediumProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProject.Application.UseCases.MediumProjectUser.Handlers
{
    public class GetAllUsersCommandQueryHandler : IRequestHandler<GetAllUsersCommandQuery, List<User>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllUsersCommandQueryHandler(IApplicationDbContext context )
        {
            _context = context;
        }

        public async Task<List<User>> Handle(GetAllUsersCommandQuery request, CancellationToken cancellationToken)
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }
    }
}
