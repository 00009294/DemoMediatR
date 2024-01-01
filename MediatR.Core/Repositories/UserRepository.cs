using MediatR.Core.Data;
using MediatR.Core.Models;

namespace MediatR.Core.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext dataContext;

        public UserRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public List<User> GellAll()
        {
            return this.dataContext.Users.ToList(); 
        }
        public User GetById(int id)
        {
            var user = this.dataContext.Users.FirstOrDefault(u => u.Id == id);
            if(user == null)
            {
                throw new Exception("Not Found");
            }
            return user;
        }
        
        public bool Create(User user)
        {
            var res = this.dataContext.Users.Add(user);
            if(res != null)
            {
                return this.dataContext.SaveChanges() > 0;
            }
            return false;
            
        }

        public bool Delete(int id)
        {
            var user = this.dataContext.Users.FirstOrDefault(x => x.Id == id);
            if(user != null)
            {
                this.dataContext.Users.Remove(user);
                return this.dataContext.SaveChanges() > 0;
            }
            throw new Exception("Not Found");
        }

        public bool Update(User user)
        {
            if(user != null)
            {
                this.dataContext.Users.Update(user);
                return this.dataContext.SaveChanges() > 0;
            }
            throw new Exception("Not Found");
        }
    }
}
