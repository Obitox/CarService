using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServisAutomehanikeISPIT
{
    [ServiceContract]
    public interface IServisOperater
    {
        [OperationContract]
        Korisnik napraviKorisnika(Korisnik korisnik);

        [OperationContract]
        bool prijavljivanje(string korisnicko_ime, string lozinka);

        [OperationContract]
        Automobil napraviAutomobil(Automobil automobil);

        [OperationContract]
        bool napraviPopravku(Popravka popravka);

        [OperationContract]
        bool azuriranjeCeneDelova(int id_popravke, decimal novacena);

        [OperationContract]
        string deserijalizujPodatke();

        [OperationContract]
        string deserijalizujKorisnike();

        [OperationContract]
        string deserijalizujPopravke();

    }

    [DataContract]
    [Serializable]
    public class Korisnik
    {
        [DataMember]
        public string korisnicko_ime;
        [DataMember]
        public string lozinka;
    }

    [DataContract]
    [Serializable]
    public class Automobil
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string podaci;
        [DataMember]
        public string status;
        [DataMember]
        public decimal cena_popravke;
        [DataMember]
        public string korisnicko_ime;
        [DataMember]
        public int id_popravke;
    }

    [DataContract]
    [Serializable]
    public class Popravka
    {
        [DataMember]
        public int id_popravke;
        [DataMember]
        public string deo;
        [DataMember]
        public decimal cena_dela;
    }

}
