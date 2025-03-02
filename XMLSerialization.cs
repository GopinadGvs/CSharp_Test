using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace CSharp_Test
{
    internal class XMLSerialization
    {
        public static void TestXMLSerialization()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SheetConfig));

            SheetConfig sheetConfig;

            using (StreamReader reader = new StreamReader(@"E:\SheetConfig.xml"))
            {
                sheetConfig = (SheetConfig)serializer.Deserialize(reader);
            }

            using (StreamWriter writer = new StreamWriter(@"E:\SheetConfig.xml"))
            {
                serializer.Serialize(writer, sheetConfig);
            }

            //SheetConfig sheetConfig = new SheetConfig
            //{
            //    SheetsInfo = new Sheetsinfo[]
            //    {
            //        new Sheetsinfo{Name = "A0",Height = 10, Width = 10,},
            //        new Sheetsinfo{Name = "A0",Height = 10, Width = 10,},
            //        new Sheetsinfo{Name = "A0",Height = 10, Width = 10,},
            //    }
            //};
        }
    }
}

//<? xml version = "1.0" encoding = "utf-8" ?>
//< SheetConfig xmlns:xsi = "http://www.w3.org/2001/XMLSchema-instance" xmlns: xsd = "http://www.w3.org/2001/XMLSchema" >
//  < SheetsInfo >
//    < SheetInfo Name = "A0" Width = "10" Height = "10" />
//    < SheetInfo Name = "A1" Width = "20" Height = "20" />
//    < SheetInfo Name = "A2" Width = "30" Height = "30" />
//  </ SheetsInfo >
//</ SheetConfig >
