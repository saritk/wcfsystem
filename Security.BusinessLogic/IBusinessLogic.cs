using System.Collections.Generic;
using Contracts;

namespace Security.BusinessLogic
{
    public interface IBusinessLogic
    {
        /// <summary>
        /// Gets the user by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        User GetUserById(int id);

        /// <summary>
        /// Gets all users.
        /// </summary>
        /// <returns></returns>
        List<User> GetUsers();

        /// <summary>
        /// Deletes the user.
        /// </summary>
        /// <param name="user">The identifier.</param>
        void DeleteUser(User user);

        /// <summary>
        /// Updates the user.
        /// </summary>
        /// <param name="user">The user.</param>
        void UpdateUser(User user);

        /// <summary>
        /// Creates the user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        User CreateUser(User user);
    }
}