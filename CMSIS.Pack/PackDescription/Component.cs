using System;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace CMSIS.Pack.PackDescription
{
    [Serializable( )]
    [XmlType( AnonymousType=true)]
    public partial class Component : ComponenOrBundleGroup
    {
    
        private bool deprecatedField;
    
        private string rTE_Components_hField;
    
        private FileType[] filesField;
    
        private string cgroupField;
    
        private string csubField;
    
        private string cvariantField;
    
        private string capiversionField;
    
        private string conditionField;
    
        private string maxInstancesField;
    
        private string generatorField;
    
        public Component() {
            deprecatedField = false;
        }
    
        /// <remarks/>
        [DefaultValue( false)]
        public bool deprecated {
            get {
                return deprecatedField;
            }
            set {
                deprecatedField = value;
            }
        }

        /// <remarks/>
        public string RTE_Components_h {
            get {
                return rTE_Components_hField;
            }
            set {
                rTE_Components_hField = value;
            }
        }
    
        /// <remarks/>
        [XmlArrayItem( "file", IsNullable=false)]
        public FileType[] files {
            get {
                return filesField;
            }
            set {
                filesField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute( Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string Cgroup {
            get {
                return cgroupField;
            }
            set {
                cgroupField = value;
            }
        }
    
        /// <remarks/>
        [XmlAttribute( Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string Csub {
            get {
                return csubField;
            }
            set {
                csubField = value;
            }
        }
    
        /// <remarks/>
        [XmlAttribute( Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string Cvariant {
            get {
                return cvariantField;
            }
            set {
                cvariantField = value;
            }
        }
    
        /// <remarks/>
        [XmlAttribute( Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string Capiversion {
            get {
                return capiversionField;
            }
            set {
                capiversionField = value;
            }
        }
    
        /// <remarks/>
        [XmlAttribute( Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string condition {
            get {
                return conditionField;
            }
            set {
                conditionField = value;
            }
        }
    
        /// <remarks/>
        [XmlAttribute( Form=System.Xml.Schema.XmlSchemaForm.Qualified, DataType="integer")]
        public string maxInstances {
            get {
                return maxInstancesField;
            }
            set {
                maxInstancesField = value;
            }
        }
    
        /// <remarks/>
        [XmlAttribute( Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string generator {
            get {
                return generatorField;
            }
            set {
                generatorField = value;
            }
        }
    }
}