using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SkolaJezikaConsole
{
    public class Uplata : INotifyPropertyChanged
    {

        private Ucenik ucenik;

        public Ucenik Ucenik
        {
            get { return ucenik; }
            set { ucenik = value;
            OnPropertyChanged("Ucenik");
            }
        }
        

        private double cena;

        public double Cena
        {
            get { return cena; }
            set { cena = value;
            OnPropertyChanged("Cena");
            }
        }
        

        private string oznaka;

        public string Oznaka
        {
            get { return oznaka; }
            set { oznaka = value;
            OnPropertyChanged("Oznaka");
            }
        }
        
        private Kurs kurs;

        public Kurs Kurs
        {
            get { return kurs; }
            set { kurs = value;
            OnPropertyChanged("Kurs");
            }
        }
        
        public bool Obrisan { get; set; }

        public Uplata()
        {

        }

        public Uplata(Ucenik ucenik, double kolicina, string oznaka, Kurs kurs)
        {
            this.Ucenik = ucenik;
            this.Cena = kolicina;
            this.Oznaka = oznaka;
            this.Kurs = kurs;
        }

        public override string ToString()
        {
            return "Oznaka: " + this.Oznaka + "\nUcenik: " +
                this.Ucenik.JMBG + "\nCena: " + this.Cena;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        internal void setValues(Uplata copyObj)
        {
            this.Ucenik = copyObj.Ucenik;
            this.Cena = copyObj.Cena;
            this.Oznaka = copyObj.Oznaka;
            this.Kurs = copyObj.Kurs;
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
