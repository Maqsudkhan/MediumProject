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
    public class GetByIdCommandQueryHandler : IRequestHandler<GetByIdCommandQuery, User>
    {
        private readonly IApplicationDbContext _context;

        public GetByIdCommandQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User> Handle(GetByIdCommandQuery request, CancellationToken cancellationToken)
        {
            var users  = await _context.Users.FirstOrDefaultAsync(x => x.Id == request.Id && x.IsDeleted != true);
            return users;
        }
    }
}   
