using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService3.BaseClass
{
    public class Account
    {
        public int id { get; set; }
        public string Login { get; set; }
        public string Passwd { get; set; }
        public int IsDemon { get; set; }
        public virtual User User { get; set; }
    }
}