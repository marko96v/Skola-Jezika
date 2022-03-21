using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaJezikaConsole
{
    public class Nastavnik : Osoba
    {

        private List<Ucenik> ucenici;
        private List<Kurs> kursevi;

        public List<Ucenik> Ucenici { get; set; }
        public List<Kurs> Kursevi { get; set; }


        public Nastavnik()
        {

        }

        public Nastavnik(string ime, string prezime, string jmbg,DateTime datum) : base(ime, prezime, jmbg , datum)
        {
            this.kursevi = new List<Kurs>();
            this.ucenici = new List<Ucenik>();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        internal void setValues(Nastavnik copyObj)
        {
            this.Ime = copyObj.Ime;
            this.Prezime = copyObj.Prezime;
            this.JMBG = copyObj.JMBG;
            this.Ucenici = copyObj.ucenici;
            this.Kursevi = copyObj.kursevi;
        }
    }
}
