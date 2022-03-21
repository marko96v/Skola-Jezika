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

namespace SkolaJezikaWPF
{
    /// <summary>
    /// Interaction logic for KursWindow.xaml
    /// </summary>
    public partial class KursWindow : Window
    {
        private CollectionViewSource cvs;
        public KursWindow()
        {
            InitializeComponent();

            cvs = new CollectionViewSource();
            cvs.Source = Aplikacija.Instanca.Kursevi;
            dgKursevi.ItemsSource = cvs.View;

            dgKursevi.SelectedItem = null;
            dgKursevi.IsReadOnly = true;
            dgKursevi.SelectionMode = DataGridSelectionMode.Single;
            dgKursevi.AutoGenerateColumns = false;

            DataGridTextColumn c = new DataGridTextColumn();

            c.Header = "Tip";
            c.Binding = new Binding("Tip");
            c.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
            dgKursevi.Columns.Add(c);

            c = new DataGridTextColumn();

            c.Header = "Jezik";
            c.Binding = new Binding("JezikKursa");
            c.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
            dgKursevi.Columns.Add(c);

            c = new DataGridTextColumn();

            c.Header = "Cena";
            c.Binding = new Binding("Cena");
            c.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
            dgKursevi.Columns.Add(c);

        }

        private void dgKursevi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void bDodaj_Click(object sender, RoutedEventArgs e)
        {
            KursAddWindow ka = new KursAddWindow();
            ka.ShowDialog();
        }

        private void bIzmeni_Click(object sender, RoutedEventArgs e)
        {
          /*  Kurs k = dgKursevi.SelectedItem as Kurs;

            KursAddWindow uew = new KursAddWindow(k);
            uew.ShowDialog();*/

        }

        private void bObrisi_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni?", "Potvrda brisanja", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Aplikacija.Instanca.Kursevi.Remove(dgKursevi.SelectedItem as Kurs);
            }
            if (Aplikacija.Instanca.Kursevi.Count == 0)
            {
                bIzmeni.IsEnabled = false;
                bObrisi.IsEnabled = false;
            }
        }


        private void bZatvori_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
