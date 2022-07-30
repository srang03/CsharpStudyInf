using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Dori16_StreamReaderReivew
{
    public class XMLClass
    {
        public static string _TEXT_DATA = "TEXT_DATA";
        public static string _CBOX_DATA = "TEXT_DATA";
        public static string _NUMBERBOX_DATA = "TEXT_DATA";

        public Dictionary<string,string> XMLReader(string strXMLPath)
        {
            Dictionary<string, string> DXMLConfig = new Dictionary<string, string>();

            using (XmlReader xrd= XmlReader.Create(strXMLPath))
            {
                while (xrd.Read())
                {
                    if (xrd.IsStartElement())
                    {
                        if (xrd.Name.Equals("SETTING"))
                        {
                            string strID = xrd["ID"];
                            xrd.Read();

                            string strText = xrd.ReadElementContentAsString(_TEXT_DATA, "");
                            DXMLConfig.Add(_TEXT_DATA, strText);

                            string strCBOX = xrd.ReadElementContentAsString(_CBOX_DATA, "");
                            DXMLConfig.Add(_CBOX_DATA, strCBOX);

                            string strNumberBox = xrd.ReadElementContentAsString(_NUMBERBOX_DATA, "");
                            DXMLConfig.Add(_NUMBERBOX_DATA, strNumberBox);
                        }
                    }
                    
                }
            }
                return DXMLConfig;
        }

        public void XMLWriter(string strXMLPath, Dictionary<string, string> DXMLConfig)
        {
            using(XmlWriter xwr = XmlWriter.Create(strXMLPath))
            {
                xwr.WriteStartDocument();

                // SETTING
                xwr.WriteStartElement("SETTING");
                xwr.WriteAttributeString("ID", "0001");

                xwr.WriteElementString(_TEXT_DATA, DXMLConfig[_TEXT_DATA]);
                xwr.WriteElementString(_CBOX_DATA, DXMLConfig[_CBOX_DATA]);
                xwr.WriteElementString(_NUMBERBOX_DATA, DXMLConfig[_NUMBERBOX_DATA]);

                xwr.WriteEndElement();
                xwr.WriteEndDocument();
            }
        }


    }
}
