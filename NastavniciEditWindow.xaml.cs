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
    /// Interaction logic for NastavniciEditWindow.xaml
    /// </summary>
    public partial class NastavniciEditWindow : Window
    {
        protected Nastavnik orginal, copyObj;
        protected MOD mod;

        public NastavniciEditWindow()
        {
            InitializeComponent();

        }

        public NastavniciEditWindow(Nastavnik n, MOD m = MOD.DODAVANJE) : this()
        {
            this.orginal = n;
            this.mod = m;
            this.copyObj = orginal.Clone() as Nastavnik;
            this.DataContext = copyObj;

            if (mod == MOD.IZMENA)
            {
                tbJmbg.IsEnabled = false;
            }
        }

        private void bSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            this.orginal.setValues(copyObj);

            if (mod == MOD.DODAVANJE)
            {
                Aplikacija.Instanca.Nastavnici.Add(orginal);
            }


            this.DialogResult = true;
            this.Close();
        }

        private void bOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
