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
    /// Interaction logic for UplateEditWindow.xaml
    /// </summary>
    public partial class UplateEditWindow : Window
    {
        protected Uplata orginal, copyObj;
        protected MOD mod;

        public UplateEditWindow()
        {
            InitializeComponent();
        }
        public UplateEditWindow(Uplata u, MOD m = MOD.DODAVANJE) : this()
        {
            this.orginal = u;
            this.mod = m;
            this.copyObj = orginal.Clone() as Uplata;
            this.DataContext = copyObj;

            if (mod == MOD.IZMENA)
            {
                tbID.IsEnabled = false;
            }
        }

        private void bSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            this.orginal.setValues(copyObj);

            if (mod == MOD.DODAVANJE)
            {
                Aplikacija.Instanca.Uplate.Add(orginal);
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
