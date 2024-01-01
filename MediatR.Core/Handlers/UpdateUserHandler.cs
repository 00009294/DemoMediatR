using MediatR.Core.Commands;
using MediatR.Core.Models;
using MediatR.Core.Queries;
using MediatR.Core.Repositories;

namespace MediatR.Core.Handlers
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, bool>
    {
        private readonly IUserRepository userRepository;

        public UpdateUserHandler(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public Task<bool> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            User user = new User
            {
                Id = request.Id,
                FirstName = request.FirstName,
                LastName = request.LastName
            };
            return Task.FromResult(this.userRepository.Update(user));
        }
    }
}
