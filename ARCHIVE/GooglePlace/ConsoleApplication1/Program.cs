using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
                String input = "pham ngu lao";
                String apiKey = "AIzaSyDT_q6mxGrEUXoDg-HeV51LfM9aTmZV0JI";
                String URLString = "https://maps.googleapis.com/maps/api/place/autocomplete/xml?input="+input+"&types=geocode&language=vi&key="+ apiKey;

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(URLString);
            String temp;
            foreach (XmlNode node in xmlDoc.GetElementsByTagName("prediction"))
            {
                foreach (XmlNode node1 in node.ChildNodes)
                {

                    if (node1.Name == "description")
                    {
                        temp= node1.InnerText;
                        
                    }
                    break;
                       
                }
                break;
            }

            Console.ReadLine();
        }

   }
}

