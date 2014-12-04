using System.Collections.Generic;
using System.Linq;
using Contracts;
using PersistenceLayer;

namespace Security.BusinessLogic
{
    public class BusinessLogic
    {
        readonly UserRepository _repository = new UserRepository();

        public User GetUserById(int id)
        {
            var model = _repository.GetUser(id);
          
            return new User
            {
                Id = model.Id,
                UserName = model.UserName,
                Password = model.Password
            };
        }
        
        public List<User> GetUsers()
        {
            var models = _repository.GetUsers();

            return models.Select(model => new User
            {
                Id = model.Id, UserName = model.UserName, Password = model.Password
            }).ToList();
        }

        public void DeleteUser(int id)
        {
            _repository.DeleteUser(id);
        }

        public void UpdateUser(User user)
        {
            _repository.UpdateUser(user);
        }

        public User CreateUser(User user)
        {
            var model = _repository.CreateUser(user);
            return new User {Id = model.Id, UserName = model.UserName, Password = model.Password};
        }

    }
}
