using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WinFormsClientApp {

    
    public class SubjectData 
    {
        public List<SubjectDTO> Data { get; set; }
    }

    [XmlRoot]
    public class SubjectDTO
    {
        //[XmlElement]
        //public int ID { get; set; }
        [XmlElement]
        public string Name { get; set; }
        [XmlElement]
        public string Description { get; set; }
        [XmlElement]
        public string Code { get; set; }
        [XmlElement]
        public int Credits { get; set; }
        [XmlElement]
        public int? Hours { get; set; }
        //[XmlElement]
        //public bool IsActive { get; set; }
    }
}
