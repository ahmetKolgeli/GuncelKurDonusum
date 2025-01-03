using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DovizProje
{
    internal class KurCekme
    {
        public String KurCek(String komut) {

            string exchangeRate = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(exchangeRate);

            string kurS = xmlDoc.SelectSingleNode(komut).InnerXml;

            return kurS;
        }
    }
}
