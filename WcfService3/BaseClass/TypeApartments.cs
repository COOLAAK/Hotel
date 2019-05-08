using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService3.BaseClass
{
    public class TypeApartments
    {
        public int id { get; set; }
        public string type { get; set; }

        public virtual Apartament Apartament { get; set; }

    }
}