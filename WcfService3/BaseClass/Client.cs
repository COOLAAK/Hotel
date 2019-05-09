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
        public int CountPeople { get; set; }

        [DataMember]
        public virtual Hotel Hotel { get; set; }
        [DataMember]
        public virtual Apartament Apartament { get; set; }
        [DataMember]
        public virtual  User User { get; set; }
    }
}