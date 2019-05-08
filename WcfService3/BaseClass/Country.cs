using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService3.BaseClass
{
    public class Country
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual IEnumerable<Addres> Addreses { get; set; }
    }
}