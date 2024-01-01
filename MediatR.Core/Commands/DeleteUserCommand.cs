namespace MediatR.Core.Commands
{
    public record DeleteUserCommand(int Id) : IRequest<bool>
    {
    }
}
