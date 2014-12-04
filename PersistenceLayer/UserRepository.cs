using System.Collections.Generic;
using System.Reflection;
using Contracts;
using NHibernate;
using NHibernate.Cfg;
using PersistenceLayer.Entities;

namespace PersistenceLayer
{
    public class UserRepository
    {
        private readonly ISessionFactory _sessionFactory;

        public UserRepository()
        {
            //***** Configure Nhibernate ******************
            var nhConfig = new Configuration().Configure();
            nhConfig.AddAssembly(Assembly.GetExecutingAssembly());

            _sessionFactory = nhConfig.BuildSessionFactory();
        }

        public UserDo GetUser(int id)
        {
            //***** Read ******************************
            using (ISession session = _sessionFactory.OpenSession())
            {
                return session.QueryOver<UserDo>().Where(x => x.Id == id).SingleOrDefault();
            }
        }

        public IEnumerable<UserDo> GetUsers()
        {
            using (ISession session = _sessionFactory.OpenSession())
            {
                return session.QueryOver<UserDo>().List();
            }
        }

        public void DeleteUser(int userId)
        {
            using (ISession session = _sessionFactory.OpenSession())
            {
                var removeUser = new UserDo {Id = userId};
                session.Delete(removeUser);
            }
        }

        public void UpdateUser(User user)
        {
            using (ISession session = _sessionFactory.OpenSession())
            {
                var model = new UserDo {Id = user.Id, UserName = user.UserName, Password = user.Password};
                session.Update(model);
            }
        }

        public UserDo CreateUser(User user)
        {
            using (ISession session = _sessionFactory.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    var model = new UserDo {Id = user.Id, UserName = user.UserName, Password = user.Password};
                    return session.Save(model) as UserDo;
                }
            }
        }
        }
    }
}
