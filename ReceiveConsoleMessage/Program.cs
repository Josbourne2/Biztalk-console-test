using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiveConsoleMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Receiving BizTalk messages";
            Console.WriteLine("Ik wacht op uw bericht...");
            Console.ReadKey();
        }
    }
}
