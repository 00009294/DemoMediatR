using MediatR.Core.Commands;
using MediatR.Core.Repositories;

namespace MediatR.Core.Handlers
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, bool>
    {
        private readonly IUserRepository userRepository;

        public DeleteUserHandler(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(this.userRepository.Delete(request.Id));
        }
    }
}
