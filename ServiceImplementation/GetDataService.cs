using System.Collections.Generic;
using Contracts;
using Security.BusinessLogic;

namespace ServiceImplementation
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GetDataService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GetDataService.svc or GetDataService.svc.cs at the Solution Explorer and start debugging.
    /// <summary>
    /// 
    /// </summary>
    public class GetDataService : IGetDataService
    {
        /// <summary>
        /// Gets the users.
        /// </summary>
        /// <returns></returns>
        public List<User> GetUsers()
        {
            var businessLogic = new BusinessLogic();
            return businessLogic.GetUsers();
        }
    }
    //Kadosh.Security.PermissonsService
}
