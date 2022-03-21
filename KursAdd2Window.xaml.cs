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
    /// Interaction logic for KursAdd2Window.xaml
    /// </summary>
    public partial class KursAdd2Window : Window
    {
        protected Jezik jez;
        protected List<Ucenik> ucen;
        private CollectionViewSource cvs;
        public KursAdd2Window(Jezik j,List<Ucenik> u)
        {
            InitializeComponent();

            this.jez = j;
            this.ucen = u;

            cvs = new CollectionViewSource();
            cvs.Source = Aplikacija.Instanca.Nastavnici;
            dgNastavnici.ItemsSource = cvs.View;
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

        private void dgNastavnici_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void bDalje_Click(object sender, RoutedEventArgs e)
        {
            Nastavnik n = dgNastavnici.SelectedItem as Nastavnik;
            KursAdd3Window ka = new KursAdd3Window(jez, ucen, n);
            this.Close();
            ka.ShowDialog();
            
        }
        
    }
}
