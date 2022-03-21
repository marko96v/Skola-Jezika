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
    /// Interaction logic for JezikWindow.xaml
    /// </summary>
    public partial class JezikWindow : Window
    {
        private CollectionViewSource cvs;
        public JezikWindow()
        {
            InitializeComponent();

            cvs = new CollectionViewSource();
            cvs.Source = Aplikacija.Instanca.Jezici;
            dgJezik.ItemsSource = cvs.View;

            dgJezik.SelectedItem = null;
            dgJezik.IsReadOnly = true;
            dgJezik.SelectionMode = DataGridSelectionMode.Single;
            dgJezik.AutoGenerateColumns = false;


            DataGridTextColumn c = new DataGridTextColumn();

            c.Header = "Oznaka";
            c.Binding = new Binding("Oznaka");
            c.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
            dgJezik.Columns.Add(c);

            c = new DataGridTextColumn();

            c.Header = "Naziv";
            c.Binding = new Binding("Naziv");
            c.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
            dgJezik.Columns.Add(c);
        }

        private void dgJezik_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void tbPretragaJezika_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void bDodaj_Click(object sender, RoutedEventArgs e)
        {
            Jezik j = new Jezik();

            JezikEditWindow jw = new JezikEditWindow(j);
            jw.ShowDialog();
        }

        private void bIzmeni_Click(object sender, RoutedEventArgs e)
        {
            Jezik j = dgJezik.SelectedItem as Jezik;

            JezikEditWindow jw = new JezikEditWindow(j, MOD.IZMENA);
            jw.ShowDialog();
        }

        private void bObrisi_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni?", "Potvrda brisanja", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Aplikacija.Instanca.Jezici.Remove(dgJezik.SelectedItem as Jezik);
            }
            if (Aplikacija.Instanca.Jezici.Count == 0)
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
