using System;
using System.Xml;
namespace XMLDemo
{
    //  This program demo. how to write XML file
    class Program
    {
        static void Main(string[] args)
        {
            //  To create file inside working directory
            using (XmlWriter xmlWriter=XmlWriter.Create("test.xml"))
            {
                //  To Start writing doc.
                xmlWriter.WriteStartDocument();

                //  To write Root element
                xmlWriter.WriteStartElement("Students");

                    //  To create attributes
                    xmlWriter.WriteAttributeString("RollNo", "100");

                        //  To write parent node/element

                        xmlWriter.WriteStartElement("Student"); 

                            // To write child element
                            xmlWriter.WriteElementString("Name", "Scott");

                            //  To end parent node/element
                            xmlWriter.WriteEndElement();

                        //  To end Root element
                        xmlWriter.WriteEndElement();

                //  To end writing doc.
                xmlWriter.WriteEndDocument();

                xmlWriter.Close();
                Console.WriteLine("XML file written successfully");
                
            }
            Console.ReadLine();
        }
    }
}
