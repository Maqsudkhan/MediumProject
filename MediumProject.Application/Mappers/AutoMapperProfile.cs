using AutoMapper;
using MediumProject.Application.UseCases.MediumProjectUser.Commands;
using MediumProject.Domain.DTOs;
using MediumProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumProject.Application.Mappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, CreateUserCommand>().ReverseMap();
        }
    }
}
