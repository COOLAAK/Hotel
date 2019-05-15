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
                hotel.Addres.Country = hotelDb.Countries.Where(a => a.Name == hotel.Addres.Country.Name).First();
                hotelDb.Hotels.Add(hotel);
                hotelDb.SaveChanges();
            }

        }

        public void AddRoom(string nameHotel, Apartament apartament)
        {
            using (HotelDb hotelDb = new HotelDb())
            {
                apartament.Hotel = hotelDb.Hotels.Where(a => a.Name == nameHotel).First();
                apartament.TypeApartments = hotelDb.TypeApartments.Where(a => a.Type == apartament.TypeApartments.Type).First();
                hotelDb.Apartaments.Add(apartament);
                hotelDb.SaveChanges();
            }
        }

        public Apartament[] GetApartaments(DateTime first, DateTime Second, string name)
        {
               Hotel hot;
            using (HotelDb hotelDb = new HotelDb())
            {
                
                        hot = hotelDb.Hotels.Where(a => a.Name == name).First();

               var apart= hotelDb.Apartaments.Where(q => q.Hotel == hot||(q.Clients.Where(d=>(d.FirstDate>first || d.FirstDate<Second) || (d.LastDate > first || d.LastDate < first) || (d.FirstDate<first|| d.LastDate>Second)).Count()==0));
                return apart.ToArray();
            }
        }

        public Country[] GetCountries()
        {
            using (HotelDb hotel = new HotelDb())
            {
                return hotel.Countries.ToArray();
            }
        }



        public string[] GetHotelName()
        {
            List<string> HotelName = new List<string>();
            using (HotelDb hotelDb = new HotelDb())
            {
                foreach (var item in hotelDb.Hotels.ToList())
                {
                    HotelName.Add(item.Name);
                }
            }
            return HotelName.ToArray();
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
                return 1 <= hotelDb.Hotels.Where(a => a.Name == hotel.Name).Count();
            }

        }
    }
}
