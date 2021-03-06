using System;
using System.Xml;
using System.Xml.Serialization;

namespace CMSIS.Pack.PackDescription
{
    [Serializable( )]
    public class DeviceType {
    
        private ProcessorType[] processorField;
    
        private DebugConfig debugconfigField;
    
        private CompileType[] compileField;
    
        private MemoryType[] memoryField;
    
        private Algorithm[] algorithmField;
    
        private BookType[] bookField;
    
        private DescriptionType[] descriptionField;
    
        private DeviceFeatureType[] featureField;
    
        private EnvironmentType[] environmentField;
    
        private DebugPort[] debugportField;
    
        private Debug[] debugField;
    
        private TraceType[] traceField;
    
        private DebugVarsType[] debugvarsField;
    
        private SequencesType[] sequencesField;
    
        private DeviceTypeVariant[] variantField;
    
        private string dnameField;
    
        /// <remarks/>
        [XmlElement( "processor")]
        public ProcessorType[] processor {
            get {
                return processorField;
            }
            set {
                processorField = value;
            }
        }
    
        /// <remarks/>
        public DebugConfig debugconfig {
            get {
                return debugconfigField;
            }
            set {
                debugconfigField = value;
            }
        }
    
        /// <remarks/>
        [XmlElement( "compile")]
        public CompileType[] compile {
            get {
                return compileField;
            }
            set {
                compileField = value;
            }
        }
    
        /// <remarks/>
        [XmlElement( "memory")]
        public MemoryType[] memory {
            get {
                return memoryField;
            }
            set {
                memoryField = value;
            }
        }
    
        /// <remarks/>
        [XmlElement( "algorithm")]
        public Algorithm[] algorithm {
            get {
                return algorithmField;
            }
            set {
                algorithmField = value;
            }
        }
    
        /// <remarks/>
        [XmlElement( "book")]
        public BookType[] book {
            get {
                return bookField;
            }
            set {
                bookField = value;
            }
        }
    
        /// <remarks/>
        [XmlElement( "description")]
        public DescriptionType[] description {
            get {
                return descriptionField;
            }
            set {
                descriptionField = value;
            }
        }
    
        /// <remarks/>
        [XmlElement( "feature")]
        public DeviceFeatureType[] feature {
            get {
                return featureField;
            }
            set {
                featureField = value;
            }
        }
    
        /// <remarks/>
        [XmlElement( "environment")]
        public EnvironmentType[] environment {
            get {
                return environmentField;
            }
            set {
                environmentField = value;
            }
        }
    
        /// <remarks/>
        [XmlElement( "debugport")]
        public DebugPort[] debugport {
            get {
                return debugportField;
            }
            set {
                debugportField = value;
            }
        }
    
        /// <remarks/>
        [XmlElement( "debug")]
        public Debug[] debug {
            get {
                return debugField;
            }
            set {
                debugField = value;
            }
        }
    
        /// <remarks/>
        [XmlElement( "trace")]
        public TraceType[] trace {
            get {
                return traceField;
            }
            set {
                traceField = value;
            }
        }
    
        /// <remarks/>
        [XmlElement( "debugvars")]
        public DebugVarsType[] debugvars {
            get {
                return debugvarsField;
            }
            set {
                debugvarsField = value;
            }
        }
    
        /// <remarks/>
        [XmlElement( "sequences")]
        public SequencesType[] sequences {
            get {
                return sequencesField;
            }
            set {
                sequencesField = value;
            }
        }
    
        /// <remarks/>
        [XmlElement( "variant")]
        public DeviceTypeVariant[] variant {
            get {
                return variantField;
            }
            set {
                variantField = value;
            }
        }
    
        /// <remarks/>
        [XmlAttribute( Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string Dname {
            get {
                return dnameField;
            }
            set {
                dnameField = value;
            }
        }
    }
}