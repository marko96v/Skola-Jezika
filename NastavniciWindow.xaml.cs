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
    public partial class NastavniciWindow : Window
    {
        private CollectionViewSource cvs;
        public NastavniciWindow()
        {
            InitializeComponent();

            bIzmeni.IsEnabled = false;
            bObrisi.IsEnabled = false;
            cvs = new CollectionViewSource();
            cvs.Source = Aplikacija.Instanca.Nastavnici;
            dgNastavnici.ItemsSource = cvs.View;

            cvs.SortDescriptions.Add(new SortDescription("Ime", ListSortDirection.Ascending));
            dgNastavnici.SelectedItem = null;



            dgNastavnici.IsReadOnly = true;
            dgNastavnici.SelectionMode = DataGridSelectionMode.Single;


            dgNastavnici.AutoGenerateColumns = false;

            DataGridTextColumn c = new DataGridTextColumn();

            c.Header = "Ime";
            c.Binding = new Binding("Ime");
            c.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
            dgNastavnici.Columns.Add(c);

            c = new DataGridTextColumn();

            c.Header = "Prezime";
            c.Binding = new Binding("Prezime");
            c.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
            dgNastavnici.Columns.Add(c);
            
            c = new DataGridTextColumn();

            c.Header = "JMBG";
            c.Binding = new Binding("JMBG");
            c.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
            dgNastavnici.Columns.Add(c);
        }

        private void MyFilter(object sender, FilterEventArgs e)
        {
            Nastavnik n = e.Item as Nastavnik;
            if (n != null)
            {
                e.Accepted = n.Ime.ToLower().Contains(tbPretragaImena.Text.ToLower());
            }
        }


        private void bDodaj_Click(object sender, RoutedEventArgs e)
        {
            Nastavnik n = new Nastavnik();

            NastavniciEditWindow neew = new NastavniciEditWindow(n);
            neew.ShowDialog();

        }

        private void bIzmeni_Click(object sender, RoutedEventArgs e)
        {
            Nastavnik n = dgNastavnici.SelectedItem as Nastavnik;

            NastavniciEditWindow neew = new NastavniciEditWindow(n, MOD.IZMENA);
            neew.ShowDialog();

        }

        private void bObrisi_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni?", "Potvrda brisanja", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Aplikacija.Instanca.Nastavnici.Remove(dgNastavnici.SelectedItem as Nastavnik);
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

        private void dgNastavnici_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bIzmeni.IsEnabled = true;
            bObrisi.IsEnabled = true;
        }

        private void tbPretragaImena_TextChanged(object sender, TextChangedEventArgs e)
        {
            cvs.Filter += new FilterEventHandler(MyFilter);
        }
    }
}
