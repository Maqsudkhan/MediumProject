using MediatR;
using MediumProject.Application.UseCases.MediumProjectUser.Commands;
using MediumProject.Application.UseCases.MediumProjectUser.Queries;
using MediumProject.Domain.DTOs;
using MediumProject.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediumProject.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController(IMediator _mediator) : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommand command)
        {
            await _mediator.Send(command);

            return Ok("Malumot yaratildi✅");
        }


        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            var result = await _mediator.Send(new GetAllUsersCommandQuery());

            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<User>> GetByIdUsers(Guid Id)
        {
            var result = await _mediator.Send(new GetByIdCommandQuery()
            {
                Id = Id
            });

            return Ok(result);
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteUserById(Guid Id)
        {
            await _mediator.Send(new DeleteUserCommand()
            {
                Id = Id
            });

            return Ok("Ma'lumot o'chirildi✅");
        }

        [HttpPut]
        public async Task<ActionResult<User>> UpdateUser (UpdateUserCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result );
        }
    }
}
 