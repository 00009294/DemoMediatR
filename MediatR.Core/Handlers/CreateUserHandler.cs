using MediatR.Core.Commands;
using MediatR.Core.Models;
using MediatR.Core.Repositories;

namespace MediatR.Core.Handlers
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, bool>
    {
        private readonly IUserRepository userRepository;

        public CreateUserHandler(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            User user = new User()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
            };
            var output = this.userRepository.Create(user);

            return Task.FromResult(output);
        }
    }
}
