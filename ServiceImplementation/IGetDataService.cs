using System.Collections.Generic;
using System.ServiceModel;
using Contracts;

namespace ServiceImplementation
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGetDataService" in both code and config file together.
    /// <summary>
    /// 
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

        [OperationContract]
        User GetUserById(int id);

        [OperationContract]
        void DeleteUser(int id);

        [OperationContract]
        void UpdateUser(User user);

        [OperationContract]
        User CreateUser(User user);
    }
}
