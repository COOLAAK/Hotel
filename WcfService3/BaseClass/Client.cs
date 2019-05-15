using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService3.BaseClass
{
    [DataContract]
    public class Client
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime FirstDate { get; set; }
        [DataMember]
        public DateTime LastDate { get; set; }
        [DataMember]
        public virtual IEnumerable<Apartament> Apartament { get; set; }
        [DataMember]
        public virtual User User { get; set; }
    }
}