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
using System.ComponentModel;

namespace SkolaJezikaWPF
{
    /// <summary>   
    /// Interaction logic for KorisniciWindow.xaml
    /// </summary>
    public partial class KorisniciWindow : Window
    {
        private CollectionViewSource cvs;
        public KorisniciWindow()
        {
            InitializeComponent();
            bIzmeni.IsEnabled = false;
            bObrisi.IsEnabled = false;
            cvs = new CollectionViewSource();
            cvs.Source = Aplikacija.Instanca.Korisnici;
            dgKorisnici.ItemsSource = cvs.View;

          //  cvs.SortDescriptions.Add(new SortDescription("Ime", ListSortDirection.Ascending));
            dgKorisnici.SelectedItem = null;
            

            //dgKorisnici.ItemsSource = Aplikacija.Instanca.Korisnici;
            //dgKorisnici.AutoGenerateColumns = true;
            dgKorisnici.IsReadOnly = true;
            dgKorisnici.SelectionMode = DataGridSelectionMode.Single;


            dgKorisnici.AutoGenerateColumns = false;

            DataGridTextColumn c = new DataGridTextColumn();

            c.Header = "Ime";
            c.Binding = new Binding("Ime");
            c.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
            dgKorisnici.Columns.Add(c);

            c = new DataGridTextColumn();

            c.Header = "Prezime";
            c.Binding = new Binding("Prezime");
            c.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
            dgKorisnici.Columns.Add(c);

            c = new DataGridTextColumn();

            c.Header = "JMBG";
            c.Binding = new Binding("JMBG");
            c.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
            dgKorisnici.Columns.Add(c);


            //OsveziKorisnike();
        }

        private void MyFilter(object sender, FilterEventArgs e)
        {
            Korisnik k = e.Item as Korisnik;
            if (k != null)
            {
                e.Accepted = k.Ime.ToLower().Contains(tbPretragaImena.Text.ToLower());
            }
        }


        //private void OsveziKorisnike()
        //{
        //    lbKorisnici.Items.Clear();
        //    foreach (Korisnik k in Aplikacija.Instanca.Korisnici)
        //    {
        //        lbKorisnici.Items.Add(k);
        //    }
        //}

        private void bDodaj_Click(object sender, RoutedEventArgs e)
        {
            Korisnik k = new Korisnik();

            KorisniciEditWindow kew = new KorisniciEditWindow(k);
            if (kew.ShowDialog() == true)
            {
             //   OsveziKorisnike();
            }
        }

        private void bIzmeni_Click(object sender, RoutedEventArgs e)
        {
            Korisnik k = dgKorisnici.SelectedItem as Korisnik;

            KorisniciEditWindow kew = new KorisniciEditWindow(k,MOD.IZMENA);
            if (kew.ShowDialog() == true)
            {
            //    OsveziKorisnike();
            }
        }

        private void bObrisi_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni?", "Potvrda brisanja", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Aplikacija.Instanca.Korisnici.Remove(dgKorisnici.SelectedItem as Korisnik);
             //   OsveziKorisnike();
            }
            if (Aplikacija.Instanca.Korisnici.Count == 0)
            {
                bIzmeni.IsEnabled = false;
                bObrisi.IsEnabled = false;
            }
        }


        private void bZatvori_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void lbKorisnici_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bIzmeni.IsEnabled = true;
            bObrisi.IsEnabled = true;
        }

        private void dgKorisnici_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bIzmeni.IsEnabled = true;
            bObrisi.IsEnabled = true;
        }

        private void tbPretragaImena_TextChanged(object sender, TextChangedEventArgs e)
        {
            cvs.Filter += new FilterEventHandler(MyFilter);
        }

        private void miOProgramu_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Skola jezika v1.0\nUradio: Pera Peric sw12345", "O programu", MessageBoxButton.OK);
        }

        private void miPoImenu_Click(object sender, RoutedEventArgs e)
        {

            cvs.SortDescriptions.Add(new SortDescription("Ime", ListSortDirection.Ascending));
            miPoPrezimenu.IsChecked = false;
            miPoJmbg.IsChecked = false;

        }

        private void miPoPrezimenu_Click(object sender, RoutedEventArgs e)
        {
            cvs.SortDescriptions.Add(new SortDescription("Prezime", ListSortDirection.Ascending));
            miPoImenu.IsChecked = false;
            miPoJmbg.IsChecked = false;
        }

        private void miPoJmbg_Click(object sender, RoutedEventArgs e)
        {
            cvs.SortDescriptions.Add(new SortDescription("JMBG", ListSortDirection.Ascending));
            miPoImenu.IsChecked = false;
            miPoPrezimenu.IsChecked = false;
        }
    }
}
