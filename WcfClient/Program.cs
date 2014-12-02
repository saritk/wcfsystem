using System;
using System.Linq;
using WcfClient.ServiceReference1;

namespace WcfClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            GetDataServiceClient getDataServiceClientProxy = new GetDataServiceClient();
            var users = getDataServiceClientProxy.GetUsers();
            Console.WriteLine(users.First().Name);
        }
    }
}
