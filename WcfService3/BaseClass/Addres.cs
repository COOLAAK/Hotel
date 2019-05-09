using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService3.BaseClass
{
    [DataContract]
    public class Addres
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string Street { get; set; }

        [DataMember]
        public virtual Country Country { get; set; }
        [DataMember]
        public virtual  IEnumerable<Hotel> Hotel { get; set; }

    }
}