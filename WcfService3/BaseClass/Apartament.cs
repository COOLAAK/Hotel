using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService3.BaseClass
{
    [DataContract]
    public class Apartament
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Numb { get; set; }
        [DataMember]
        public int Floor { get; set; }
        [DataMember]
        public int Price { get; set; }
        [DataMember]
        public int CountRoom { get; set; }
        [DataMember]
        public int PlaceCount { get; set; }
        [DataMember]
        public virtual TypeApartment TypeApartment { get; set; }
        [DataMember]
        public virtual Hotel Hotel { get; set; }
        [DataMember]
        public virtual ICollection<Client> Clients { get; set; }

    }
}