using System.Collections.Generic;
using System.ServiceModel;
using Contracts;

namespace ServiceImplementation
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGetDataService" in both code and config file together.
    /// <summary>
    /// Service to get or update users
    /// </summary>
    [ServiceContract]
    public interface IGetDataService
    {
        /// <summary>
        /// Gets the users.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<User> GetUsers();

        /// <summary>
        /// Gets the user by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [OperationContract]
        User GetUserById(int id);

        /// <summary>
        /// Deletes the user.
        /// </summary>
        /// <param name="user">The user.</param>
        [OperationContract]
        void DeleteUser(User user);

        /// <summary>
        /// Updates the user.
        /// </summary>
        /// <param name="user">The user.</param>
        [OperationContract]
        void UpdateUser(User user);

        /// <summary>
        /// Creates the user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        [OperationContract]
        User CreateUser(User user);
    }
}
