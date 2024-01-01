using MediatR.Core.Models;

namespace MediatR.Core.Queries
{
    public record GetAllUserQuery : IRequest<List<User>>
    {
    }
}
