using System;
using System.Xml;

namespace XMLDemo
{
    //  This program demo. how to read xml doc.
    class ReadXml
    {
        static void Main()
        {
            using (XmlReader xmlReader = XmlReader.Create("test.xml"))
            {
                xmlReader.ReadToFollowing("Student");
                do
                {
                    xmlReader.ReadToFollowing("Name");
                    Console.WriteLine($"Name={xmlReader.ReadElementContentAsString()}");

                    xmlReader.ReadToFollowing("Location");
                    Console.WriteLine($"Location={xmlReader.ReadElementContentAsString()}");

                } while (xmlReader.ReadToFollowing("Student"));
            }

            Console.ReadLine();
        }
    }
}
