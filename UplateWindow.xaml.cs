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
    /// Interaction logic for UplateWindow.xaml
    /// </summary>
    public partial class UplateWindow : Window
    {
        private CollectionViewSource cvs;
        public UplateWindow()
        {
            InitializeComponent();

            cvs = new CollectionViewSource();
            cvs.Source = Aplikacija.Instanca.Uplate;
            dgUplate.ItemsSource = cvs.View;
            dgUplate.SelectedItem = null;



            dgUplate.IsReadOnly = true;
            dgUplate.SelectionMode = DataGridSelectionMode.Single;


            dgUplate.AutoGenerateColumns = false;

            DataGridTextColumn c = new DataGridTextColumn();

            c.Header = "Oznaka";
            c.Binding = new Binding("Oznaka");
            c.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
            dgUplate.Columns.Add(c);

            c = new DataGridTextColumn();

            c.Header = "Ucenik";
            c.Binding = new Binding("Ucenik");
            c.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
            dgUplate.Columns.Add(c);

            c = new DataGridTextColumn();

            c.Header = "Cena";
            c.Binding = new Binding("Cena");
            c.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
            dgUplate.Columns.Add(c);
        }

        private void bDodaj_Click(object sender, RoutedEventArgs e)
        {
            Uplata u = new Uplata();

            UplateEditWindow uew = new UplateEditWindow(u);
            uew.ShowDialog();

        }

        private void bIzmeni_Click(object sender, RoutedEventArgs e)
        {
            Uplata u = dgUplate.SelectedItem as Uplata;

            UplateEditWindow uew = new UplateEditWindow(u, MOD.IZMENA);
            uew.ShowDialog();

        }

        private void bObrisi_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni?", "Potvrda brisanja", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Aplikacija.Instanca.Uplate.Remove(dgUplate.SelectedItem as Uplata);
            }
            if (Aplikacija.Instanca.Uplate.Count == 0)
            {
                bIzmeni.IsEnabled = false;
                bObrisi.IsEnabled = false;
            }
        }


        private void bZatvori_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dgUplate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
