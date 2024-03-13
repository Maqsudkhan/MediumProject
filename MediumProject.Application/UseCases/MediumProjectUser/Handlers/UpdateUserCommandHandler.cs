using AutoMapper;
using MediatR;
using MediumProject.Application.Abstraction;
using MediumProject.Application.UseCases.MediumProjectUser.Commands;
using MediumProject.Domain.DTOs;
using MediumProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProject.Application.UseCases.MediumProjectUser.Handlers
{
    public class UpdateUserCommandHandler(IApplicationDbContext _dbContext) : IRequestHandler<UpdateUserCommand, User>
    {
        public async Task<User> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == request.Id && x.IsDeleted != true);
            if (user is not null)
            {
                user.ModifiedDate = DateTime.UtcNow;
                user.Name = request.Name;
                user.Email = request.Email;
                user.UserName = request.UserName;
                user.Bio =  request.Bio;
                user.PhotoPath = request.PhotoPath;
                user.FollowersCount =   request.FollowersCount;
                user.Login = request.Login;
                user.PasswordHash = request.PasswordHash;


                /*var data = _mapper.Map<User>(request);
                _dbContext.Users.Update(data);*/
                await _dbContext.SaveChangesAsync(cancellationToken);
                return user;
            }
            return null;
        }
    }
}
