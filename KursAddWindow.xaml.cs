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
    /// Interaction logic for KursAddWindow.xaml
    /// </summary>
    public partial class KursAddWindow : Window
    {
        private CollectionViewSource cvs;
        public KursAddWindow()
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

        private void bDalje_Click(object sender, RoutedEventArgs e)
        {
            Jezik n = dgJezik.SelectedItem as Jezik;
            KursAdd1Window kd = new KursAdd1Window(n);
            this.Close();
            kd.ShowDialog();
            
            
        }

        private void dgJezik_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
