using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService3.BaseClass
{
    public class Hotel
    {
        public int id { get; set; }
        public virtual Addres Addres { get; set; }
        public virtual IEnumerable<Apartament> Apartaments { get; set; }
    }
}