using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

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

            //XmlDocument xmlDoc = new XmlDocument();
            ////xmlDoc.LoadXml("<user name=\"John Doe\"> A user node</user>");
            ////Console.WriteLine(xmlDoc.DocumentElement.InnerText);
            ////xmlDoc.LoadXml("<test>Innertext is here!</test>");
            ////Console.WriteLine(xmlDoc.DocumentElement.InnerText);
            ////xmlDoc.LoadXml("<users><user>InnerText/InnerXml</user></users>");
            ////Console.WriteLine("Inner: " + xmlDoc.DocumentElement.InnerXml);
            ////Console.WriteLine("Outer: " + xmlDoc.DocumentElement.OuterXml);
            ////Console.WriteLine("InnerText: " + xmlDoc.DocumentElement.InnerText);

            ////xmlDoc.LoadXml("<user name= \"John Doe\" age=\"42\"/>");
            ////if (xmlDoc.DocumentElement.Attributes["name"] != null)
            ////{
            ////    Console.WriteLine(xmlDoc.DocumentElement.Attributes["name"].Value);
            ////}
            ////if (xmlDoc.DocumentElement.Attributes["age"] != null)
            ////{
            ////    Console.WriteLine(xmlDoc.DocumentElement.Attributes["age"].Value);
            ////}


            ////var fromFile = XDocument.Load("../../example.xml").Element("users").Element("user").Attribute("name").Value;

            ////Console.WriteLine(fromFile);

            //XmlWriter xmlWriter = XmlWriter.Create("test.xml");
            //xmlWriter.WriteStartDocument();
            //xmlWriter.WriteStartElement("users");

            //xmlWriter.WriteStartElement("user");
            //xmlWriter.WriteAttributeString("age", "42");
            //Console.WriteLine("Sisesta nimi: ");
            //xmlWriter.WriteString(Console.ReadLine());
            //xmlWriter.WriteEndElement();


            //xmlWriter.WriteStartElement("user");
            //xmlWriter.WriteAttributeString("age", "39");
            //Console.WriteLine("Sisesta nimi: ");
            //xmlWriter.WriteString(Console.ReadLine());

            //xmlWriter.WriteEndDocument();
            //xmlWriter.Close();

            //XmlDocument xmlDoc2 = new XmlDocument();
            //XmlNode rootNode = xmlDoc2.CreateElement("Users");
            //xmlDoc2.AppendChild(rootNode);

            //XmlNode userNode = xmlDoc2.CreateElement("user");
            //XmlAttribute attribute = xmlDoc2.CreateAttribute("age");
            //attribute.Value = "42";
            //userNode.Attributes.Append(attribute);
            //userNode.InnerText = "John doe";
            //rootNode.AppendChild(userNode);

            //userNode = xmlDoc2.CreateElement("user");
            //attribute = xmlDoc2.CreateAttribute("age");
            //attribute.Value = "39";
            //userNode.Attributes.Append(attribute);
            //userNode.InnerText = "Jane doe";
            //rootNode.AppendChild(userNode);

            //xmlDoc2.Save("Test-doc.xml");

            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load("Test-doc.xml");
            //XmlNodeList userNodes = xmlDoc.SelectNodes("//users/user");
            //foreach (XmlNode userNode in userNodes)
            //{
            //    int age = int.Parse(userNode.Attributes["age"].Value);
            //    userNode.Attributes["age"].Value = (age + 1).ToString();
            //}
            //xmlDoc.Save("Test-doc.xml");




            //XmlSerializer

            //var paljuTooteid = new List<Toode>();
            //var toode1 = new Toode() { Nimi = "Banaan", Hind = "12" };
            //var toode2 = new Toode() { Nimi = "Leib", Hind = "2" };
            //var toode3 = new Toode() { Nimi = "Sai", Hind = "42" };
            //var toode4 = new Toode() { Nimi = "Fanta", Hind = "52" };
            //var toode5 = new Toode() { Nimi = "Pastakas", Hind = "222" };
            //paljuTooteid.Add(toode1);
            //paljuTooteid.Add(toode2);
            //paljuTooteid.Add(toode3);
            //paljuTooteid.Add(toode4);
            //paljuTooteid.Add(toode5);

            //var serializer = new XmlSerializer(paljuTooteid.GetType());
            //using (var writer = XmlWriter.Create("tooted.xml"))
            //{
            //    serializer.Serialize(writer, paljuTooteid);
            //}

            var tooted = new List<Toode>();
            var serializer = new XmlSerializer(typeof(List<Toode>));
            using (var reader = XmlReader.Create("tooted.xml"))
            {
                tooted = (List<Toode>)serializer.Deserialize(reader);
            }

            foreach (var toode in tooted)
            {
                Console.WriteLine(toode.Nimi + " " + toode.Hind + " eur");
            }

            Console.ReadLine();
        }
    }
}
