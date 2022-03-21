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
    /// Interaction logic for JezikEditWindow.xaml
    /// </summary>
    public partial class JezikEditWindow : Window
    {
        protected Jezik orginal, copyObj;
        protected MOD mod;
        public JezikEditWindow()
        {
            InitializeComponent();
        }

        public JezikEditWindow(Jezik j, MOD m = MOD.DODAVANJE) : this()
        {
            this.orginal = j;
            this.mod = m;
            this.copyObj = orginal.Clone() as Jezik;
            this.DataContext = copyObj;

            if (mod == MOD.IZMENA)
            {
                tbOznaka.IsEnabled = false;
            }
        }

        private void bSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            this.orginal.setValues(copyObj);

            if (mod == MOD.DODAVANJE)
            {
                Aplikacija.Instanca.Jezici.Add(orginal);
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
