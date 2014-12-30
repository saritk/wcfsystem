using System.Collections.Generic;
using System.Linq;
using Contracts;
using PersistenceLayer;

namespace Security.BusinessLogic
{
    
    /// <summary>
    /// provide connection to repository layer - execute service methods
    /// </summary>
    public class BusinessLogic : IBusinessLogic 
    {
        private readonly IUserRepository _userRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogic"/> class.
        /// </summary>
        /// <param name="userUserRepository">The user user repository.</param>
        public BusinessLogic(IUserRepository userUserRepository)
        {
            _userRepository = userUserRepository;
        }

        /// <summary>
        /// Gets the user by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public User GetUserById(int id)
        {
            var model = _userRepository.GetUser(id);
          
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
            var models = _userRepository.GetUsers();

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
            _userRepository.DeleteUser(user);
        }

        /// <summary>
        /// Updates the user.
        /// </summary>
        /// <param name="user">The user.</param>
        public void UpdateUser(User user)
        {
            _userRepository.UpdateUser(user);
        }

        /// <summary>
        /// Creates the user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        public User CreateUser(User user)
        {
            var model = _userRepository.CreateUser(user);
            return new User {Id = model.Id, UserName = model.UserName, Password = model.Password};
        }

    }
}
