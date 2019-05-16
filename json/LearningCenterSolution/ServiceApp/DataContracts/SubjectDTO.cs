using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServiceApp
{
    [DataContract]
    public class SubjectDTO 
    {
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public int Credits { get; set; }
        [DataMember]
        public int? Hours { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
    }
}