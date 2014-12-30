using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using Component = Castle.MicroKernel.Registration.Component;

namespace PersistenceLayer
{
    public class RegisterDependencyForSystem
    {

        private readonly IWindsorContainer _container;

        public RegisterDependencyForSystem(IWindsorContainer container)
        {
            _container = container;
        }


        public virtual void RegisterServiceComponents()
        {
            _container.Register(Component.For<IUserRepository>().ImplementedBy<UserRepository>().LifeStyle.Transient);
        }

        //public void Register()
        //{
        //    var container = new WindsorContainer();
        //    container.Register(Component.For<IUserRepository>().ImplementedBy<UserRepository>());
        //}

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

    }
   
}
