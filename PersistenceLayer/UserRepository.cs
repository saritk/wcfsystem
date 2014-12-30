using System.Collections.Generic;
using Contracts;
using NHibernate;
using PersistenceLayer.Entities;

namespace PersistenceLayer
{
    /// <summary>
    /// C R U D operations for users
    /// </summary>
    public class UserRepository : IUserRepository
    {
        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        private INHibernateHelper _nHibernateHelper;

        public UserRepository(INHibernateHelper nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public UserDo GetUser(int id)
        {
            //***** Read ******************************
            using (ISession session = _nHibernateHelper.OpenSession())
            {
                return session.QueryOver<UserDo>().Where(x => x.Id == id).SingleOrDefault();
            }
        }

        /// <summary>
        /// Gets all users.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserDo> GetUsers()
        {
            using (ISession session = _nHibernateHelper.OpenSession())
            {
                return session.QueryOver<UserDo>().List();
            }
        }

        /// <summary>
        /// Deletes the user.
        /// </summary>
        /// <param name="user">The user.</param>
        public void DeleteUser(User user)
        {
            using (ISession session = _nHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var removeUser = new UserDo {Id = user.Id, UserName = user.UserName, Password = user.Password};
                    session.Delete(removeUser);
                    transaction.Commit();
                }
            }
        }

        /// <summary>
        /// Updates the user.
        /// </summary>
        /// <param name="user">The user.</param>
        public void UpdateUser(User user)
        {
            using (ISession session = _nHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var model = new UserDo {Id = user.Id, UserName = user.UserName, Password = user.Password};
                    session.Update(model);
                    transaction.Commit();
                }
            }
        }

        /// <summary>
        /// Creates the user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        public UserDo CreateUser(User user)
        {
            using (ISession session = _nHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var model = new UserDo {UserName = user.UserName, Password = user.Password};

                    session.Save(model);
                    transaction.Commit();
                    session.Flush();

                    return model; 
                }
            }
        
        }
    }

}
