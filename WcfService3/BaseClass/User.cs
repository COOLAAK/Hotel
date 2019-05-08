using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService3.BaseClass
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string  surname { get; set; }
        public string Phone { get; set; }
        public string email { get; set; }

        public Account Account { get; set; }
    }
}