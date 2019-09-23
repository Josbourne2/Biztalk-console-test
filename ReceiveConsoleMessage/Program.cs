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
            //Console.Title = "Receiving BizTalk messages";
            //Console.WriteLine("Ik wacht op uw bericht...");

            ServiceHost host = new ServiceHost(typeof(ReceivingService));
            host.Open();
            Console.WriteLine("Service Hosted Sucessfully");
            Console.Read();

            //Console.ReadKey();
        }
    }
}
