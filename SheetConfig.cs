//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp_Test
//{
//    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
//    public partial class SheetConfig
//    {
//        private SheetConfigSheetInfo[] sheetsInfoField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlArrayItemAttribute("SheetInfo", IsNullable = false)]
//        public SheetConfigSheetInfo[] SheetsInfo
//        {
//            get
//            {
//                return this.sheetsInfoField;
//            }
//            set
//            {
//                this.sheetsInfoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
//    public partial class SheetConfigSheetInfo
//    {

//        private string nameField;

//        private byte widthField;

//        private byte heightField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string Name
//        {
//            get
//            {
//                return this.nameField;
//            }
//            set
//            {
//                this.nameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public byte Width
//        {
//            get
//            {
//                return this.widthField;
//            }
//            set
//            {
//                this.widthField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public byte Height
//        {
//            get
//            {
//                return this.heightField;
//            }
//            set
//            {
//                this.heightField = value;
//            }
//        }
//    }
//}
