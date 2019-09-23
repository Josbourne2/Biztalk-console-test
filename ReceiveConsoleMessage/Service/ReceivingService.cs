using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml;

namespace ReceiveConsoleMessage
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ReceivingService" in both code and config file together.
    public class ReceivingService : IReceivingService
    {
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public void ReceiveMessage(string Response)
        {
            Console.WriteLine(Response.ToString());
        }
        
    }
}
