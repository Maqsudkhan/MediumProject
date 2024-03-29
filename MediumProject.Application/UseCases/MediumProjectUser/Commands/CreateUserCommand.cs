﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProject.Application.UseCases.MediumProjectUser.Commands
{
    public class CreateUserCommand : IRequest
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public string PhotoPath { get; set; }
        public int FollowersCount { get; set; }
    }
}
