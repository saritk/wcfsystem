using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using PersistenceLayer;

namespace ConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            var regisretedComponent = new RegisterDependencyForSystem(container);
            regisretedComponent.RegisterServiceComponents();

        }
    }
}
