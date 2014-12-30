using System.Collections.Generic;
using Contracts;
using Security.BusinessLogic;

namespace ServiceImplementation
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GetDataService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GetDataService.svc or GetDataService.svc.cs at the Solution Explorer and start debugging.
    /// <summary>
    /// Service to get or update users 
    /// </summary>
    public class GetDataService : IGetDataService
    {
        private readonly IBusinessLogic _businessLogic;

        public GetDataService(IBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        /// <summary>
        /// Gets all users exists.
        /// </summary>
        /// <returns></returns>
        public List<User> GetUsers()
        {
            return _businessLogic.GetUsers();
        }

        /// <summary>
        /// Gets the user by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public User GetUserById(int id)
        {
            return _businessLogic.GetUserById(id);
        }

        /// <summary>
        /// Deletes the user.
        /// </summary>
        /// <param name="user">The user.</param>
        public void DeleteUser(User user)
        {
            _businessLogic.DeleteUser(user);
        }

        /// <summary>
        /// Updates the user.
        /// </summary>
        /// <param name="user">The user.</param>
        public void UpdateUser(User user)
        {
            _businessLogic.UpdateUser(user);
        }

        /// <summary>
        /// Creates the user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        public User CreateUser(User user)
        {
            return _businessLogic.CreateUser(user);
        }
    }

}
