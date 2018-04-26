using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XMLHarjutus
{
    class Program
    {
        static void Main(string[] args)
        {
            //XmlReader xmlReader = XmlReader.Create("http://www.ecb.int/stats/eurofxref/eurofxref-daily.xml");
            //while (xmlReader.Read())
            //{
            //    if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "Cube")
            //    {
            //        if (xmlReader.HasAttributes)
            //        {
            //            System.Console.WriteLine(xmlReader.GetAttribute("currency") + " " + xmlReader.GetAttribute("rate"));
            //        }
            //    }
            //}

            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load("http://www.ecb.int/stats/eurofxref/eurofxref-daily.xml");
            //foreach (XmlNode xmlNode in xmlDoc.DocumentElement.ChildNodes[2].ChildNodes[0].ChildNodes)
            //{
            //    Console.WriteLine(xmlNode.Attributes["currency"].Value + " " + xmlNode.Attributes["rate"].Value);
            //}

            XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.LoadXml("<user name=\"John Doe\"> A user node</user>");
            //Console.WriteLine(xmlDoc.DocumentElement.InnerText);
            //xmlDoc.LoadXml("<test>Innertext is here!</test>");
            //Console.WriteLine(xmlDoc.DocumentElement.InnerText);
            //xmlDoc.LoadXml("<users><user>InnerText/InnerXml</user></users>");
            //Console.WriteLine("Inner: " + xmlDoc.DocumentElement.InnerXml);
            //Console.WriteLine("Outer: " + xmlDoc.DocumentElement.OuterXml);
            //Console.WriteLine("InnerText: " + xmlDoc.DocumentElement.InnerText);

            //xmlDoc.LoadXml("<user name= \"John Doe\" age=\"42\"/>");
            //if (xmlDoc.DocumentElement.Attributes["name"] != null)
            //{
            //    Console.WriteLine(xmlDoc.DocumentElement.Attributes["name"].Value);
            //}
            //if (xmlDoc.DocumentElement.Attributes["age"] != null)
            //{
            //    Console.WriteLine(xmlDoc.DocumentElement.Attributes["age"].Value);
            //}


            //var fromFile = XDocument.Load("../../example.xml").Element("users").Element("user").Attribute("name").Value;

            //Console.WriteLine(fromFile);

            XmlWriter xmlWriter = XmlWriter.Create("test.xml");
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("users");
            xmlWriter.WriteStartElement("user");
            xmlWriter.WriteAttributeString("age", "42");
            Console.WriteLine("Sisesta nimi: ");
            xmlWriter.WriteString(Console.ReadLine());
            xmlWriter.WriteEndElement();


            xmlWriter.WriteStartElement("user");
            xmlWriter.WriteAttributeString("age", "39");
            Console.WriteLine("Sisesta nimi: ");
            xmlWriter.WriteString(Console.ReadLine());

            xmlWriter.WriteEndDocument();
            xmlWriter.Close();

            Console.ReadLine();
        }
    }
}
