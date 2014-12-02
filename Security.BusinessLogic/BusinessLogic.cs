using System.Collections.Generic;
using System.Linq;
using Contracts;
using PersistenceLayer;

namespace Security.BusinessLogic
{
    public class BusinessLogic
    {
        public User GetUser(int id)
        {
            var repository = new UserRepository();
            var model = repository.GetUser(id);
          
            return new User
            {
                Id = model.Id,
                Name = model.UserName,
                Password = model.Password
            };
        }


        public List<User> GetUsers()
        {
            var repository = new UserRepository();
            var models = repository.GetUsers();

            return models.Select(model => new User
            {
                Id = model.Id, Name = model.UserName, Password = model.Password
            }).ToList();
        }
    }
}
