using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService3.BaseClass
{
    [DataContract]
    public class TypeApartments
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public virtual IEnumerable<Apartament> Apartament { get; set; }

    }
}