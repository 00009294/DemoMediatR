using MediatR.Core.Commands;
using MediatR.Core.Models;
using MediatR.Core.Queries;
using Microsoft.AspNetCore.Mvc;

namespace MediatR.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator mediator;

        public UserController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]
        public async Task<List<User>> Get()
        {
            return await this.mediator.Send(new GetAllUserQuery());
        }

        [HttpGet("{id}")]
        public async Task<User> Get(int id)
        {
            return await this.mediator.Send(new GetByIdQuery(id));
        }

        [HttpPost]
        public async Task<bool> Post([FromBody] User user)
        {
            return await this.mediator.Send(new CreateUserCommand(user.FirstName, user.LastName));
        }

        [HttpPut("{id}")]
        public async Task<bool> Put([FromBody] User user)
        {
            return await this.mediator.Send(new UpdateUserCommand(user.Id,user.FirstName, user.LastName));
        }

        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await this.mediator.Send(new DeleteUserCommand(id));
        }
    }
}
