using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace CSharp_Test
{
    public class SheetConfig
    {
        public Sheetsinfo[] SheetsInfo { get; set; }
    }

    public class Sheetsinfo
    {
        [XmlIgnore]
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
