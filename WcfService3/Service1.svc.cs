using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService3.BaseClass;
using WcfService3.DataBase;

namespace WcfService3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void AddHotel(Hotel hotel)
        {
            using (HotelDb hotelDb = new HotelDb())
            {
                hotelDb.Hotels.Add(hotel);
                hotelDb.SaveChanges();
            }
            
        }

        public Country[] GetCountries()
        {
            using (HotelDb hotel = new HotelDb())
            {
               return hotel.Countries.ToArray();
            }
        }

        public TypeApartments[] GetTypeApartments()
        {
            using (HotelDb hotel = new HotelDb())
            {
                return hotel.TypeApartments.ToArray();
            }
        }

        public bool HotelIsReal(Hotel hotel)
        {
           
            using (HotelDb hotelDb = new HotelDb())
            {
                return 1>hotelDb.Hotels.Where(a => a.Name == hotel.Name).Count();
            }
            
        }
    }
}
