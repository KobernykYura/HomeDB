using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.ServiceModel.Description;

namespace HomeService
{
    [ServiceContract]
    public interface IStockService
    {
        [OperationContract]
        string GetPrice(string ticker);
    }
    public class StockService : IStockService
    {
        public string GetPrice(string name)
        {
            return "Hello " + name + "!";
        }
    }

    public class Result
    {
        public double Price;
    }
    public class Program
    {
        public static void Main()
        {
            ServiceHost serviceHost = new ServiceHost(typeof(StockService), new Uri("http://localhost:8080/EssentialWCFConfig"));
            serviceHost.AddServiceEndpoint(typeof(IStockService), new BasicHttpBinding(), "");
            ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
            behavior.HttpGetEnabled = true;
            serviceHost.Description.Behaviors.Add(behavior);
            serviceHost.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");

            serviceHost.Open();
            Console.WriteLine("Для завершения нажмите <ENTER>.\n\n");
            Console.ReadLine();
            serviceHost.Close();
        }
    }
}
