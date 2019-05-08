using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService3.BaseClass
{
    public class Client
    {
        public int id { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime LastDate { get; set; }

        public int CountPeople { get; set; }

        public virtual Hotel Hotel { get; set; }
        public virtual Apartament  Apartament{ get; set; }
        public User User { get; set; }
    }
}