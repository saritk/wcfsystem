using System;
using System.ServiceModel;
using System.ServiceModel.Activation;
using Infrastructure;

namespace ServiceImplementation.DependencyInjection
{
    /// <summary>
    /// Produces <see cref="DependencyInjectionServiceHost"/>s.
    /// </summary>
    public abstract class DependencyInjectionServiceHostFactory : ServiceHostFactory
    {
        /// <summary>
        /// Creates a <see cref="DependencyInjectionServiceHost"/> for a specified type of service with a specific base address. 
        /// </summary>
        /// <returns>
        /// A <see cref="DependencyInjectionServiceHost"/> for the type of service specified with a specific base address.
        /// </returns>
        /// <param name="serviceType">
        /// Specifies the type of service to host. 
        /// </param>
        /// <param name="baseAddresses">
        /// The <see cref="T:System.Array"/> of type <see cref="T:System.Uri"/> that contains the base addresses for the service hosted.
        /// </param>
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            //Register the service as a type so it can be found from the instance provider
            DependencyFactory.Register(serviceType);

            RegisterDependencies();
            return new DependencyInjectionServiceHost(serviceType, baseAddresses);
        }

        /// <summary>
        /// Initialization logic that any derived type would use to set up the ServiceLocator provider.  Look to UnityServiceHostFactory to see how this is done, if implementing for 
        /// another IoC engine.
        /// </summary>
        /// //TODO
        protected abstract void RegisterDependencies();
    }
}