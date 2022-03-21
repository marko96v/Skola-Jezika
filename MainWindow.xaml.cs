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
using System.Windows.Navigation;
using System.Windows.Shapes;
using SkolaJezikaConsole;

namespace SkolaJezikaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        protected Korisnik kor;

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(Korisnik k) : this()
        {
            this.kor = k;
            if (kor.Tip.Naziv.Equals("radnik"))
            {
                bKorisnici.IsEnabled = false;
                bNastavnici.IsEnabled = false;
                bTipoviKursa.IsEnabled = false;
                bJezici.IsEnabled = false;
            }
        }

        private void bKorisnici_Click(object sender, RoutedEventArgs e)
        {
            KorisniciWindow kw = new KorisniciWindow();
            kw.ShowDialog();
        }

        private void bNastavnici_Click(object sender, RoutedEventArgs e)
        {
            NastavniciWindow nw = new NastavniciWindow();
            nw.ShowDialog();
        }

        private void bUcenici_Click(object sender, RoutedEventArgs e)
        {
            UceniciWindow uew = new UceniciWindow();
            uew.ShowDialog();
        }

        private void bOdjava_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow lw = new LoginWindow();
            this.Close();
            lw.ShowDialog();
        }

        private void bKursevi_Click(object sender, RoutedEventArgs e)
        {
            KursWindow kw = new KursWindow();
            kw.ShowDialog();
        }

        private void bUplate_Click(object sender, RoutedEventArgs e)
        {
            UplateWindow uw = new UplateWindow();
            uw.ShowDialog();
        }

        private void bTipoviKursa_Click(object sender, RoutedEventArgs e)
        {
            TipoviKursaWindow tw = new TipoviKursaWindow();
            tw.ShowDialog();
        }

        private void bJezici_Click(object sender, RoutedEventArgs e)
        {
            JezikWindow jw = new JezikWindow();
            jw.ShowDialog();
        }
    }
}
