using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.ServiceModel;
using System.Text;

namespace ServisAutomehanikeISPIT
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class ServisMehanike : IServisOperater, IServisKlijent, IServisAdmin
    {
        private List<Korisnik> listaKorisnika;
        private List<Automobil> listaAutomobila;
        private List<Popravka> listaPopravki;
        private List<Korisnik> listaKlijenata;
        private List<Korisnik> listaAdmina; 

        public ServisMehanike()
        {
            listaKorisnika = new List<Korisnik>();
            listaAutomobila = new List<Automobil>();
            listaPopravki = new List<Popravka>();
            listaKlijenata = new List<Korisnik>();
            listaAdmina = new List<Korisnik>();

            if (File.Exists("Korisnici.bin"))
            {
                try
                {
                    using (Stream stream = File.Open("Korisnici.bin", FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        {
                            List<Korisnik> korisnici = (List<Korisnik>)bin.Deserialize(stream);
                            foreach (Korisnik item in korisnici)
                            {
                                listaKorisnika.Add(item);
                            }
                        }
                    }
                }
                catch (IOException) {}
            }
            if (File.Exists("Automobili.bin"))
            {
                try
                {
                    using (Stream stream = File.Open("Automobili.bin", FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        {
                            List<Automobil> automobili = (List<Automobil>)bin.Deserialize(stream);
                            foreach (Automobil item in automobili)
                            {
                                listaAutomobila.Add(item);
                            }
                        }
                    }
                }
                catch (IOException) { }
            }
            if (File.Exists("Popravke.bin"))
            {
                try
                {
                    using (Stream stream = File.Open("Popravke.bin", FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        {
                            List<Popravka> popravke = (List<Popravka>)bin.Deserialize(stream);
                            foreach (Popravka item in popravke)
                            {
                                listaPopravki.Add(item);
                            }
                        }
                    }
                }
                catch (IOException) { }
            }

        }

        public Korisnik napraviKorisnika(Korisnik korisnik)
        {
            listaKorisnika.Add(korisnik);

            try
            {
                using (Stream stream = File.Open("Korisnici.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, listaKorisnika);
                }
            }
            catch (IOException) {}

            return korisnik;
        }

        public bool prijavljivanje(string korisnicko_ime, string lozinka)
        {
            bool temp = false;

            foreach (Korisnik korisnik in listaKorisnika)
            {
                if (korisnik.korisnicko_ime.Equals(korisnicko_ime) && korisnik.lozinka.Equals(lozinka))
                {
                    temp = true;
                }
            }

            return temp;
        }

        public Automobil napraviAutomobil(Automobil automobil)
        {
            foreach (Korisnik korisnik in listaKorisnika)
            {
                if (korisnik.korisnicko_ime.Equals(automobil.korisnicko_ime))
                {
                    listaAutomobila.Add(automobil);
                    try
                    {
                        using (Stream stream = File.Open("Automobili.bin", FileMode.Create))
                        {
                            BinaryFormatter bin = new BinaryFormatter();
                            bin.Serialize(stream, listaAutomobila);
                        }
                    }
                    catch (IOException) { }
                }
            }

            return automobil;
        }

        public bool napraviPopravku(Popravka popravka)
        {
            bool provera = false;

            foreach(Automobil auta in listaAutomobila)
            {
                if (auta.id_popravke.Equals(popravka.id_popravke))
                {
                    listaPopravki.Add(popravka);
                    try
                    {
                        using (Stream stream = File.Open("Popravke.bin", FileMode.Create))
                        {
                            BinaryFormatter bin = new BinaryFormatter();
                            bin.Serialize(stream, listaPopravki);
                        }
                    }
                    catch (IOException) { }
                    provera = true;
                }
            }
        
            return provera;
        }

        public bool azuriranjeCeneDelova(int id_popravke, decimal novacena)
        {
            bool temp = false;

            for(int i=0; i < listaPopravki.Count; i++)
            {
                if (listaPopravki.ElementAt(i).id_popravke.Equals(id_popravke))
                {
                    if (listaAutomobila.ElementAt(i).id_popravke.Equals(id_popravke))
                    {
                        listaAutomobila.ElementAt(i).cena_popravke += listaPopravki.ElementAt(i).cena_dela - novacena ;
                    }
                    listaPopravki.ElementAt(i).cena_dela = novacena;
                    temp = true;
                    try
                    {
                        using (Stream stream = File.Open("Automobili.bin", FileMode.Create))
                        {
                            BinaryFormatter bin = new BinaryFormatter();
                            bin.Serialize(stream, listaAutomobila);
                        }

                        using (Stream stream = File.Open("Popravke.bin", FileMode.Create))
                        {
                            BinaryFormatter bin = new BinaryFormatter();
                            bin.Serialize(stream, listaPopravki);
                        }

                    }
                    catch (IOException) { }
                }
            }

            return temp;
        }

        public string deserijalizujPodatke()
        {
            string automobil = "";

            if (File.Exists("Automobili.bin"))
            {
                try
                {
                    using (Stream stream = File.Open("Automobili.bin", FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        {
                            List<Automobil> automobili = (List<Automobil>)bin.Deserialize(stream);
                            foreach (Automobil item in automobili)
                            {
                                automobil += "id:" + item.id + " podaci:" + item.podaci + " status:" + item.status + " korisnicko ime:" + item.korisnicko_ime + " cena popravke:" + item.cena_popravke + " id popravke:" + item.id_popravke+"|";
                            }
                        }
                    }
                }
                catch (IOException)
                {}
            }

            return automobil;
        }

        public string deserijalizujKorisnike()
        {
            string korisnik = "";

            if (File.Exists("Korisnici.bin"))
            {
                try
                {
                    using (Stream stream = File.Open("Korisnici.bin", FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        {
                            List<Korisnik> korisnici = (List<Korisnik>)bin.Deserialize(stream);
                            foreach (Korisnik item in korisnici)
                            {
                                korisnik += "korisnicko ime:"+item.korisnicko_ime+" lozinka:"+item.lozinka+"|";
                            }
                        }
                    }
                }
                catch (IOException)
                { }
            }

            return korisnik;
        }

        public string deserijalizujPopravke()
        {
            string popravka = "";

            if (File.Exists("Popravke.bin"))
            {
                try
                {
                    using (Stream stream = File.Open("Popravke.bin", FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        {
                            List<Popravka> popravke = (List<Popravka>)bin.Deserialize(stream);
                            foreach (Popravka item in popravke)
                            {
                                popravka += "id popravke:"+item.id_popravke+" deo:"+item.deo+" cena dela"+ item.cena_dela+"|";
                            }
                        }
                    }
                }
                catch (IOException)
                { }
            }

            return popravka;
        }

        public bool prijavljivanjeKlijenta(string korisnickoime, string lozinka)
        {
            bool temp = false;

            foreach (Korisnik korisnik in listaKorisnika)
            {
                if (korisnik.korisnicko_ime.Equals(korisnickoime) && korisnik.lozinka.Equals(lozinka))
                {
                    temp = true;
                }
            }

            return temp;
        }

        public string prikazPodatakaICena(string korisnickoime)
        {
            string podaci = "";

            for(int i = 0; i < listaAutomobila.Count; i++)
            {
                if (listaAutomobila.ElementAt(i).korisnicko_ime.Equals(korisnickoime))
                {
                    podaci += "Podaci:" + listaAutomobila.ElementAt(i).podaci + " Status:" + listaAutomobila.ElementAt(i).status + " Cena troskova:" + listaAutomobila.ElementAt(i).cena_popravke+"|";
                }

            }
                
            return podaci;
        }

        public string deserijalizuj(string korisnickoime)
        {
            int idpopravke = 0;
            string podaci = "";

            for (int i = 0; i < listaAutomobila.Count; i++)
            {
                if (listaAutomobila.ElementAt(i).korisnicko_ime.Equals(korisnickoime))
                {
                    listaAutomobila.RemoveAt(i);
                    idpopravke = listaAutomobila.ElementAt(i).id_popravke;
                    for (int x = 0; x < listaPopravki.Count; x++)
                    {
                        if (listaPopravki.ElementAt(x).id_popravke.Equals(idpopravke))
                        {
                            listaPopravki.RemoveAt(x);

                            for (int q = 0; q < listaAutomobila.Count; q++)
                            {
                                if (listaAutomobila.ElementAt(q).korisnicko_ime.Equals(korisnickoime))
                                {
                                    podaci += "Podaci:" + listaAutomobila.ElementAt(q).podaci + " Status:" + listaAutomobila.ElementAt(q).status + " Cena troskova:" + listaAutomobila.ElementAt(q).cena_popravke + "|";
                                }

                            }

                            try
                            {
                                using (Stream stream = File.Open("Automobili.bin", FileMode.Create))
                                {
                                    BinaryFormatter bin = new BinaryFormatter();
                                    bin.Serialize(stream, listaAutomobila);
                                }

                                using (Stream stream = File.Open("Popravke.bin", FileMode.Create))
                                {
                                    BinaryFormatter bin = new BinaryFormatter();
                                    bin.Serialize(stream, listaPopravki);
                                }

                            }
                            catch (IOException) { }
                        }
                    }
                }
            }

            return podaci;
        }

        public bool prijavljivanjeAdmina(string korisnickoime, string lozinka)
        {
            bool temp = false;

            listaAdmina.Add(new Korisnik() { korisnicko_ime = "Admin", lozinka = "admin"});

            foreach (Korisnik korisnik in listaAdmina)
            {
                if (korisnik.korisnicko_ime.Equals(korisnickoime) && korisnik.lozinka.Equals(lozinka))
                {
                    temp = true;
                }
            }

            return temp;
        }

        public Korisnik kreirajKorisnika(Korisnik korisnik)
        {
            listaKorisnika.Add(korisnik);

            try
            {
                using (Stream stream = File.Open("Korisnici.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, listaKorisnika);
                }
            }
            catch (IOException) { }

            return korisnik;
        }

        public bool izbrisiKorisnika(string korisnickoime)
        {
            bool temp = false;

            for(int i = 0; i < listaKorisnika.Count; i++)
            {
                if (listaKorisnika.ElementAt(i).korisnicko_ime.Equals(korisnickoime))
                {
                    for(int x = 0; x < listaAutomobila.Count; x++)
                    {
                        if (listaAutomobila.ElementAt(i).korisnicko_ime.Equals(korisnickoime))
                        {
                            if (!listaAutomobila.ElementAt(i).status.Equals("popravlja se"))
                            {
                                listaKorisnika.RemoveAt(i);
                                try
                                {
                                    using (Stream stream = File.Open("Korisnici.bin", FileMode.Create))
                                    {
                                        BinaryFormatter bin = new BinaryFormatter();
                                        bin.Serialize(stream, listaKorisnika);
                                    }
                                }
                                catch (IOException) { }
                            }
                        }
                        else
                        {
                            listaKorisnika.RemoveAt(i);
                            try
                            {
                                using (Stream stream = File.Open("Korisnici.bin", FileMode.Create))
                                {
                                    BinaryFormatter bin = new BinaryFormatter();
                                    bin.Serialize(stream, listaKorisnika);
                                }
                            }
                            catch (IOException) { }
                        }
                    }
                }
            }

            return temp;
        }

        public string deserijalizujKorisnikeAdmin()
        {
            string korisnik = "";

            if (File.Exists("Korisnici.bin"))
            {
                try
                {
                    using (Stream stream = File.Open("Korisnici.bin", FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        {
                            List<Korisnik> korisnici = (List<Korisnik>)bin.Deserialize(stream);
                            foreach (Korisnik item in korisnici)
                            {
                                korisnik += "korisnicko ime:" + item.korisnicko_ime + " lozinka:" + item.lozinka + "|";
                            }
                        }
                    }
                }
                catch (IOException)
                { }
            }

            return korisnik;
        }

        public bool AzurirajKorisnika(string korisnikZaAzuriranje, string korisnickoime, string lozinka)
        {
            bool temp = false;

            for (int i = 0; i < listaKorisnika.Count; i++)
            {
                if(listaKorisnika.ElementAt(i).korisnicko_ime.Equals(korisnikZaAzuriranje))
                {
                    for (int x = 0; x < listaAutomobila.Count; x++)
                    {
                        if (listaAutomobila.ElementAt(x).korisnicko_ime.Equals(korisnikZaAzuriranje))
                        {
                            temp = true;
                            listaAutomobila.ElementAt(x).korisnicko_ime = korisnickoime;
                            listaKorisnika.ElementAt(i).korisnicko_ime = korisnickoime;
                            listaKorisnika.ElementAt(i).lozinka = lozinka;
                            try
                            {
                                using (Stream stream = File.Open("Korisnici.bin", FileMode.Create))
                                {
                                    BinaryFormatter bin = new BinaryFormatter();
                                    bin.Serialize(stream, listaKorisnika);
                                }

                                using (Stream stream = File.Open("Automobili.bin", FileMode.Create))
                                {
                                    BinaryFormatter bin = new BinaryFormatter();
                                    bin.Serialize(stream, listaAutomobila);
                                }

                            }
                            catch (IOException) { }
                        }
                        else if(!listaAutomobila.ElementAt(x).korisnicko_ime.Equals(korisnikZaAzuriranje))
                        {
                            temp = true;
                            listaKorisnika.ElementAt(i).korisnicko_ime = korisnickoime;
                            listaKorisnika.ElementAt(i).lozinka = lozinka;
                            try
                            {
                                using (Stream stream = File.Open("Korisnici.bin", FileMode.Create))
                                {
                                    BinaryFormatter bin = new BinaryFormatter();
                                    bin.Serialize(stream, listaKorisnika);
                                }
                            }
                            catch (IOException) { }
                        }
                    }
                }
            }
            return temp;
        }

        public Automobil kreirajAutomobil(Automobil automobil)
        {
            foreach (Korisnik korisnik in listaKorisnika)
            {
                if (korisnik.korisnicko_ime.Equals(automobil.korisnicko_ime))
                {
                    listaAutomobila.Add(automobil);
                    try
                    {
                        using (Stream stream = File.Open("Automobili.bin", FileMode.Create))
                        {
                            BinaryFormatter bin = new BinaryFormatter();
                            bin.Serialize(stream, listaAutomobila);
                        }
                    }
                    catch (IOException) { }
                }
            }

            return automobil;
        }

        public bool izbrisiAutomobil(int id_automobila)
        {
            bool temp = false;
            int idpopravke = 0;

            for (int i = 0; i < listaAutomobila.Count; i++)
            {
                if (listaAutomobila.ElementAt(i).id.Equals(id_automobila) && (!listaAutomobila.ElementAt(i).status.Equals("popravlja se")))
                {
                    listaAutomobila.RemoveAt(i);
                    for (int x = 0; x < listaPopravki.Count; x++)
                    {
                        if (listaPopravki.ElementAt(x).id_popravke.Equals(idpopravke))
                        {
                            listaPopravki.RemoveAt(x);
                            temp = true;
                            try
                            {
                                using (Stream stream = File.Open("Automobili.bin", FileMode.Create))
                                {
                                    BinaryFormatter bin = new BinaryFormatter();
                                    bin.Serialize(stream, listaAutomobila);
                                }

                                using (Stream stream = File.Open("Popravke.bin", FileMode.Create))
                                {
                                    BinaryFormatter bin = new BinaryFormatter();
                                    bin.Serialize(stream, listaPopravki);
                                }

                            }
                            catch (IOException) { }
                        }
                        else if (!listaPopravki.ElementAt(x).id_popravke.Equals(idpopravke))
                        {
                            try
                            {
                                using (Stream stream = File.Open("Automobili.bin", FileMode.Create))
                                {
                                    BinaryFormatter bin = new BinaryFormatter();
                                    bin.Serialize(stream, listaAutomobila);
                                }

                            }
                            catch (IOException) { }
                        }

                    }
                }
            }

            return temp;
        }

        public bool azurirajAutomobil(int idautomobila, string podaci, string status, string korisnickoime, decimal cena_popravke)
        {
            bool temp = false;

            for(int i = 0; i < listaAutomobila.Count; i++)
            {
                if (listaAutomobila.ElementAt(i).id.Equals(idautomobila))
                {
                    listaAutomobila.ElementAt(i).podaci = podaci;
                    listaAutomobila.ElementAt(i).status = status;
                    listaAutomobila.ElementAt(i).korisnicko_ime = korisnickoime;
                    listaAutomobila.ElementAt(i).cena_popravke = cena_popravke;
                    try
                    {
                        using (Stream stream = File.Open("Automobili.bin", FileMode.Create))
                        {
                            BinaryFormatter bin = new BinaryFormatter();
                            bin.Serialize(stream, listaAutomobila);
                        }

                    }
                    catch (IOException) { }
                }
            }

            return temp;
        }

        public string deserijalizujAutomobilAzuriranje()
        {
            string automobil = "";

            if (File.Exists("Automobili.bin"))
            {
                try
                {
                    using (Stream stream = File.Open("Automobili.bin", FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        {
                            List<Automobil> automobili = (List<Automobil>)bin.Deserialize(stream);
                            foreach (Automobil item in automobili)
                            {
                                automobil += "id:" + item.id + " podaci:" + item.podaci + " status:" + item.status + " korisnicko ime:" + item.korisnicko_ime + " cena popravke:" + item.cena_popravke + " id popravke:" + item.id_popravke + "|";
                            }
                        }
                    }
                }
                catch (IOException)
                { }
            }

            return automobil;
        }

        public bool kreirajPopravku(Popravka popravka)
        {
            bool provera = false;

            foreach (Automobil auta in listaAutomobila)
            {
                if (auta.id_popravke.Equals(popravka.id_popravke))
                {
                    listaPopravki.Add(popravka);
                    try
                    {
                        using (Stream stream = File.Open("Popravke.bin", FileMode.Create))
                        {
                            BinaryFormatter bin = new BinaryFormatter();
                            bin.Serialize(stream, listaPopravki);
                        }
                    }
                    catch (IOException) { }
                    provera = true;
                }
            }

            return provera;
        }

        public bool izbrisiPopravku(int id_popravke)
        {
            bool temp = false;

            for (int i = 0; i < listaPopravki.Count; i++)
            {
                if (listaPopravki.ElementAt(i).id_popravke.Equals(id_popravke))
                {
                    if (listaAutomobila.ElementAt(i).id_popravke.Equals(id_popravke))
                    {
                        listaAutomobila.ElementAt(i).cena_popravke -= listaPopravki.ElementAt(i).cena_dela;
                    }
                    listaPopravki.RemoveAt(i);
                    temp = true;
                    try
                    {
                        using (Stream stream = File.Open("Automobili.bin", FileMode.Create))
                        {
                            BinaryFormatter bin = new BinaryFormatter();
                            bin.Serialize(stream, listaAutomobila);
                        }

                        using (Stream stream = File.Open("Popravke.bin", FileMode.Create))
                        {
                            BinaryFormatter bin = new BinaryFormatter();
                            bin.Serialize(stream, listaPopravki);
                        }

                    }
                    catch (IOException) { }
                }
            }

            return temp;
        }

        public bool azurirajPopravku(int idpopravkeAzuriranje, string deo, decimal cena_dela)
        {
            bool temp = false;

            for (int i = 0; i < listaPopravki.Count; i++)
            {
                if (listaPopravki.ElementAt(i).id_popravke.Equals(idpopravkeAzuriranje))
                {
                    for(int x = 0; x < listaAutomobila.Count; x++)
                    {
                        if (listaAutomobila.ElementAt(x).id_popravke.Equals(idpopravkeAzuriranje))
                        {
                            listaAutomobila.ElementAt(x).cena_popravke += listaPopravki.ElementAt(i).cena_dela - cena_dela;
                        }
                    }
                    listaPopravki.ElementAt(i).deo = deo;
                    listaPopravki.ElementAt(i).cena_dela = cena_dela;
                    try
                    {
                        using (Stream stream = File.Open("Automobili.bin", FileMode.Create))
                        {
                            BinaryFormatter bin = new BinaryFormatter();
                            bin.Serialize(stream, listaAutomobila);
                        }

                        using (Stream stream = File.Open("Popravke.bin", FileMode.Create))
                        {
                            BinaryFormatter bin = new BinaryFormatter();
                            bin.Serialize(stream, listaPopravki);
                        }

                    }
                    catch (IOException) { }
                }
            }

            return temp;
        }

        public string deserijalizujPopravkuAzuriranje()
        {
            string popravka = "";

            if (File.Exists("Popravke.bin"))
            {
                try
                {
                    using (Stream stream = File.Open("Popravke.bin", FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        {
                            List<Popravka> popravke = (List<Popravka>)bin.Deserialize(stream);
                            foreach (Popravka item in popravke)
                            {
                                popravka += "id popravke:" + item.id_popravke + " deo:" + item.deo + " cena dela" + item.cena_dela + "|";
                            }
                        }
                    }
                }
                catch (IOException)
                { }
            }

            return popravka;
        }
    }
}
