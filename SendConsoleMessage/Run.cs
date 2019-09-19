using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace SendConsoleMessage
{
    class Run
    {

        public void Start()
        {
            Console.Title = "Stuur een bericht via BizTalk";
            Console.WriteLine("Typ wat in: ");
            string filename = ConfigurationManager.AppSettings["XmlFileLocation"];

            string input;
            input = Console.ReadLine();

            if (!String.IsNullOrEmpty(input))
            {
                MessageBuilder mb = new MessageBuilder();
                mb.setMessage(input);
                Message msg = mb.getMessage();
                //SerializeObject(fileName, msg);
                BuildXml(filename, msg);
                Console.WriteLine(msg.getMessage());
                Console.ReadLine();
            }
        }

        public void SerializeObject(string filename, Message message)
        {
            // Create the XmlSerializer.
            XmlSerializer s = new XmlSerializer(typeof(Message));            

            // To write the file, a TextWriter is required.
            TextWriter writer = new StreamWriter(filename);
           

            // Serialize the object, and close the TextWriter.      
            s.Serialize(writer, message);
            writer.Close();


        }
        
        public void BuildXml(string filename, Message msg)
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlNode rootNode = xmlDoc.CreateElement("Message", "http://BT.RouteMessage.Message");
           
            xmlDoc.AppendChild(rootNode);

            XmlNode contentNode = xmlDoc.CreateElement("Content", "http://BT.RouteMessage.Message");
            contentNode.InnerText = msg.getMessage();

            rootNode.AppendChild(contentNode);           

            xmlDoc.Save("test-doc.xml");
        }



    }
}

