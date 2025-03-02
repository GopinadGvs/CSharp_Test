using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using System.IO;
using Newtonsoft.Json;
using System.Data.SQLite;
using System.Data;
using System.Diagnostics;

namespace CSharp_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XMLSerialization.TestXMLSerialization();
            JSONSerialization.TestJSONSerialization();
            SQLiteReader.TestSQLiteReader();
        }
    }
}
