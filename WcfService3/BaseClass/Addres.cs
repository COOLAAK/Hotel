using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService3.BaseClass
{
    public class Addres
    {
        public int id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }

        public virtual Country Country { get; set; }

    }
}