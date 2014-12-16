using System.Reflection;
using NHibernate;
using NHibernate.Cfg;

namespace PersistenceLayer
{
    /// <summary>
    /// Configure Nhibernate 
    /// </summary>
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        /// <summary>
        /// Gets the session factory.
        /// </summary>
        /// <value>
        /// The session factory.
        /// </value>
        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    var configuration = new Configuration().Configure();
                    configuration.AddAssembly(Assembly.GetExecutingAssembly());
                    _sessionFactory = configuration.BuildSessionFactory();
                }
                return _sessionFactory;
            }
        }

        /// <summary>
        /// Opens the session.
        /// </summary>
        /// <returns></returns>
        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
