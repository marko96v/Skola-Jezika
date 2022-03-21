using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaJezikaConsole
{
    public class Ucenik : Osoba
    {

        private List<Kurs> kursevi;
        private List<Uplata> uplate;

        public List<Kurs> Kursevi { get; set; }
        public List<Uplata> Uplate { get; set; }

        public Ucenik()
        {

        }

        public Ucenik(string ime, string prezime, string jmbg, DateTime datum) : base(ime, prezime, jmbg, datum)
        {
            this.kursevi = new List<Kurs>();
            this.uplate = new List<Uplata>();
        }

        public Ucenik(string ime, string prezime, string jmbg, List<Kurs> kursevi, List<Uplata> uplate, DateTime datum) : base(ime, prezime, jmbg, datum)
        {
            this.Uplate = uplate;
            this.Kursevi = kursevi;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        internal void setValues(Ucenik copyObj)
        {
            this.Ime = copyObj.Ime;
            this.Prezime = copyObj.Prezime;
            this.JMBG = copyObj.JMBG;
            this.Uplate = copyObj.Uplate;
            this.Kursevi = copyObj.Kursevi;
        }
    }
}
