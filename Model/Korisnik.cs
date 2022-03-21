using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaJezikaConsole
{
    public class Korisnik : Osoba , ICloneable, INotifyPropertyChanged
    {
       // public string KorisnickoIme { get; set; }

        public long Id { get; set; }

        private string korisnickoIme;

        public string KorisnickoIme
        {
            get { return korisnickoIme; }
            set { korisnickoIme = value;
            OnPropertyChanged("KorisnickoIme");
            }
        }

        //public string Lozinka { get; set; }
        private string lozinka;

        public string Lozinka
        {
            get { return lozinka; }
            set { lozinka = value;
            OnPropertyChanged("Lozinka");
            }
        }

        private TipKorisnika tip;

        public TipKorisnika Tip
        {
            get { return tip; }
            set { tip = value; }
        }
        

        


        public Korisnik()
        {
            
        }

        public Korisnik(string ime, string prezime, string jmbg,DateTime datum, string kime, string loz,TipKorisnika tip) : base(ime, prezime, jmbg, datum)
        {
            this.KorisnickoIme = kime;
            this.Lozinka = loz;
            this.Tip = tip;
        }

        public override string ToString()
        {
            return base.ToString() + "\nKorisnicko Ime: " + this.KorisnickoIme + "\nLozinka: " + this.Lozinka + "\n";
        }

        public bool LogIn(string kime, string loz)
        {
            if (kime == this.KorisnickoIme && Lozinka == this.Lozinka)
            {
                return true;
            }
            return false;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        internal void setValues(Korisnik copyObj)
        {
            this.Ime = copyObj.Ime;
            this.Prezime = copyObj.Prezime;
            this.JMBG = copyObj.JMBG;
            this.KorisnickoIme = copyObj.KorisnickoIme;
            this.Lozinka = copyObj.Lozinka;
            this.DatumRodjenja = copyObj.DatumRodjenja;
            this.Tip = copyObj.Tip;
        }
    }
}
