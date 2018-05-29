using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;


namespace ServisAutomehanikeISPIT
{
    [ServiceContract]
    interface IServisAdmin
    {
        [OperationContract]
        bool prijavljivanjeAdmina(string korisnickoime, string lozinka);

        [OperationContract]
        Korisnik kreirajKorisnika(Korisnik korisnik);

        [OperationContract]
        bool izbrisiKorisnika(string korisnickoime);

        [OperationContract]
        string deserijalizujKorisnikeAdmin();

        [OperationContract]
        bool AzurirajKorisnika(string korisnikZaAzuriranje, string korisnickoime, string lozinka);

        [OperationContract]
        Automobil kreirajAutomobil(Automobil automobil);

        [OperationContract]
        bool izbrisiAutomobil(int id_automobila);

        [OperationContract]
        bool azurirajAutomobil(int idautomobila, string podaci, string status, string korisnickoime, decimal cena_popravke);

        [OperationContract]
        string deserijalizujAutomobilAzuriranje();

        [OperationContract]
        bool kreirajPopravku(Popravka popravka);

        [OperationContract]
        bool izbrisiPopravku(int idpopravke);

        [OperationContract]
        bool azurirajPopravku(int idpopravkeAzuriranje, string deo, decimal cena_dela);

        [OperationContract]
        string deserijalizujPopravkuAzuriranje();

    }
}
