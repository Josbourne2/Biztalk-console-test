using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ReceiveConsoleMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Receiving BizTalk messages";            

            ServiceHost host = new ServiceHost(typeof(ReceivingService));
            host.Open();
            Console.WriteLine("Service Hosted Successfully");
            Console.WriteLine("Ik wacht op uw bericht...");
            Console.Read();
            
        }
    }
}
