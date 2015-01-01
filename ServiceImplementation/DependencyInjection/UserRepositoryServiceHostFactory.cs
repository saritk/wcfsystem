using Infrastructure;
using PersistenceLayer;
using Security.BusinessLogic;

namespace ServiceImplementation.DependencyInjection
{
    /// <summary>
    /// A custom service host factory that will register the dependencies with unity before the service is created.
    /// </summary>
    public class UserRepositoryServiceHostFactory : DependencyInjectionServiceHostFactory
    {
        protected override void RegisterDependencies()
        {
            DependencyFactory.Register<IUserRepository, UserRepository>();
            DependencyFactory.Register<IBusinessLogic, BusinessLogic>();
            DependencyFactory.Register<INHibernateHelper,NHibernateHelper>();
        }
    }
}