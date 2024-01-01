using MediatR.Core.Models;
using MediatR.Core.Queries;

namespace MediatR.Core.Handlers
{
    public class GetUserByIdHandler : IRequestHandler<GetByIdQuery, User>
    {
        private readonly IMediator mediator;

        public GetUserByIdHandler(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<User> Handle(GetByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await this.mediator.Send(new GetAllUserQuery());
            var output = result.FirstOrDefault(u=>u.Id == request.Id);
            return output;
        }
    }
}
