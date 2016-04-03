using System;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using Sprache;

namespace CMSIS.Pack.PackDescription
{
    [Serializable( )]
    public partial class DeviceFeatureType {
    
        private string pnameField;
    
        private string typeField;
    
        private decimal nField;
    
        private bool nFieldSpecified;
    
        private decimal mField;
    
        private bool mFieldSpecified;
    
        private string nameField;
    
        private int countField;
    
        private bool countFieldSpecified;
    
        /// <remarks/>
        [XmlAttribute( Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string Pname {
            get {
                return pnameField;
            }
            set {
                pnameField = value;
            }
        }
    
        /// <remarks/>
        [XmlAttribute( Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string type {
            get {
                return typeField;
            }
            set {
                typeField = value;
            }
        }
    
        /// <remarks/>
        [XmlAttribute("n", Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string RawNString {
            get
            {
                return nField.ToString();
            }
            set
            {
                nField = Parsers.ScaledDecimal.Parse( value.Trim() );
            }
        }
    
        [XmlIgnore]
        public decimal n { get; set; }

        /// <remarks/>
        [XmlIgnore( )]
        public bool nSpecified {
            get {
                return nFieldSpecified;
            }
            set {
                nFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        [XmlAttribute( Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public decimal m {
            get {
                return mField;
            }
            set {
                mField = value;
            }
        }
    
        /// <remarks/>
        [XmlIgnore( )]
        public bool mSpecified {
            get {
                return mFieldSpecified;
            }
            set {
                mFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        [XmlAttribute( Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string name {
            get {
                return nameField;
            }
            set {
                nameField = value;
            }
        }
    
        /// <remarks/>
        [XmlAttribute( Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public int count {
            get {
                return countField;
            }
            set {
                countField = value;
            }
        }
    
        /// <remarks/>
        [XmlIgnore( )]
        public bool countSpecified {
            get {
                return countFieldSpecified;
            }
            set {
                countFieldSpecified = value;
            }
        }

        [OnDeserializing]
        internal void OnDeserializing( StreamingContext ctx )
        {
        }
    }
}