using MediatR.Core.Models;

namespace MediatR.Core.Repositories
{
    public interface IUserRepository
    {
        List<User> GellAll();
        User GetById(int id);
        bool Create(User user);
        bool Update(User user);
        bool Delete(int id);
    }
}
