using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService3.BaseClass
{
    [DataContract]
    public class TypeApartment
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public virtual ICollection<Apartament> Apartaments { get; set; }

    }
}