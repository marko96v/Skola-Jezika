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
    /// Interaction logic for TipoviKursaWindow.xaml
    /// </summary>
    public partial class TipoviKursaWindow : Window
    {
        private CollectionViewSource cvs;
        public TipoviKursaWindow()
        {
            InitializeComponent();

            cvs = new CollectionViewSource();
            cvs.Source = Aplikacija.Instanca.TipoviKursa;
            dgTipoviKursa.ItemsSource = cvs.View;

            dgTipoviKursa.SelectedItem = null;
            dgTipoviKursa.IsReadOnly = true;
            dgTipoviKursa.SelectionMode = DataGridSelectionMode.Single;
            dgTipoviKursa.AutoGenerateColumns = false;


            DataGridTextColumn c = new DataGridTextColumn();

            c.Header = "Nivo";
            c.Binding = new Binding("Nivo");
            c.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
            dgTipoviKursa.Columns.Add(c);
        }

        private void dgTipoviKursa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void tbPretragaKursa_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void bDodaj_Click(object sender, RoutedEventArgs e)
        {
            TipKursa t = new TipKursa();

            TipoviKursaEditWindow nw = new TipoviKursaEditWindow(t);
            nw.ShowDialog();
        }

        private void bIzmeni_Click(object sender, RoutedEventArgs e)
        {
            TipKursa t = dgTipoviKursa.SelectedItem as TipKursa;

            TipoviKursaEditWindow nw = new TipoviKursaEditWindow(t, MOD.IZMENA);
            nw.ShowDialog();
        }

        private void bObrisi_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni?", "Potvrda brisanja", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Aplikacija.Instanca.TipoviKursa.Remove(dgTipoviKursa.SelectedItem as TipKursa);
            }
            if (Aplikacija.Instanca.TipoviKursa.Count == 0)
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
