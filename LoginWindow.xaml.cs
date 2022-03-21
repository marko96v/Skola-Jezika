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
using System.Collections.ObjectModel;

namespace SkolaJezikaWPF
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        
        ObservableCollection<Korisnik> Korisnici = new ObservableCollection<Korisnik>();
        protected Korisnik korisnik;
       // Korisnici = Aplikacija.Instanca.Korisnici;
        public LoginWindow()
        {
            Korisnici = Aplikacija.Instanca.Korisnici;
            InitializeComponent();
            
        }
        bool korisnikLogg = false;
        private void bPrijava_Click(object sender, RoutedEventArgs e)
        {
            while (korisnikLogg == false)
            {
                foreach (Korisnik kor in Korisnici)
                {
                    if (tbKorisnickoIme.Text.Equals(kor.KorisnickoIme) && pbLozinka.Password.Equals(kor.Lozinka))
                    {
                        korisnik = kor;
                        korisnikLogg = true;
                    }
                }
                if (korisnikLogg == false)
                {
                    MessageBox.Show("Uneli ste pogresne podatke", "Greska", MessageBoxButton.OK);
                    tbKorisnickoIme.Text = string.Empty;
                    pbLozinka.Password = string.Empty;
                    return;
                }
            }
            if (korisnikLogg == true)
            {
                MainWindow mw = new MainWindow(korisnik);
                this.Close();
                mw.ShowDialog();
            }

        }
        private void bIzlaz_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
