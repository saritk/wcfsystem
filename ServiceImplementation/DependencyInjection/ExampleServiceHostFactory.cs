using Infrastructure;
using PersistenceLayer;

namespace ServiceImplementation.DependencyInjection
{
    /// <summary>
    /// A custom service host factory that will register the dependencies with unity before the service is created.
    /// </summary>
    public class ExampleServiceHostFactory : DependencyInjectionServiceHostFactory
    {
        protected override void RegisterDependencies()
        {
            DependencyFactory.Register<IUserRepository, UserRepository>();
                //(typeof(IExampleRepository), typeof(ExampleRepository), new ContainerControlledLifetimeManager());
        }
    }
}