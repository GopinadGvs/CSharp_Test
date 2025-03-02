using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace CSharp_Test
{
    internal class JSONSerialization
    {
        public static void TestJSONSerialization()
        {
            string allText = System.IO.File.ReadAllText(@"E:\SheetConfig.Json");

            SheetConfig obj = JsonConvert.DeserializeObject<SheetConfig>(allText);

            string val = JsonConvert.SerializeObject(obj);

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

//{
//    "SheetsInfo": [
//        {
//        "Name": "A0",
//            "Width": 10,
//            "Height": 10
//        },
//        {
//        "Name": "A1",
//            "Width": 20,
//            "Height": 20
//        },
//        {
//        "Name": "A2",
//            "Width": 30,
//            "Height": 30
//        }
//    ]
//}
