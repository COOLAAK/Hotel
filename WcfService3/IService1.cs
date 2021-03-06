﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService3.BaseClass;
using WcfService3.DTO;

namespace WcfService3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Country[] GetCountries();
        [OperationContract]
        TypeApartment[] GetTypeApartments();
        [OperationContract]
        bool HotelIsReal(Hotel hotel);
        [OperationContract]
        void AddHotel(Hotel hotel);
        [OperationContract]
        void AddRoom(string nameHotel, Apartament apartament);
        [OperationContract]
        string[] GetHotelName();
        [OperationContract]
        Apartamet_DTO[] GetApartaments(DateTime first, DateTime Second, string name);
        

    }



}
