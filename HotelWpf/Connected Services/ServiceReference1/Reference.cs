﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelWpf.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Country", Namespace="http://schemas.datacontract.org/2004/07/WcfService3.BaseClass")]
    [System.SerializableAttribute()]
    public partial class Country : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HotelWpf.ServiceReference1.Addres[] AddresesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HotelWpf.ServiceReference1.Addres[] Addreses {
            get {
                return this.AddresesField;
            }
            set {
                if ((object.ReferenceEquals(this.AddresesField, value) != true)) {
                    this.AddresesField = value;
                    this.RaisePropertyChanged("Addreses");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Code {
            get {
                return this.CodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeField, value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Addres", Namespace="http://schemas.datacontract.org/2004/07/WcfService3.BaseClass")]
    [System.SerializableAttribute()]
    public partial class Addres : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HotelWpf.ServiceReference1.Country CountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HotelWpf.ServiceReference1.Hotel[] HotelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StreetField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HotelWpf.ServiceReference1.Country Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HotelWpf.ServiceReference1.Hotel[] Hotel {
            get {
                return this.HotelField;
            }
            set {
                if ((object.ReferenceEquals(this.HotelField, value) != true)) {
                    this.HotelField = value;
                    this.RaisePropertyChanged("Hotel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Street {
            get {
                return this.StreetField;
            }
            set {
                if ((object.ReferenceEquals(this.StreetField, value) != true)) {
                    this.StreetField = value;
                    this.RaisePropertyChanged("Street");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Hotel", Namespace="http://schemas.datacontract.org/2004/07/WcfService3.BaseClass")]
    [System.SerializableAttribute()]
    public partial class Hotel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HotelWpf.ServiceReference1.Addres AddresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HotelWpf.ServiceReference1.Apartament[] ApartamentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HotelWpf.ServiceReference1.Addres Addres {
            get {
                return this.AddresField;
            }
            set {
                if ((object.ReferenceEquals(this.AddresField, value) != true)) {
                    this.AddresField = value;
                    this.RaisePropertyChanged("Addres");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HotelWpf.ServiceReference1.Apartament[] Apartaments {
            get {
                return this.ApartamentsField;
            }
            set {
                if ((object.ReferenceEquals(this.ApartamentsField, value) != true)) {
                    this.ApartamentsField = value;
                    this.RaisePropertyChanged("Apartaments");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Apartament", Namespace="http://schemas.datacontract.org/2004/07/WcfService3.BaseClass")]
    [System.SerializableAttribute()]
    public partial class Apartament : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CountLieuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CountRoomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FloorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HotelWpf.ServiceReference1.Hotel HotelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumbField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HotelWpf.ServiceReference1.TypeApartments TypeApartmentsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CountLieu {
            get {
                return this.CountLieuField;
            }
            set {
                if ((this.CountLieuField.Equals(value) != true)) {
                    this.CountLieuField = value;
                    this.RaisePropertyChanged("CountLieu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CountRoom {
            get {
                return this.CountRoomField;
            }
            set {
                if ((this.CountRoomField.Equals(value) != true)) {
                    this.CountRoomField = value;
                    this.RaisePropertyChanged("CountRoom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Floor {
            get {
                return this.FloorField;
            }
            set {
                if ((this.FloorField.Equals(value) != true)) {
                    this.FloorField = value;
                    this.RaisePropertyChanged("Floor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HotelWpf.ServiceReference1.Hotel Hotel {
            get {
                return this.HotelField;
            }
            set {
                if ((object.ReferenceEquals(this.HotelField, value) != true)) {
                    this.HotelField = value;
                    this.RaisePropertyChanged("Hotel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Numb {
            get {
                return this.NumbField;
            }
            set {
                if ((this.NumbField.Equals(value) != true)) {
                    this.NumbField = value;
                    this.RaisePropertyChanged("Numb");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HotelWpf.ServiceReference1.TypeApartments TypeApartments {
            get {
                return this.TypeApartmentsField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeApartmentsField, value) != true)) {
                    this.TypeApartmentsField = value;
                    this.RaisePropertyChanged("TypeApartments");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TypeApartments", Namespace="http://schemas.datacontract.org/2004/07/WcfService3.BaseClass")]
    [System.SerializableAttribute()]
    public partial class TypeApartments : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HotelWpf.ServiceReference1.Apartament[] ApartamentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HotelWpf.ServiceReference1.Apartament[] Apartament {
            get {
                return this.ApartamentField;
            }
            set {
                if ((object.ReferenceEquals(this.ApartamentField, value) != true)) {
                    this.ApartamentField = value;
                    this.RaisePropertyChanged("Apartament");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCountries", ReplyAction="http://tempuri.org/IService1/GetCountriesResponse")]
        HotelWpf.ServiceReference1.Country[] GetCountries();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCountries", ReplyAction="http://tempuri.org/IService1/GetCountriesResponse")]
        System.Threading.Tasks.Task<HotelWpf.ServiceReference1.Country[]> GetCountriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTypeApartments", ReplyAction="http://tempuri.org/IService1/GetTypeApartmentsResponse")]
        HotelWpf.ServiceReference1.TypeApartments[] GetTypeApartments();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTypeApartments", ReplyAction="http://tempuri.org/IService1/GetTypeApartmentsResponse")]
        System.Threading.Tasks.Task<HotelWpf.ServiceReference1.TypeApartments[]> GetTypeApartmentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HotelIsReal", ReplyAction="http://tempuri.org/IService1/HotelIsRealResponse")]
        bool HotelIsReal(HotelWpf.ServiceReference1.Hotel hotel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HotelIsReal", ReplyAction="http://tempuri.org/IService1/HotelIsRealResponse")]
        System.Threading.Tasks.Task<bool> HotelIsRealAsync(HotelWpf.ServiceReference1.Hotel hotel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddHotel", ReplyAction="http://tempuri.org/IService1/AddHotelResponse")]
        void AddHotel(HotelWpf.ServiceReference1.Hotel hotel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddHotel", ReplyAction="http://tempuri.org/IService1/AddHotelResponse")]
        System.Threading.Tasks.Task AddHotelAsync(HotelWpf.ServiceReference1.Hotel hotel);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : HotelWpf.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<HotelWpf.ServiceReference1.IService1>, HotelWpf.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public HotelWpf.ServiceReference1.Country[] GetCountries() {
            return base.Channel.GetCountries();
        }
        
        public System.Threading.Tasks.Task<HotelWpf.ServiceReference1.Country[]> GetCountriesAsync() {
            return base.Channel.GetCountriesAsync();
        }
        
        public HotelWpf.ServiceReference1.TypeApartments[] GetTypeApartments() {
            return base.Channel.GetTypeApartments();
        }
        
        public System.Threading.Tasks.Task<HotelWpf.ServiceReference1.TypeApartments[]> GetTypeApartmentsAsync() {
            return base.Channel.GetTypeApartmentsAsync();
        }
        
        public bool HotelIsReal(HotelWpf.ServiceReference1.Hotel hotel) {
            return base.Channel.HotelIsReal(hotel);
        }
        
        public System.Threading.Tasks.Task<bool> HotelIsRealAsync(HotelWpf.ServiceReference1.Hotel hotel) {
            return base.Channel.HotelIsRealAsync(hotel);
        }
        
        public void AddHotel(HotelWpf.ServiceReference1.Hotel hotel) {
            base.Channel.AddHotel(hotel);
        }
        
        public System.Threading.Tasks.Task AddHotelAsync(HotelWpf.ServiceReference1.Hotel hotel) {
            return base.Channel.AddHotelAsync(hotel);
        }
    }
}
