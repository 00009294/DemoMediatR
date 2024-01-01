namespace MediatR.Core.Commands
{
    public record CreateUserCommand(
        string FirstName, string LastName)
            : IRequest<bool>
    {

    }
   
}
