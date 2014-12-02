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
        private ISessionFactory sessionFactory;
        public UserRepository()
        {
            //***** Configure Nhibernate ******************
            var nhConfig = new Configuration().Configure();
            nhConfig.AddAssembly(Assembly.GetExecutingAssembly());

            sessionFactory = nhConfig.BuildSessionFactory();
        }

        public UserDo GetUser(int id)
        {
            //***** Read ******************************
            using (ISession session = sessionFactory.OpenSession())
            {
                return session.QueryOver<UserDo>().Where(x => x.Id == id).SingleOrDefault();
            }
        }

        public IEnumerable<UserDo> GetUsers()
        {
            using (ISession session = sessionFactory.OpenSession())
            {
                return session.QueryOver<UserDo>().List();
            }
        }
    }
}
