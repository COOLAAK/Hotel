using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService3.DTO
{
    [DataContract]
    [KnownType(typeof(BaseClass.User))]
    public class Apartamet_DTO
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
        public int RoomQuantity { get; set; }
        [DataMember]
        public int PlaceQuantity { get; set; }
        [DataMember]
        public string TypeApartament { get; set; }
        [DataMember]
        public string  Hotel { get; set; }
        [DataMember]
        public int[] ClientIds { get; set; }
    }
}