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
    /// Interaction logic for KursAdd3Window.xaml
    /// </summary>
    public partial class KursAdd3Window : Window
    {
        protected Jezik jez;
        protected List<Ucenik> ucen;
        protected Nastavnik nas;

        public KursAdd3Window(Jezik j, List<Ucenik> u,Nastavnik n)
        {
            InitializeComponent();

            this.jez = j;
            this.ucen = u;
            this.nas = n;

        }

        private void bSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            string cena = tbCena.Text; 
            
            TipKursa k = new TipKursa();
            k.Nivo = tbTip.Text;

            Kurs ku = new Kurs("5", jez, k, cena, nas, ucen);
            Aplikacija.Instanca.Kursevi.Add(ku);
            this.DialogResult = true;
            this.Close();
            
        }

        private void bOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
