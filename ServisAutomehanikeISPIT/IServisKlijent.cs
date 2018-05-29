using System.ServiceModel;

namespace ServisAutomehanikeISPIT
{
    [ServiceContract]
    public interface IServisKlijent
    {
        [OperationContract]
        bool prijavljivanjeKlijenta(string korisnickoime, string lozinka);

        [OperationContract]
        string prikazPodatakaICena(string korisnickoime);

        [OperationContract]
        string deserijalizuj(string korisnickomime);
    }

}
