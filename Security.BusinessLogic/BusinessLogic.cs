using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Contracts;
using PersistenceLayer;

namespace Security.BusinessLogic
{
    /// <summary>
    /// provide connection to repository layer - execute service methods
    /// </summary>
    public class BusinessLogic
    {
        readonly UserRepository _repository = Container.Resolve

        /// <summary>
        /// Gets the user by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets all users.
        /// </summary>
        /// <returns></returns>
        public List<User> GetUsers()
        {
            var models = _repository.GetUsers();

            return models.Select(model => new User
            {
                Id = model.Id, UserName = model.UserName, Password = model.Password
            }).ToList();
        }

        /// <summary>
        /// Deletes the user.
        /// </summary>
        /// <param name="user">The identifier.</param>
        public void DeleteUser(User user)
        {
            _repository.DeleteUser(user);
        }

        /// <summary>
        /// Updates the user.
        /// </summary>
        /// <param name="user">The user.</param>
        public void UpdateUser(User user)
        {
            _repository.UpdateUser(user);
        }

        /// <summary>
        /// Creates the user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        public User CreateUser(User user)
        {
            var model = _repository.CreateUser(user);
            return new User {Id = model.Id, UserName = model.UserName, Password = model.Password};
        }

    }
}
