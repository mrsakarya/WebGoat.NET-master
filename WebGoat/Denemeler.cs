using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace OWASP.WebGoat.NET
{
    public class Denemeler
    {
        public void ParolaGir(string state)
        {
            string xml = "";

            XmlDocument xDoc = new XmlDocument();
            //xDoc.LoadXml(xml);
            //XmlNodeList list = xDoc.SelectNodes("//salesperson[state='" + state + "']");
            //if (list.Count > 0)
            //{

            //}
        }
    }
}