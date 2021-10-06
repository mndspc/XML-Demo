using System;
using System.Xml;
using Newtonsoft.Json;

namespace XMLDemo
{
    //  This program demo. how to convert json to xml.
    class ParsingJsonToXml
    {
        static void Main()
        {
            var jsonValue = @"{
            'root':{
                    'Profile':[
                                    {'id':'1','name':'scott','address':'Pune'},
                                    {'id':'2','name':'tiger','address':'mumbai'}
                              ]
                    }
            }";

            //  To represent this string as an xml document, we can use xmlDocument class to load xml content.
            XmlDocument xmlDocument = JsonConvert.DeserializeXmlNode(jsonValue);
            Console.WriteLine(xmlDocument.InnerXml);
            Console.ReadLine();
        }
    }
}
