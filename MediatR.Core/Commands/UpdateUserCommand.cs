using MediatR.Core.Models;

namespace MediatR.Core.Commands
{
    public record UpdateUserCommand(int Id, string FirstName, string LastName) 
        : IRequest<bool>
    {
    }
}
