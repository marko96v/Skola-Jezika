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
    /// Interaction logic for KursAdd1Window.xaml
    /// </summary>
    public partial class KursAdd1Window : Window
    {
        protected Jezik jez;
        private CollectionViewSource cvs;
        public KursAdd1Window(Jezik j)
        {
            InitializeComponent();

            this.jez = j;

            cvs = new CollectionViewSource();
            cvs.Source = Aplikacija.Instanca.Ucenici;
            dgUcenici.ItemsSource = cvs.View;
            dgUcenici.SelectedItem = null;
            dgUcenici.IsReadOnly = true;
            dgUcenici.SelectionMode = DataGridSelectionMode.Extended;


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

        private void dgUcenici_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void bDalje_Click(object sender, RoutedEventArgs e)
        {
            List<Ucenik> ucenici = dgUcenici.SelectedItems.Cast<Ucenik>().ToList();
            KursAdd2Window ka = new KursAdd2Window(jez,ucenici);
            this.Close();
            ka.ShowDialog();
           
        }
    }
}
