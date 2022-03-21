using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaJezikaConsole
{
    public class Osoba : INotifyPropertyChanged
    {
        //public string Ime { get; set; }

        private string ime;

        public string Ime
        {
            get { return ime; }
            set { ime = value;
            OnPropertyChanged("Ime");
            }
        }
        

        private string prezime;
        public bool Obrisan { get; set; }

	    public string Prezime
	    {
		    get { return prezime;}
		    set { prezime = value;
            OnPropertyChanged("Prezime");
            }
	    }

     //   public string JMBG { get; set; }

        private string jmbg;

        public string JMBG
        {
            get { return jmbg; }
            set { jmbg = value;
            OnPropertyChanged("JMBG");
            }
        }

        private DateTime datumRodjenja;

        public DateTime DatumRodjenja
        {
            get { return datumRodjenja; }
            set { datumRodjenja = value;
            OnPropertyChanged("DatumRodjenja");
            }
        }
        
        

        public Osoba()
        {
            this.datumRodjenja = DateTime.Now;
        }

        public Osoba(string ime, string prezime, string jmbg,DateTime datum)
        {
            this.Ime = ime;
            this.prezime = prezime;
            this.JMBG = jmbg;
            this.datumRodjenja = datum;
            this.Obrisan = false;
        }

        public override string ToString()
        {
            return "Ime: " + this.Ime + "\nPrezime: " + this.prezime + "\nJMBG: " + this.JMBG;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
