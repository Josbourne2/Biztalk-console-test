using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendConsoleMessage
{
    class MessageBuilder : IMessageBuilder
    {
        //Het private bericht property waar niemand aan mag komen die niet in mijn klasje zit. Discriminatie? Ja!
        private string _Message;
        public MessageBuilder()
        {

        }

        //Mensen van buiten mogen dit setten
        public void setMessage(string inputMessage)
        {
            _Message = inputMessage;
        }

        public Message getMessage()
        {
            return new Message( _Message);
        }
    }
}
