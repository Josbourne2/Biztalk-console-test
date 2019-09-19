using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SendConsoleMessage
{
    
    public class Message
    {
        private string _Message;

        [XmlElement(
   ElementName = "Content")]
        public string message;
        public Message(string message)
        {
            _Message = message;
            this.message = message;
        }

        public Message()
        {

        }

        public string getMessage()
        {
            return _Message;
        }


    }
}
