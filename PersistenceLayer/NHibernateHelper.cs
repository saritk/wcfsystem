using System.Reflection;
using NHibernate;
using NHibernate.Cfg;

namespace PersistenceLayer
{
    /// <summary>
    /// Configure Nhibernate 
    /// </summary>
    public class NHibernateHelper : INHibernateHelper
    {
        private ISessionFactory _sessionFactory;

        /// <summary>
        /// Gets the session factory.
        /// </summary>
        /// <value>
        /// The session factory.
        /// </value>
        public ISessionFactory SessionFactory
        {
            get
            {
                var configuration = new Configuration().Configure();
                configuration.AddAssembly(Assembly.GetExecutingAssembly());
                _sessionFactory = configuration.BuildSessionFactory();
                return _sessionFactory;
            }
        }

        /// <summary>
        /// Opens the session.
        /// </summary>
        /// <returns></returns>
        public ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }

    public interface INHibernateHelper
    {
        ISessionFactory SessionFactory { get; }
        ISession OpenSession();

    }

    
}
