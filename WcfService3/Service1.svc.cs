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

    public struct DateLength
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

    }

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void AddHotel(Hotel hotel)
        {
            using (HotelDb hotelDb = new HotelDb())
            {
                hotel.Address.Country = hotelDb.Countries.Where(a => a.Name == hotel.Address.Country.Name).First();
                hotelDb.Hotels.Add(hotel);
                hotelDb.SaveChanges();
            }

        }

        public void AddRoom(string nameHotel, Apartament apartament)
        {
            using (HotelDb hotelDb = new HotelDb())
            {
                apartament.Hotel = hotelDb.Hotels.Where(a => a.Name == nameHotel).First();
                apartament.TypeApartment = hotelDb.TypeApartments.Where(a => a.Type == apartament.TypeApartment.Type).First();
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
                var client = hotelDb.Clients.Where(d => d.FirstDate > first);
                // var clientApartament = hotelDb.Apartaments.Any(g=>client.Select(h1=>h1.Id) == g.Clients.Select(h2=>h2.Id));
                var apartament =hotelDb.Apartaments.Where(a => a.Clients.Where(c => client.Where(c1 => c1.Id == c.Id).Count() == 0).Count() == 0).ToArray();
                //for (int i = 0; i < client; i++)
                //{
                //    for (int i = 0; i < length; i++)
                //    {
                //
                //    }
                //}
                // var apart = hotelDb.Clients.Where( c => c.)
                
                hotelDb.Configuration.ProxyCreationEnabled = false;
                return apartament.ToArray();
                //return apart.ToArray();
               //return new 

            }
        }

        public Country[] GetCountries()
        {
            using (HotelDb hotel = new HotelDb())
            {
                hotel.Configuration.ProxyCreationEnabled = false;
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

        public TypeApartment[] GetTypeApartments()
        {
            using (HotelDb hotel = new HotelDb())
            {
                hotel.Configuration.ProxyCreationEnabled = false;
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
