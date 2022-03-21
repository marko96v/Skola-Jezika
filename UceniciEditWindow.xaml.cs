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
    /// Interaction logic for UceniciEditWindow.xaml
    /// </summary>
    public partial class UceniciEditWindow : Window
    {
        protected Ucenik orginal, copyObj;
        protected MOD mod;

        public UceniciEditWindow()
        {
            InitializeComponent();
        }

        public UceniciEditWindow(Ucenik u, MOD m = MOD.DODAVANJE) : this()
        {
            this.orginal = u;
            this.mod = m;
            this.copyObj = orginal.Clone() as Ucenik;
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
                Aplikacija.Instanca.Ucenici.Add(orginal);
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
