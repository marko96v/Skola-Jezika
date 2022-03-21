using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaJezikaConsole
{
    public class Kurs : INotifyPropertyChanged
    {

        private string id;

        public string ID
        {
            get { return id; }
            set { id = value;
            OnPropertyChanged("ID");
            }
        }
        
        private Jezik jezikKursa;

        public Jezik JezikKursa
        {
            get { return jezikKursa; }
            set { jezikKursa = value;
            OnPropertyChanged("JezikKursa");
            }
        }
        
        private TipKursa tip;

        public TipKursa Tip
        {
            get { return tip; }
            set { tip = value;
            OnPropertyChanged("Tip");
            }
        }
        
        private string cena;

        public string Cena
        {
            get { return cena; }
            set { cena = value;
            OnPropertyChanged("Cena");
            }
        }
        

        private Nastavnik predavac;

        public Nastavnik Predavac
        {
            get { return predavac; }
            set { predavac = value;
            OnPropertyChanged("Predavac");
            }
        }
        
        public bool Obrisan { get; set; }
        List<Ucenik> ucenici = new List<Ucenik>();

        public Kurs()
        {

        }

        public Kurs(String ID,Jezik jezik, TipKursa tip, string cena, Nastavnik predavac, List<Ucenik> ucenici)
        {
            this.ID = ID;
            this.JezikKursa = jezik;
            this.Tip = tip;
            this.Cena = cena;
            this.Predavac = predavac;
            this.ucenici = ucenici;
            this.Obrisan = false;
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
