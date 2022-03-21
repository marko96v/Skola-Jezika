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
    /// Interaction logic for UceniciWindow.xaml
    /// </summary>

    public partial class UceniciWindow : Window
    {
        private CollectionViewSource cvs;
        public UceniciWindow()
        {
            InitializeComponent();

            bIzmeni.IsEnabled = false;
            bObrisi.IsEnabled = false;
            cvs = new CollectionViewSource();
            cvs.Source = Aplikacija.Instanca.Ucenici;
            dgUcenici.ItemsSource = cvs.View;

            cvs.SortDescriptions.Add(new SortDescription("Ime", ListSortDirection.Ascending));
            dgUcenici.SelectedItem = null;



            dgUcenici.IsReadOnly = true;
            dgUcenici.SelectionMode = DataGridSelectionMode.Single;


            dgUcenici.AutoGenerateColumns = false;

            DataGridTextColumn c = new DataGridTextColumn();

            c.Header = "Ime";
            c.Binding = new Binding("Ime");
            c.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
            dgUcenici.Columns.Add(c);

            c = new DataGridTextColumn();

            c.Header = "Prezime";
            c.Binding = new Binding("Prezime");
            c.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
            dgUcenici.Columns.Add(c);

            c = new DataGridTextColumn();

            c.Header = "JMBG";
            c.Binding = new Binding("JMBG");
            c.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
            dgUcenici.Columns.Add(c);
        }

        private void MyFilter(object sender, FilterEventArgs e)
        {
            Ucenik u = e.Item as Ucenik;
            if (u != null)
            {
                e.Accepted = u.Ime.ToLower().Contains(tbPretragaImena.Text.ToLower());
            }
        }

        private void bDodaj_Click(object sender, RoutedEventArgs e)
        {
            Ucenik u = new Ucenik();

            UceniciEditWindow uew = new UceniciEditWindow(u);
            uew.ShowDialog();

        }

        private void bIzmeni_Click(object sender, RoutedEventArgs e)
        {
            Ucenik u = dgUcenici.SelectedItem as Ucenik;

            UceniciEditWindow uew = new UceniciEditWindow(u, MOD.IZMENA);
            uew.ShowDialog();

        }

        private void bObrisi_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni?", "Potvrda brisanja", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Aplikacija.Instanca.Ucenici.Remove(dgUcenici.SelectedItem as Ucenik);
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

        private void dgUcenici_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
