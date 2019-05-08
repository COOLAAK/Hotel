using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WcfService3.BaseClass;

namespace WcfService3.DataBase
{
    public class HotelDb : DbContext
    {
        public HotelDb()
            : base("name=HotelDb")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Apartament> Apartaments{ get; set; }
        public virtual DbSet<Addres> Addres { get; set; }
        public virtual DbSet<Client> Clients{ get; set; }
        public virtual DbSet<Country> Countries{ get; set; }
        public virtual DbSet<Hotel> Hotels{ get; set; }
        public virtual DbSet<TypeApartments> TypeApartments{ get; set; }
        public virtual DbSet<User> Users{ get; set; }

    }
}