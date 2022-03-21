using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkolaJezikaConsole;
using System.Collections.ObjectModel;

namespace SkolaJezikaWPF
{
    public class Aplikacija
    {

        public const string CONN_STR = @"data source= .\SQLEXPRESS;
                                         initial catalog=SkolaJezika;
                                         integrated security=true";
        
        public ObservableCollection<Korisnik> Korisnici { get; set; }
        public ObservableCollection<TipKorisnika> TipoviKorisnika { get; set; }
        public ObservableCollection<Nastavnik> Nastavnici { get; set; }
        public ObservableCollection<Ucenik> Ucenici { get; set; }
        public ObservableCollection<Kurs> Kursevi { get; set; }
        public ObservableCollection<Jezik> Jezici { get; set; }
        public ObservableCollection<TipKursa> TipoviKursa { get; set; }
        public ObservableCollection<Uplata> Uplate { get; set; }

        private static Aplikacija instanca = new Aplikacija();

        public static Aplikacija Instanca
        {
            get { return instanca; }
        }

        private Aplikacija()
        {
            Korisnici = new ObservableCollection<Korisnik>();
            TipoviKorisnika = new ObservableCollection<TipKorisnika>();
            UcitajKorisnike();
            Nastavnici = new ObservableCollection<Nastavnik>();
            UcitajNastavnike();
            Ucenici = new ObservableCollection<Ucenik>();
            UcitajUcenike();
            Kursevi = new ObservableCollection<Kurs>();
            UcitajKurseve();
            TipoviKursa = new ObservableCollection<TipKursa>();
            UcitajTipoveKursa();
            Jezici = new ObservableCollection<Jezik>();
            UcitajJezike();
            Uplate = new ObservableCollection<Uplata>();
            UcitajUplate();
        }

        private void UcitajKorisnike()
        {
            TipoviKorisnika.Add(new TipKorisnika("admin","administrira sve entitete aplikacije"));
            TipoviKorisnika.Add(new TipKorisnika("radnik","ima pristup kursevima,uplatama i ucenicima"));

            Korisnik k = new Korisnik("Marko", "Markovic", "123",new DateTime(1996,1,1), "m", "m",TipoviKorisnika[0]);
            Korisnici.Add(k);
            Korisnici.Add(new Korisnik("Janko", "Jankovic", "321", new DateTime(1996, 12, 31), "j", "j",TipoviKorisnika[1]));
            Korisnici.Add(new Korisnik("Aleksa", "Zivic", "521", new DateTime(1996, 12, 31), "j", "j", TipoviKorisnika[1]));
            Korisnici.Add(new Korisnik("Milan", "Mitrovic", "333", new DateTime(1996, 6, 6), "mm", "mm",TipoviKorisnika[1]));
            Korisnici.Add(new Korisnik("Petar", "Petrovic", "444", new DateTime(1996, 8, 10), "p", "p",TipoviKorisnika[1]));
        }
        public void UcitajNastavnike() 
        {
            Nastavnik n = new Nastavnik("Nastavnik", "Nastic", "123", new DateTime(1996, 8, 10));
            Nastavnici.Add(n);
            Nastavnici.Add(new Nastavnik("Janko", "Jankic", "321", new DateTime(1996, 8, 10)));
            Nastavnici.Add(new Nastavnik("Sima", "Simic", "333", new DateTime(1996, 8, 10)));
            Nastavnici.Add(new Nastavnik("Stefan", "Stefanovic", "444", new DateTime(1996, 8, 10)));        
        }
        public void UcitajUcenike()
        {
            Ucenik n = new Ucenik("Ucen", "Ucenko", "123", new DateTime(1996, 8, 10));
            Ucenici.Add(n);
            Ucenici.Add(new Ucenik("Uros", "Urosevic", "321", new DateTime(1996, 8, 10)));
            Ucenici.Add(new Ucenik("Milos", "Anastasijevic", "333", new DateTime(1996, 8, 10)));
            Ucenici.Add(new Ucenik("Stefan", "Arsenovic", "444", new DateTime(1996, 8, 10)));
        }
        public void UcitajKurseve()
        {
            Jezik j = new Jezik("Engleski", "0");
            TipKursa tk = new TipKursa("osnovni");
            Nastavnik n = new Nastavnik("Nastavnik", "Nastic", "123", new DateTime(1996, 8, 10));
            Kurs k = new Kurs("0", j, tk, "500", n, new List<Ucenik>());
            Kursevi.Add(k);
        }
        public void UcitajTipoveKursa()
        {
            TipKursa tk = new TipKursa("osnovni");
            TipoviKursa.Add(tk);
            TipoviKursa.Add(new TipKursa("visi"));
            TipoviKursa.Add(new TipKursa("napredni"));
        }
        public void UcitajJezike()
        {
            Jezik j = new Jezik("Engleski", "0");
            Jezici.Add(j);
            Jezici.Add(new Jezik("Nemacki", "1"));
            Jezici.Add(new Jezik("Francuski", "2"));
        }
        public void UcitajUplate()
        {
            Jezik j = new Jezik("Engleski", "0");
            TipKursa tk = new TipKursa("osnovni");
            Nastavnik n = new Nastavnik("Nastavnik", "Nastic", "123", new DateTime(1996, 8, 10));
            Kurs k = new Kurs("0",j, tk, "50", n, new List<Ucenik>());

            Ucenik uc = new Ucenik("Ucen", "Ucenko", "123", new DateTime(1996, 8, 10));
            Uplata u = new Uplata(uc, 100, "0", k);
            Uplate.Add(u);
        }
    }
}
