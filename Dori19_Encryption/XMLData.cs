using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace Dori19_Encryption
{
    public class XMLData
    {
        public static string _TICK = "TICK";
        public static string _TOTAL = "TOTAL";
        public static string _LEVEL_1 = "LEVEL_1";
        public static string _LEVEL_3 = "LEVEL_3";
        public static string _LEVEL_50 = "LEVEL_50";

        public void XML_Writer(string strPath, Dictionary<string, string> DXmlList)
        {
            StringBuilder sb = new StringBuilder();
            //using (XmlWriter xw = XmlWriter.Create(strPath))
            // String Builder 안에 XML 데이터 넣기
            using (XmlWriter xw = XmlWriter.Create(sb))
            {
                xw.WriteStartDocument();

                xw.WriteStartElement("SETTING");
                xw.WriteAttributeString("ID", "0001");

                xw.WriteElementString(_TICK, DXmlList[_TICK]);
                xw.WriteElementString(_TOTAL, DXmlList[_TOTAL]);
                xw.WriteElementString(_LEVEL_1, DXmlList[_LEVEL_1]);
                xw.WriteElementString(_LEVEL_3, DXmlList[_LEVEL_3]);
                xw.WriteElementString(_LEVEL_50, DXmlList[_LEVEL_50]);

                xw.WriteEndElement();
                xw.WriteEndDocument();
            }
            string strRijndaelText = CRijndael.EncryptString(sb.ToString(), CRijndael._bkey);
            File.WriteAllText(strPath, strRijndaelText);
        }
        public Dictionary<string, string> XML_Reader(string strPath)
        {
            string strContent = File.ReadAllText(strPath, Encoding.UTF8);
            string strDECText = CRijndael.DecryptString(strContent, CRijndael._bkey);

            var list = new Dictionary<string, string>();

            using (XmlReader xr = XmlReader.Create(new StringReader(strDECText)))
            {
                while (xr.Read())
                {
                    if (xr.IsStartElement())
                    {
                        if (xr.Name == "SETTING")
                        {
                            string strId = xr["ID"];

                            xr.Read();

                            string strTick = xr.ReadElementContentAsString(_TICK, "");
                            list.Add(_TICK, strTick);
                            string strTotal = xr.ReadElementContentAsString(_TOTAL, "");
                            list.Add(_TOTAL, strTotal);
                            string strLevel1 = xr.ReadElementContentAsString(_LEVEL_1, "");
                            list.Add(_LEVEL_1, strLevel1);
                            string strLevel3 = xr.ReadElementContentAsString(_LEVEL_3, "");
                            list.Add(_LEVEL_3, strLevel3);
                            string strLevel50 = xr.ReadElementContentAsString(_LEVEL_50, "");
                            list.Add(_LEVEL_50, strLevel50);
                        }
                    }
                }
            }
            return list;
        }
    }

}
