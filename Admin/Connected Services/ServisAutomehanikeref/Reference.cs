﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Admin.ServisAutomehanikeref {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Korisnik", Namespace="http://schemas.datacontract.org/2004/07/ServisAutomehanikeISPIT")]
    [System.SerializableAttribute()]
    public partial class Korisnik : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string korisnicko_imeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lozinkaField;
        
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
        public string korisnicko_ime {
            get {
                return this.korisnicko_imeField;
            }
            set {
                if ((object.ReferenceEquals(this.korisnicko_imeField, value) != true)) {
                    this.korisnicko_imeField = value;
                    this.RaisePropertyChanged("korisnicko_ime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lozinka {
            get {
                return this.lozinkaField;
            }
            set {
                if ((object.ReferenceEquals(this.lozinkaField, value) != true)) {
                    this.lozinkaField = value;
                    this.RaisePropertyChanged("lozinka");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Automobil", Namespace="http://schemas.datacontract.org/2004/07/ServisAutomehanikeISPIT")]
    [System.SerializableAttribute()]
    public partial class Automobil : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal cena_popravkeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_popravkeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string korisnicko_imeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string podaciField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string statusField;
        
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
        public decimal cena_popravke {
            get {
                return this.cena_popravkeField;
            }
            set {
                if ((this.cena_popravkeField.Equals(value) != true)) {
                    this.cena_popravkeField = value;
                    this.RaisePropertyChanged("cena_popravke");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_popravke {
            get {
                return this.id_popravkeField;
            }
            set {
                if ((this.id_popravkeField.Equals(value) != true)) {
                    this.id_popravkeField = value;
                    this.RaisePropertyChanged("id_popravke");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string korisnicko_ime {
            get {
                return this.korisnicko_imeField;
            }
            set {
                if ((object.ReferenceEquals(this.korisnicko_imeField, value) != true)) {
                    this.korisnicko_imeField = value;
                    this.RaisePropertyChanged("korisnicko_ime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string podaci {
            get {
                return this.podaciField;
            }
            set {
                if ((object.ReferenceEquals(this.podaciField, value) != true)) {
                    this.podaciField = value;
                    this.RaisePropertyChanged("podaci");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string status {
            get {
                return this.statusField;
            }
            set {
                if ((object.ReferenceEquals(this.statusField, value) != true)) {
                    this.statusField = value;
                    this.RaisePropertyChanged("status");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Popravka", Namespace="http://schemas.datacontract.org/2004/07/ServisAutomehanikeISPIT")]
    [System.SerializableAttribute()]
    public partial class Popravka : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal cena_delaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string deoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_popravkeField;
        
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
        public decimal cena_dela {
            get {
                return this.cena_delaField;
            }
            set {
                if ((this.cena_delaField.Equals(value) != true)) {
                    this.cena_delaField = value;
                    this.RaisePropertyChanged("cena_dela");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string deo {
            get {
                return this.deoField;
            }
            set {
                if ((object.ReferenceEquals(this.deoField, value) != true)) {
                    this.deoField = value;
                    this.RaisePropertyChanged("deo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_popravke {
            get {
                return this.id_popravkeField;
            }
            set {
                if ((this.id_popravkeField.Equals(value) != true)) {
                    this.id_popravkeField = value;
                    this.RaisePropertyChanged("id_popravke");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServisAutomehanikeref.IServisOperater")]
    public interface IServisOperater {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisOperater/napraviKorisnika", ReplyAction="http://tempuri.org/IServisOperater/napraviKorisnikaResponse")]
        Admin.ServisAutomehanikeref.Korisnik napraviKorisnika(Admin.ServisAutomehanikeref.Korisnik korisnik);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisOperater/napraviKorisnika", ReplyAction="http://tempuri.org/IServisOperater/napraviKorisnikaResponse")]
        System.Threading.Tasks.Task<Admin.ServisAutomehanikeref.Korisnik> napraviKorisnikaAsync(Admin.ServisAutomehanikeref.Korisnik korisnik);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisOperater/prijavljivanje", ReplyAction="http://tempuri.org/IServisOperater/prijavljivanjeResponse")]
        bool prijavljivanje(string korisnicko_ime, string lozinka);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisOperater/prijavljivanje", ReplyAction="http://tempuri.org/IServisOperater/prijavljivanjeResponse")]
        System.Threading.Tasks.Task<bool> prijavljivanjeAsync(string korisnicko_ime, string lozinka);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisOperater/napraviAutomobil", ReplyAction="http://tempuri.org/IServisOperater/napraviAutomobilResponse")]
        Admin.ServisAutomehanikeref.Automobil napraviAutomobil(Admin.ServisAutomehanikeref.Automobil automobil);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisOperater/napraviAutomobil", ReplyAction="http://tempuri.org/IServisOperater/napraviAutomobilResponse")]
        System.Threading.Tasks.Task<Admin.ServisAutomehanikeref.Automobil> napraviAutomobilAsync(Admin.ServisAutomehanikeref.Automobil automobil);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisOperater/napraviPopravku", ReplyAction="http://tempuri.org/IServisOperater/napraviPopravkuResponse")]
        bool napraviPopravku(Admin.ServisAutomehanikeref.Popravka popravka);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisOperater/napraviPopravku", ReplyAction="http://tempuri.org/IServisOperater/napraviPopravkuResponse")]
        System.Threading.Tasks.Task<bool> napraviPopravkuAsync(Admin.ServisAutomehanikeref.Popravka popravka);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisOperater/azuriranjeCeneDelova", ReplyAction="http://tempuri.org/IServisOperater/azuriranjeCeneDelovaResponse")]
        bool azuriranjeCeneDelova(int id_popravke, decimal novacena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisOperater/azuriranjeCeneDelova", ReplyAction="http://tempuri.org/IServisOperater/azuriranjeCeneDelovaResponse")]
        System.Threading.Tasks.Task<bool> azuriranjeCeneDelovaAsync(int id_popravke, decimal novacena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisOperater/deserijalizujPodatke", ReplyAction="http://tempuri.org/IServisOperater/deserijalizujPodatkeResponse")]
        string deserijalizujPodatke();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisOperater/deserijalizujPodatke", ReplyAction="http://tempuri.org/IServisOperater/deserijalizujPodatkeResponse")]
        System.Threading.Tasks.Task<string> deserijalizujPodatkeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisOperater/deserijalizujKorisnike", ReplyAction="http://tempuri.org/IServisOperater/deserijalizujKorisnikeResponse")]
        string deserijalizujKorisnike();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisOperater/deserijalizujKorisnike", ReplyAction="http://tempuri.org/IServisOperater/deserijalizujKorisnikeResponse")]
        System.Threading.Tasks.Task<string> deserijalizujKorisnikeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisOperater/deserijalizujPopravke", ReplyAction="http://tempuri.org/IServisOperater/deserijalizujPopravkeResponse")]
        string deserijalizujPopravke();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisOperater/deserijalizujPopravke", ReplyAction="http://tempuri.org/IServisOperater/deserijalizujPopravkeResponse")]
        System.Threading.Tasks.Task<string> deserijalizujPopravkeAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServisOperaterChannel : Admin.ServisAutomehanikeref.IServisOperater, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServisOperaterClient : System.ServiceModel.ClientBase<Admin.ServisAutomehanikeref.IServisOperater>, Admin.ServisAutomehanikeref.IServisOperater {
        
        public ServisOperaterClient() {
        }
        
        public ServisOperaterClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServisOperaterClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServisOperaterClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServisOperaterClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Admin.ServisAutomehanikeref.Korisnik napraviKorisnika(Admin.ServisAutomehanikeref.Korisnik korisnik) {
            return base.Channel.napraviKorisnika(korisnik);
        }
        
        public System.Threading.Tasks.Task<Admin.ServisAutomehanikeref.Korisnik> napraviKorisnikaAsync(Admin.ServisAutomehanikeref.Korisnik korisnik) {
            return base.Channel.napraviKorisnikaAsync(korisnik);
        }
        
        public bool prijavljivanje(string korisnicko_ime, string lozinka) {
            return base.Channel.prijavljivanje(korisnicko_ime, lozinka);
        }
        
        public System.Threading.Tasks.Task<bool> prijavljivanjeAsync(string korisnicko_ime, string lozinka) {
            return base.Channel.prijavljivanjeAsync(korisnicko_ime, lozinka);
        }
        
        public Admin.ServisAutomehanikeref.Automobil napraviAutomobil(Admin.ServisAutomehanikeref.Automobil automobil) {
            return base.Channel.napraviAutomobil(automobil);
        }
        
        public System.Threading.Tasks.Task<Admin.ServisAutomehanikeref.Automobil> napraviAutomobilAsync(Admin.ServisAutomehanikeref.Automobil automobil) {
            return base.Channel.napraviAutomobilAsync(automobil);
        }
        
        public bool napraviPopravku(Admin.ServisAutomehanikeref.Popravka popravka) {
            return base.Channel.napraviPopravku(popravka);
        }
        
        public System.Threading.Tasks.Task<bool> napraviPopravkuAsync(Admin.ServisAutomehanikeref.Popravka popravka) {
            return base.Channel.napraviPopravkuAsync(popravka);
        }
        
        public bool azuriranjeCeneDelova(int id_popravke, decimal novacena) {
            return base.Channel.azuriranjeCeneDelova(id_popravke, novacena);
        }
        
        public System.Threading.Tasks.Task<bool> azuriranjeCeneDelovaAsync(int id_popravke, decimal novacena) {
            return base.Channel.azuriranjeCeneDelovaAsync(id_popravke, novacena);
        }
        
        public string deserijalizujPodatke() {
            return base.Channel.deserijalizujPodatke();
        }
        
        public System.Threading.Tasks.Task<string> deserijalizujPodatkeAsync() {
            return base.Channel.deserijalizujPodatkeAsync();
        }
        
        public string deserijalizujKorisnike() {
            return base.Channel.deserijalizujKorisnike();
        }
        
        public System.Threading.Tasks.Task<string> deserijalizujKorisnikeAsync() {
            return base.Channel.deserijalizujKorisnikeAsync();
        }
        
        public string deserijalizujPopravke() {
            return base.Channel.deserijalizujPopravke();
        }
        
        public System.Threading.Tasks.Task<string> deserijalizujPopravkeAsync() {
            return base.Channel.deserijalizujPopravkeAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServisAutomehanikeref.IServisKlijent")]
    public interface IServisKlijent {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisKlijent/prijavljivanjeKlijenta", ReplyAction="http://tempuri.org/IServisKlijent/prijavljivanjeKlijentaResponse")]
        bool prijavljivanjeKlijenta(string korisnickoime, string lozinka);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisKlijent/prijavljivanjeKlijenta", ReplyAction="http://tempuri.org/IServisKlijent/prijavljivanjeKlijentaResponse")]
        System.Threading.Tasks.Task<bool> prijavljivanjeKlijentaAsync(string korisnickoime, string lozinka);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisKlijent/prikazPodatakaICena", ReplyAction="http://tempuri.org/IServisKlijent/prikazPodatakaICenaResponse")]
        string prikazPodatakaICena(string korisnickoime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisKlijent/prikazPodatakaICena", ReplyAction="http://tempuri.org/IServisKlijent/prikazPodatakaICenaResponse")]
        System.Threading.Tasks.Task<string> prikazPodatakaICenaAsync(string korisnickoime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisKlijent/deserijalizuj", ReplyAction="http://tempuri.org/IServisKlijent/deserijalizujResponse")]
        string deserijalizuj(string korisnickomime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisKlijent/deserijalizuj", ReplyAction="http://tempuri.org/IServisKlijent/deserijalizujResponse")]
        System.Threading.Tasks.Task<string> deserijalizujAsync(string korisnickomime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServisKlijentChannel : Admin.ServisAutomehanikeref.IServisKlijent, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServisKlijentClient : System.ServiceModel.ClientBase<Admin.ServisAutomehanikeref.IServisKlijent>, Admin.ServisAutomehanikeref.IServisKlijent {
        
        public ServisKlijentClient() {
        }
        
        public ServisKlijentClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServisKlijentClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServisKlijentClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServisKlijentClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool prijavljivanjeKlijenta(string korisnickoime, string lozinka) {
            return base.Channel.prijavljivanjeKlijenta(korisnickoime, lozinka);
        }
        
        public System.Threading.Tasks.Task<bool> prijavljivanjeKlijentaAsync(string korisnickoime, string lozinka) {
            return base.Channel.prijavljivanjeKlijentaAsync(korisnickoime, lozinka);
        }
        
        public string prikazPodatakaICena(string korisnickoime) {
            return base.Channel.prikazPodatakaICena(korisnickoime);
        }
        
        public System.Threading.Tasks.Task<string> prikazPodatakaICenaAsync(string korisnickoime) {
            return base.Channel.prikazPodatakaICenaAsync(korisnickoime);
        }
        
        public string deserijalizuj(string korisnickomime) {
            return base.Channel.deserijalizuj(korisnickomime);
        }
        
        public System.Threading.Tasks.Task<string> deserijalizujAsync(string korisnickomime) {
            return base.Channel.deserijalizujAsync(korisnickomime);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServisAutomehanikeref.IServisAdmin")]
    public interface IServisAdmin {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisAdmin/prijavljivanjeAdmina", ReplyAction="http://tempuri.org/IServisAdmin/prijavljivanjeAdminaResponse")]
        bool prijavljivanjeAdmina(string korisnickoime, string lozinka);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisAdmin/prijavljivanjeAdmina", ReplyAction="http://tempuri.org/IServisAdmin/prijavljivanjeAdminaResponse")]
        System.Threading.Tasks.Task<bool> prijavljivanjeAdminaAsync(string korisnickoime, string lozinka);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisAdmin/kreirajKorisnika", ReplyAction="http://tempuri.org/IServisAdmin/kreirajKorisnikaResponse")]
        Admin.ServisAutomehanikeref.Korisnik kreirajKorisnika(Admin.ServisAutomehanikeref.Korisnik korisnik);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisAdmin/kreirajKorisnika", ReplyAction="http://tempuri.org/IServisAdmin/kreirajKorisnikaResponse")]
        System.Threading.Tasks.Task<Admin.ServisAutomehanikeref.Korisnik> kreirajKorisnikaAsync(Admin.ServisAutomehanikeref.Korisnik korisnik);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisAdmin/izbrisiKorisnika", ReplyAction="http://tempuri.org/IServisAdmin/izbrisiKorisnikaResponse")]
        bool izbrisiKorisnika(string korisnickoime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisAdmin/izbrisiKorisnika", ReplyAction="http://tempuri.org/IServisAdmin/izbrisiKorisnikaResponse")]
        System.Threading.Tasks.Task<bool> izbrisiKorisnikaAsync(string korisnickoime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisAdmin/deserijalizujKorisnikeAdmin", ReplyAction="http://tempuri.org/IServisAdmin/deserijalizujKorisnikeAdminResponse")]
        string deserijalizujKorisnikeAdmin();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisAdmin/deserijalizujKorisnikeAdmin", ReplyAction="http://tempuri.org/IServisAdmin/deserijalizujKorisnikeAdminResponse")]
        System.Threading.Tasks.Task<string> deserijalizujKorisnikeAdminAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisAdmin/AzurirajKorisnika", ReplyAction="http://tempuri.org/IServisAdmin/AzurirajKorisnikaResponse")]
        bool AzurirajKorisnika(string korisnikZaAzuriranje, string korisnickoime, string lozinka);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisAdmin/AzurirajKorisnika", ReplyAction="http://tempuri.org/IServisAdmin/AzurirajKorisnikaResponse")]
        System.Threading.Tasks.Task<bool> AzurirajKorisnikaAsync(string korisnikZaAzuriranje, string korisnickoime, string lozinka);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisAdmin/kreirajAutomobil", ReplyAction="http://tempuri.org/IServisAdmin/kreirajAutomobilResponse")]
        Admin.ServisAutomehanikeref.Automobil kreirajAutomobil(Admin.ServisAutomehanikeref.Automobil automobil);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisAdmin/kreirajAutomobil", ReplyAction="http://tempuri.org/IServisAdmin/kreirajAutomobilResponse")]
        System.Threading.Tasks.Task<Admin.ServisAutomehanikeref.Automobil> kreirajAutomobilAsync(Admin.ServisAutomehanikeref.Automobil automobil);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisAdmin/izbrisiAutomobil", ReplyAction="http://tempuri.org/IServisAdmin/izbrisiAutomobilResponse")]
        bool izbrisiAutomobil(int id_automobila);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisAdmin/izbrisiAutomobil", ReplyAction="http://tempuri.org/IServisAdmin/izbrisiAutomobilResponse")]
        System.Threading.Tasks.Task<bool> izbrisiAutomobilAsync(int id_automobila);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisAdmin/azurirajAutomobil", ReplyAction="http://tempuri.org/IServisAdmin/azurirajAutomobilResponse")]
        bool azurirajAutomobil(int idautomobila, string podaci, string status, string korisnickoime, decimal cena_popravke);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisAdmin/azurirajAutomobil", ReplyAction="http://tempuri.org/IServisAdmin/azurirajAutomobilResponse")]
        System.Threading.Tasks.Task<bool> azurirajAutomobilAsync(int idautomobila, string podaci, string status, string korisnickoime, decimal cena_popravke);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisAdmin/deserijalizujAutomobilAzuriranje", ReplyAction="http://tempuri.org/IServisAdmin/deserijalizujAutomobilAzuriranjeResponse")]
        string deserijalizujAutomobilAzuriranje();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisAdmin/deserijalizujAutomobilAzuriranje", ReplyAction="http://tempuri.org/IServisAdmin/deserijalizujAutomobilAzuriranjeResponse")]
        System.Threading.Tasks.Task<string> deserijalizujAutomobilAzuriranjeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisAdmin/kreirajPopravku", ReplyAction="http://tempuri.org/IServisAdmin/kreirajPopravkuResponse")]
        bool kreirajPopravku(Admin.ServisAutomehanikeref.Popravka popravka);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisAdmin/kreirajPopravku", ReplyAction="http://tempuri.org/IServisAdmin/kreirajPopravkuResponse")]
        System.Threading.Tasks.Task<bool> kreirajPopravkuAsync(Admin.ServisAutomehanikeref.Popravka popravka);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisAdmin/izbrisiPopravku", ReplyAction="http://tempuri.org/IServisAdmin/izbrisiPopravkuResponse")]
        bool izbrisiPopravku(int idpopravke);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisAdmin/izbrisiPopravku", ReplyAction="http://tempuri.org/IServisAdmin/izbrisiPopravkuResponse")]
        System.Threading.Tasks.Task<bool> izbrisiPopravkuAsync(int idpopravke);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisAdmin/azurirajPopravku", ReplyAction="http://tempuri.org/IServisAdmin/azurirajPopravkuResponse")]
        bool azurirajPopravku(int idpopravkeAzuriranje, string deo, decimal cena_dela);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisAdmin/azurirajPopravku", ReplyAction="http://tempuri.org/IServisAdmin/azurirajPopravkuResponse")]
        System.Threading.Tasks.Task<bool> azurirajPopravkuAsync(int idpopravkeAzuriranje, string deo, decimal cena_dela);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisAdmin/deserijalizujPopravkuAzuriranje", ReplyAction="http://tempuri.org/IServisAdmin/deserijalizujPopravkuAzuriranjeResponse")]
        string deserijalizujPopravkuAzuriranje();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServisAdmin/deserijalizujPopravkuAzuriranje", ReplyAction="http://tempuri.org/IServisAdmin/deserijalizujPopravkuAzuriranjeResponse")]
        System.Threading.Tasks.Task<string> deserijalizujPopravkuAzuriranjeAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServisAdminChannel : Admin.ServisAutomehanikeref.IServisAdmin, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServisAdminClient : System.ServiceModel.ClientBase<Admin.ServisAutomehanikeref.IServisAdmin>, Admin.ServisAutomehanikeref.IServisAdmin {
        
        public ServisAdminClient() {
        }
        
        public ServisAdminClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServisAdminClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServisAdminClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServisAdminClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool prijavljivanjeAdmina(string korisnickoime, string lozinka) {
            return base.Channel.prijavljivanjeAdmina(korisnickoime, lozinka);
        }
        
        public System.Threading.Tasks.Task<bool> prijavljivanjeAdminaAsync(string korisnickoime, string lozinka) {
            return base.Channel.prijavljivanjeAdminaAsync(korisnickoime, lozinka);
        }
        
        public Admin.ServisAutomehanikeref.Korisnik kreirajKorisnika(Admin.ServisAutomehanikeref.Korisnik korisnik) {
            return base.Channel.kreirajKorisnika(korisnik);
        }
        
        public System.Threading.Tasks.Task<Admin.ServisAutomehanikeref.Korisnik> kreirajKorisnikaAsync(Admin.ServisAutomehanikeref.Korisnik korisnik) {
            return base.Channel.kreirajKorisnikaAsync(korisnik);
        }
        
        public bool izbrisiKorisnika(string korisnickoime) {
            return base.Channel.izbrisiKorisnika(korisnickoime);
        }
        
        public System.Threading.Tasks.Task<bool> izbrisiKorisnikaAsync(string korisnickoime) {
            return base.Channel.izbrisiKorisnikaAsync(korisnickoime);
        }
        
        public string deserijalizujKorisnikeAdmin() {
            return base.Channel.deserijalizujKorisnikeAdmin();
        }
        
        public System.Threading.Tasks.Task<string> deserijalizujKorisnikeAdminAsync() {
            return base.Channel.deserijalizujKorisnikeAdminAsync();
        }
        
        public bool AzurirajKorisnika(string korisnikZaAzuriranje, string korisnickoime, string lozinka) {
            return base.Channel.AzurirajKorisnika(korisnikZaAzuriranje, korisnickoime, lozinka);
        }
        
        public System.Threading.Tasks.Task<bool> AzurirajKorisnikaAsync(string korisnikZaAzuriranje, string korisnickoime, string lozinka) {
            return base.Channel.AzurirajKorisnikaAsync(korisnikZaAzuriranje, korisnickoime, lozinka);
        }
        
        public Admin.ServisAutomehanikeref.Automobil kreirajAutomobil(Admin.ServisAutomehanikeref.Automobil automobil) {
            return base.Channel.kreirajAutomobil(automobil);
        }
        
        public System.Threading.Tasks.Task<Admin.ServisAutomehanikeref.Automobil> kreirajAutomobilAsync(Admin.ServisAutomehanikeref.Automobil automobil) {
            return base.Channel.kreirajAutomobilAsync(automobil);
        }
        
        public bool izbrisiAutomobil(int id_automobila) {
            return base.Channel.izbrisiAutomobil(id_automobila);
        }
        
        public System.Threading.Tasks.Task<bool> izbrisiAutomobilAsync(int id_automobila) {
            return base.Channel.izbrisiAutomobilAsync(id_automobila);
        }
        
        public bool azurirajAutomobil(int idautomobila, string podaci, string status, string korisnickoime, decimal cena_popravke) {
            return base.Channel.azurirajAutomobil(idautomobila, podaci, status, korisnickoime, cena_popravke);
        }
        
        public System.Threading.Tasks.Task<bool> azurirajAutomobilAsync(int idautomobila, string podaci, string status, string korisnickoime, decimal cena_popravke) {
            return base.Channel.azurirajAutomobilAsync(idautomobila, podaci, status, korisnickoime, cena_popravke);
        }
        
        public string deserijalizujAutomobilAzuriranje() {
            return base.Channel.deserijalizujAutomobilAzuriranje();
        }
        
        public System.Threading.Tasks.Task<string> deserijalizujAutomobilAzuriranjeAsync() {
            return base.Channel.deserijalizujAutomobilAzuriranjeAsync();
        }
        
        public bool kreirajPopravku(Admin.ServisAutomehanikeref.Popravka popravka) {
            return base.Channel.kreirajPopravku(popravka);
        }
        
        public System.Threading.Tasks.Task<bool> kreirajPopravkuAsync(Admin.ServisAutomehanikeref.Popravka popravka) {
            return base.Channel.kreirajPopravkuAsync(popravka);
        }
        
        public bool izbrisiPopravku(int idpopravke) {
            return base.Channel.izbrisiPopravku(idpopravke);
        }
        
        public System.Threading.Tasks.Task<bool> izbrisiPopravkuAsync(int idpopravke) {
            return base.Channel.izbrisiPopravkuAsync(idpopravke);
        }
        
        public bool azurirajPopravku(int idpopravkeAzuriranje, string deo, decimal cena_dela) {
            return base.Channel.azurirajPopravku(idpopravkeAzuriranje, deo, cena_dela);
        }
        
        public System.Threading.Tasks.Task<bool> azurirajPopravkuAsync(int idpopravkeAzuriranje, string deo, decimal cena_dela) {
            return base.Channel.azurirajPopravkuAsync(idpopravkeAzuriranje, deo, cena_dela);
        }
        
        public string deserijalizujPopravkuAzuriranje() {
            return base.Channel.deserijalizujPopravkuAzuriranje();
        }
        
        public System.Threading.Tasks.Task<string> deserijalizujPopravkuAzuriranjeAsync() {
            return base.Channel.deserijalizujPopravkuAzuriranjeAsync();
        }
    }
}
