using System;
using System.Reflection;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Tool.hbm2ddl;
using Environment = NHibernate.Cfg.Environment;


namespace Security.UnitTests.DataAccess
{
    /*public class InMemoryDataBaseTest : IDisposable
    {
        private static Configuration Configuration;
        private static ISessionFactory SessionFactory;
        protected ISession session;


        public InMemoryDataBaseTest(Assembly assemblyContainingMapping)
        {
            if (Configuration == null)
            {
                Configuration =
                    new Configuration().SetProperty(Environment.ReleaseConnections, "on_close")
                        .SetProperty(Environment.Dialect, typeof (SQLiteDialect).AssemblyQualifiedName)
                        .SetProperty(Environment.ConnectionDriver, typeof (SQLite20Driver).AssemblyQualifiedName)
                        .SetProperty(Environment.ConnectionString, "data source=:memory:")
                        .SetProperty(Environment.ProxyFactoryFactoryClass, typeof(ProxyFactoryFactory).AssemblyQualifiedName)
                        .AddAssembly(assemblyContainingMapping);

                SessionFactory = Configuration.BuildSessionFactory();
                new SchemaExport(Configuration).Execute(true, true, false, true, session.Connection, Console.Out);

            }

        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }*/
     
}
