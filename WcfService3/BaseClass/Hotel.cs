using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService3.BaseClass
{
    [DataContract]
    public class Hotel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public virtual Addres Addres { get; set; }
        [DataMember]
        public virtual IEnumerable<Apartament> Apartaments { get; set; }
    }
}