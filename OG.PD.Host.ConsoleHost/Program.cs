using OG.PD.Business.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OG.PD.Host.ConsoleHost
{
    public class Program
    {
        static void Main(string[] args)
        {
            try { 
            Console.WriteLine("Starting up services...");
            Console.WriteLine("");

            ServiceHost searchServiceHost = new ServiceHost(typeof(SearchService));
            ServiceHost podcastServiceHost = new ServiceHost(typeof(PodcastService));
            ServiceHost subscriptionServiceHost = new ServiceHost(typeof(SubscriptionService));

            StartService(searchServiceHost, "Search Service");
            StartService(podcastServiceHost, "Podcast Service");
            StartService(subscriptionServiceHost, "Subscription Service");

            Console.WriteLine("");
            Console.WriteLine("Press [Enter] to exit.");
            Console.ReadLine();
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        static void StartService(ServiceHost host, string serviceDescription)
        {
            host.Open();
            Console.WriteLine("Service '{0}' started.", serviceDescription);

            foreach (var endpoint in host.Description.Endpoints)
            {
                Console.WriteLine(string.Format("Listening on endpoint:"));
                Console.WriteLine(string.Format("Address: {0}", endpoint.Address.Uri.ToString()));
                Console.WriteLine(string.Format("Binding: {0}", endpoint.Binding.Name));
                Console.WriteLine(string.Format("Contract: {0}", endpoint.Contract.ConfigurationName));
            }

            Console.WriteLine();
        }

        static void StopService(ServiceHost host, string serviceDescription)
        {
            host.Close();
            Console.WriteLine("Service '{0}' stopped.", serviceDescription);
        }
    }
}
