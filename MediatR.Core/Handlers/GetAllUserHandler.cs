using MediatR.Core.Models;
using MediatR.Core.Queries;
using MediatR.Core.Repositories;

namespace MediatR.Core.Handlers
{
    public class GetAllUserHandler : IRequestHandler<GetAllUserQuery, List<User>>
    {
        private readonly IUserRepository userRepository;

        public GetAllUserHandler(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public Task<List<User>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(this.userRepository.GellAll());
        }
    }
}
