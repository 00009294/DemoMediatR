using MediatR.Core.Models;

namespace MediatR.Core.Queries
{
    public record GetByIdQuery(int Id) : IRequest<User>
    {
    }
}
