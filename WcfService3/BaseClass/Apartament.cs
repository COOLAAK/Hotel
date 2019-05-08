using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService3.BaseClass
{
    public class Apartament
    {
        public int id { get; set; }
        public int numb { get; set; }
        public int floor { get; set; }
        public int CountRoom { get; set; }
        public int CountLieu { get; set; }
        public virtual TypeApartments TypeApartments { get; set; }

    }
}