using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SkolaJezikaConsole;
using SkolaJezikaWPF.DAO;

namespace SkolaJezikaWPF
{
    /// <summary>
    /// Interaction logic for KorisniciEditWindow.xaml
    /// </summary>
    public enum MOD { DODAVANJE, IZMENA };
    public partial class KorisniciEditWindow : Window
    {

        protected Korisnik orginal, copyObj;
        protected MOD mod;

        public KorisniciEditWindow()
        {
            InitializeComponent();
        }

        public KorisniciEditWindow(Korisnik k, MOD m = MOD.DODAVANJE) : this()
        {
            this.orginal = k;
            this.mod = m;
            this.copyObj = orginal.Clone() as Korisnik;
            this.DataContext = copyObj;
            cbTip.ItemsSource = Aplikacija.Instanca.TipoviKorisnika;

           // tbIme.Text = orginal.Ime;
           // tbPrzime.Text = orginal.Prezime;
         //   tbJmbg.Text = orginal.JMBG;
          //  tbKime.Text = orginal.KorisnickoIme;
          //  tbLozinka.Text = orginal.Lozinka;

            if (mod == MOD.IZMENA)
            {
                tbJmbg.IsEnabled = false;
            }
        }

        private void bSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            this.orginal.setValues(copyObj);
            //orginal.Ime = tbIme.Text;
            //orginal.Prezime = tbPrzime.Text;
            //orginal.JMBG = tbJmbg.Text;
            //orginal.KorisnickoIme = tbKime.Text;
            //orginal.Lozinka = tbLozinka.Text;

            if (mod == MOD.DODAVANJE)
            {
                Aplikacija.Instanca.Korisnici.Add(orginal);
                KorisnikDAO.Create(orginal);
            }


            this.DialogResult = true;
            this.Close();
        }

        private void bOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
